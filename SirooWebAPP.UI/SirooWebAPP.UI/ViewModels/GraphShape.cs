namespace SirooWebAPP.UI.ViewModels
{
    public class GraphShape
    {
        public string? name { get; set; }
        public int value { get; set; }
        public List<GraphShape> children { get; set; }
    }
}
