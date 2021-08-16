using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4Reference.Models
{
    public class Rectangle: Shape
    {
        private int mX;
        private int mY;
        private int mWidth;
        private int mHeight;

        public int X { get => mX; set => mX = value; }
        public int Y { get => mY; set => mY = value; }
        public int Width { get => mWidth; set => mWidth = value; }
        public int Height { get => mHeight; set => mHeight = value; }

        public Rectangle(int _x, int _y, int _width, int _height, string _desc, string _fill, string _strokeCol, double _strokeWidth) : base(_desc, _fill, _strokeCol, _strokeWidth)
        {
            base.Description = _desc;
            base.Fill = _fill;
            base.StrokeColor = _strokeCol;
            base.StrokeWidth = _strokeWidth;
            base.SvgHeight = 100;
            base.SvgWidth = 100;
            this.mX = _x;
            this.mY = _y;
            this.mHeight = _height;
            this.mWidth = _width;
        }

        public Rectangle()
        {
            base.Description = "";
            base.Fill = "";
            base.StrokeColor = "";
            base.StrokeWidth = 0;
            base.SvgHeight = 100;
            base.SvgWidth = 100;
            this.mX = 0;
            this.mY = 0;
            this.mHeight = 0;
            this.mWidth = 0;
        }

        public override double getArea()
        {
            return this.mWidth * this.mHeight;
        }

        public override string getSvg()
        {
            return "<svg style = 'border: 1pt dashed #333' height = '" +
            base.SvgHeight + "' width = '" + base.SvgWidth + "'><rect x='"
            + mX + "' y='" + mY + "' width='" + mWidth + "' height='" +
            mHeight + "' style = 'fill:" + base.Fill + ";stroke:" +
            base.StrokeColor + ";stroke‐width:" + base.StrokeWidth +
            "'/></svg>";
        }
    }
}