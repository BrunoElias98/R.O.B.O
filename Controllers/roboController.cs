using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using API.Service;

namespace API.Controllers
{

    public class RoboController : ApiController
    {
        private ServiceRobo serviceRobo;

        public RoboController()
        {
            this.serviceRobo = new ServiceRobo();
        }

        public Robo[] Get()
        {
            return this.serviceRobo.GetAllRobos();
        }

        public HttpResponseMessage Post(Robo robo)
        {
            this.serviceRobo.Save(robo);

            var response = Request.CreateResponse<Robo>(System.Net.HttpStatusCode.Created, robo);

            return response;
        }
    }
}
