using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace Prototyp.Nodes
{
    public class Activity : NodeModel
    {
        public Activity(Blazor.Diagrams.Core.Geometry.Point position = null) : base(position)
        {

        }

        public string Description { get; set; }
    }
}
