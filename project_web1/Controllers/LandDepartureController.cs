using _1112_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1112_.Controllers
{
    public class LandDepartureController : ApiController
    {
        public IEnumerable<Flight> Get()
        {
            return new Flight[] {
                new Flight(1, "447", "IL", "CA", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), 50),
                new Flight(2, "8956", "FR", "EG", DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), 50),
                new Flight(3, "008", "AF", "SG", DateTime.Now.AddDays(5), DateTime.Now.AddDays(6), 50),
                new Flight(4, "195", "IL", "USA", DateTime.Now.AddDays(4), DateTime.Now.AddDays(5), 50),
            };
        }
    }
}
