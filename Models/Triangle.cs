using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4Reference.Models
{
    public class Triangle: Shape
    {
        private int mX;
        private int mY;
        private int rightX;
        private int rightY;
        private int leftX;
        private int leftY;
        private int topX;
        private int topY;

        public int X { get => mX; set => mX = value; }
        public int Y { get => mY; set => mY = value; }
        public int RightX { get => rightX; set => rightX = value; }
        public int RightY { get => rightY; set => rightY = value; }
        public int LeftX { get => leftX; set => leftX = value; }
        public int LeftY { get => leftY; set => leftY = value; }
        public int TopX { get => topX; set => topX = value; }
        public int TopY { get => topY; set => topY = value; }


        public Triangle( int _x, int _y, int right_x, int right_y, int left_x, int left_y, int top_x, int top_y, string _desc, string _fill, string _strokeCol, double _strokeWidth): base( _desc, _fill, _strokeCol, _strokeWidth)
        {
            base.Description = _desc;
            base.Fill = _fill;
            base.StrokeColor = _strokeCol;
            base.StrokeWidth = _strokeWidth;
            base.SvgHeight = 100;
            base.SvgWidth = 100;

            this.mX = _x;
            this.mY = _y;
            this.rightX = right_x;
            this.rightY = right_y;
            this.leftX = left_x;
            this.leftY = left_y;
            this.topX = top_x;
            this.topY = top_y;
        }

        public Triangle()
        {
            base.Description = "";
            base.Fill = "";
            base.StrokeColor = "";
            base.StrokeWidth = 0;
            base.SvgHeight = 100;
            base.SvgWidth = 100;

            this.mX = 0;
            this.mY = 0;
            this.rightX = 0;
            this.rightY = 0;
            this.leftX = 0;
            this.leftY = 0;
            this.topX = 0;
            this.topY = 0;
        }

        public override double getArea()
        {
            return (base.SvgHeight * base.SvgWidth)*2;
        }

        public override string getSvg()
        {
            return $"<svg style = 'border: 1pt dashed #333' height='{this.mX}' width='{this.mY}'><polygon points = '{this.rightX},{this.rightY} {this.leftX},{this.leftY} {this.topX},{this.topY}' style = 'fill:{base.Fill};" +
                $"stroke:{base.StrokeColor};stroke-width:{base.StrokeWidth}' /></svg>";
        }

    }
}