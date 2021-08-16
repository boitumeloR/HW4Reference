using HW4Reference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4Reference.ViewModels
{
    public class ShapeViewModel
    {
        public Circle Circle { get; set; }
        public Rectangle Rectangle { get; set; }
        public Triangle Triangle { get; set; }
        public Shape Shape { get; set; }
        public string CurrentShape { get; set; }
    }
}