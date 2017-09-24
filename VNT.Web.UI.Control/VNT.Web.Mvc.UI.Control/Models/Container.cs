using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace VNT.Web.Mvc.UI.Control.Models
{
    public class Container
    {
        public ICollection<IControl> Controls
        {
            get { return _controls; }
        }

        private readonly ICollection<IControl> _controls;

        public Container()
        {
            _controls = new List<IControl>();
        }

        public void Add(IControl control)
        {
            _controls.Add(control);
        }

        public void Add(params IControl[] controls)
        {
            _controls.AddRange(controls);
        }
    }
}