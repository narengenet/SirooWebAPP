using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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


        public GraphDiagramModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }
        public void OnGet()
        {
            allGraphs = _usersServices.GetAllGraphs().Where(g => g.GrandParent == g.User).ToList<Graphs>();
            
            allGrandParentCount = allGraphs.Count;
            allGraphCounts = _usersServices.GetAllGraphs().Count;

            List<GraphShape> graphShapes = new List<GraphShape>();
            List<GraphShape> _graphShapes = new List<GraphShape>();

            foreach (Graphs item in allGraphs)
            {

                
                _graphShapes.Add(new GraphShape
                {
                    name = _usersServices.GetUser(item.User).Username.ToString(),
                    value = item.ReceivedShared,
                    children= GetChildren(item.User)
                });
            }
            graphShapes.Add(new GraphShape
            {
                name="root",
                value = 0,
                children = _graphShapes
            });
            //allGraphShapes= JsonSerializer.Serialize(graphShapes);
            allGraphShapes= graphShapes;
        }

        List<GraphShape> GetChildren(Guid parentID)
        {
            List<GraphShape> result = new List<GraphShape>();
            List<Graphs> childrens = _usersServices.GetAllGraphs().Where(g => g.Parent == parentID).ToList<Graphs>();
            foreach (Graphs item in childrens)
            {
                result.Add(new GraphShape
                {
                    name = _usersServices.GetUser(item.User).Username,
                    value = item.ReceivedShared,
                    children = GetChildren(item.User)
                });
            }

            return result;
        }
    }
}
