using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.Models;
using API.Controllers;

namespace API.Service
{
    public class ServiceRobo
    {

        private const string CacheKey = "RoboStore";

        public Robo[] GetAllRobos()
        {
            var context = HttpContext.Current;

            if (context != null)
            {
                return (Robo[])context.Cache[CacheKey];
            }

            return new Robo[]
            {

            new Robo
                {
                Name = "Placeholder"
                }
            };
        }
        
        public ServiceRobo()
        {
            var context = HttpContext.Current;

            if (context != null)
            {
                if (context.Cache[CacheKey] == null)
                {
                    var robos = new Robo[]
                    {
                        new Robo
                        {
                            //estados iniciais do R.O.B.O

                            Name = "",
                            CabecaInclinacao = 2,
                            CabecaRotacao = 3,
                            BracoEsquerdoCotovelo = 1,
                            BracoEsquerdoPulso = 3,
                            BracoDireitoCotovelo = 1,
                            BracoDireitoPulso = 3
                        }
                    };

                    context.Cache[CacheKey] = robos;
                }
            }
        }

        public bool Save(Robo robo)
        {
            var context = HttpContext.Current;

            if (context != null)
            {
                try
                {
                    var currentData = ((Robo[])context.Cache[CacheKey]).ToList();
                    currentData.Add(robo);
                    context.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }
    }
}