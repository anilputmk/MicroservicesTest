using System;
using System.Collections.Generic;
using ASPNet_Microservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet_Microservice.Controllers
{
    public class TeamsController
    {
        public TeamsController()
        {
        }

        [HttpGet]
        public IEnumerable<Team> GetAllTeams()
        {
            return new Team[] { new Team("One"), new Team("Two") };
        }
    }
}
