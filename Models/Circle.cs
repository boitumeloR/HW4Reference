using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4Reference.Models
{
    public class Circle: Shape
    {
        private int mX;
        private int mY;
        private int mRadius;

        public int X { get => mX; set => mX = value; }
        public int Y { get => mY; set => mY = value; }
        public int Radius { get => mRadius; set => mRadius = value; }

        public Circle(int _x, int _y, int _radius, string _desc, string _fill, string _strokeCol, double _strokeWidth) : base(_desc, _fill, _strokeCol, _strokeWidth)
        {
            base.Description = _desc;
            base.Fill = _fill;
            base.StrokeColor = _strokeCol;
            base.StrokeWidth = _strokeWidth;
            base.SvgHeight = 100;
            base.SvgWidth = 100;
            this.mY = _y;
            this.mX = _x;
            this.mRadius = _radius;
        }

        public Circle()
        {
            base.Description = "";
            base.Fill = "";
            base.StrokeColor = "";
            base.StrokeWidth = 0;
            this.mY = 0;
            this.mX = 0;
            this.mRadius = 0;
            base.SvgHeight = 100;
            base.SvgWidth = 100;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(this.mRadius, 2);
        }

        public override string getSvg()
        {
            return $"<svg style = 'border: 1pt dashed #333' height='{base.SvgHeight}' width='{base.SvgWidth}'><circle cx = '{this.mX}'  cy = '{this.mY}' r = '{this.mRadius}' stroke = '{base.StrokeColor}' stroke-width ='{base.StrokeWidth}'" +
                $"fill = '{base.Fill}' /></svg>";
        }
    }
}