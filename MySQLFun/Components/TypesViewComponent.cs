using Microsoft.AspNetCore.Mvc;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MySQLFun.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private ITeamRepository repo { get; set; }
        public TypesViewComponent(ITeamRepository temp)
        {
            repo = temp;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SelectedType = RouteData?.Values["teamName"];
            var types = repo.Teams
                .Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x);
            return View(types);
        }

    }
}
