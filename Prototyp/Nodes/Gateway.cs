using Blazor.Diagrams.Core.Models;

namespace Prototyp.Nodes
{
    public class Gateway : NodeModel
    {
        public Gateway(Blazor.Diagrams.Core.Geometry.Point? point = null) : base(point)
        {
            this.AddPort(PortAlignment.BottomLeft);
            this.AddPort(PortAlignment.BottomRight);
            this.AddPort(PortAlignment.TopLeft);
            this.AddPort(PortAlignment.TopRight);
        }

        public string Description { get; set; }
    }
}
