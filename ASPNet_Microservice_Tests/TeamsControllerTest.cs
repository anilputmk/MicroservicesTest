using System;
using Xunit;
using ASPNet_Microservice.Models;
using System.Collections.Generic;
using ASPNet_Microservice.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet_Microservice_Tests
{
    public class TeamsControllerTest
    {
        TeamsController controller = new TeamsController();

        [Fact]
        public void QueryTeamListReturnsCorrectTeams()
        {
            List<Team> teams = new List<Team>(controller.GetAllTeams());
            Assert.Equal(2, teams.Count);
        }

        [Fact]
        public async void CreateTeamAddsTeamToList()
        {
            var teams = (IEnumerable<Team>)(await controller.GetAllTeams() as ObjectResult).Value;

            List<Team> original = new List<Team>(teams);
        }
    }
}
