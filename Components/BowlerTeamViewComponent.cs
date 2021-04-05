using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Components
{
    public class BowlerTeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        //pulling in data
        public BowlerTeamViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke ()
        {
            //ViewBag.SelectedTeam == RouteData?.Values["team"];
            //setting up what will be returned
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
