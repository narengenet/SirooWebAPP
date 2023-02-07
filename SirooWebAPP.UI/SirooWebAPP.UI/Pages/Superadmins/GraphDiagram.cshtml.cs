using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;
using System.Text.Json;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class GraphDiagramModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public List<Graphs> allGraphs = null;
        public List<GraphShape> allGraphShapes = null;
        public int allGraphCounts = 0;
        public int allGrandParentCount = 0;


        public List<SelectListItem> UserChallengesOptions { get; set; }


        [BindProperty]
        public int? ChallengeModeIndex { get; set; }


        public int neededMoney1 = 0;
        public int neededMoney2 = 0;
        public int neededMoney3 = 0;


        public GraphDiagramModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }
        public void OnGet()
        {

            UserChallengesOptions = new List<SelectListItem>();


            neededMoney1 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_1").ConstantValue);
            neededMoney2 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_2").ConstantValue);
            neededMoney3 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_3").ConstantValue);

            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "پکیج " + neededMoney1 / 10 + " تومانی",
                Value = "1"
            });
            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "پکیج " + neededMoney2 / 10 + " تومانی",
                Value = "2"
            });
            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "پکیج " + neededMoney3 / 10 + " تومانی",
                Value = "3"
            });

            int selectedIndex = 0;
            if (Request.Query["challenge"] == "1" || Request.Query["challenge"] == "2" || Request.Query["challenge"] == "3")
            {
                UserChallengesOptions.Where(g => g.Value == Request.Query["challenge"]).FirstOrDefault().Selected = true;
                ChallengeModeIndex = Convert.ToInt32(Request.Query["challenge"]);
                allGraphs = _usersServices.GetAllGraphs().Where(g => g.GrandParent == g.User && g.GraphTypeIndex == ChallengeModeIndex).ToList<Graphs>();
                allGraphCounts = _usersServices.GetAllGraphs().Where(g => g.GraphTypeIndex == ChallengeModeIndex).ToList<Graphs>().Count;
            }
            else
            {
                UserChallengesOptions[selectedIndex].Selected = true;
                ChallengeModeIndex = Convert.ToInt32(UserChallengesOptions[selectedIndex].Value);
                //ChallengeModeIndex = 0;
                allGraphs = _usersServices.GetAllGraphs().Where(g => g.GrandParent == g.User && g.GraphTypeIndex == ChallengeModeIndex).ToList<Graphs>();
                allGraphCounts = _usersServices.GetAllGraphs().Where(g=>g.GraphTypeIndex==ChallengeModeIndex).ToList<Graphs>().Count;
            }




            allGrandParentCount = allGraphs.Count;


            List<GraphShape> graphShapes = new List<GraphShape>();
            List<GraphShape> _graphShapes = new List<GraphShape>();

            foreach (Graphs item in allGraphs)
            {


                _graphShapes.Add(new GraphShape
                {
                    name = _usersServices.GetUser(item.User).Username.ToString() + " - " + item.GraphTypeIndex,
                    value = item.ReceivedShared,
                    children = GetChildren(item.User)
                });
            }
            graphShapes.Add(new GraphShape
            {
                name = "root",
                value = 0,
                children = _graphShapes
            });
            //allGraphShapes= JsonSerializer.Serialize(graphShapes);
            allGraphShapes = graphShapes;
        }

        List<GraphShape> GetChildren(Guid parentID)
        {
            List<GraphShape> result = new List<GraphShape>();

            List<Graphs> childrens = new List<Graphs>();


            childrens = _usersServices.GetAllGraphs().Where(g => g.Parent == parentID && g.GraphTypeIndex == ChallengeModeIndex).ToList<Graphs>();


            foreach (Graphs item in childrens)
            {
                result.Add(new GraphShape
                {
                    name = _usersServices.GetUser(item.User).Username + " - " + item.GraphTypeIndex,
                    value = item.ReceivedShared,
                    children = GetChildren(item.User)
                });
            }

            return result;
        }
    }
}
