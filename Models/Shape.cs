using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4Reference.Models
{
    public class Shape
    {
        private string mDescription;
        private string mFill;
        private string mStrokeColor;
        private double mStrokeWidth;
        private int mSvgWidth;
        private int mSvgHeight;

        public string Description { get => mDescription; set => mDescription = value; }
        public string Fill { get => mFill; set => mFill = value; }
        public string StrokeColor { get => mStrokeColor; set => mStrokeColor = value; }
        public double StrokeWidth { get => mStrokeWidth; set => mStrokeWidth = value; }
        public int SvgWidth { get => mSvgWidth; set => mSvgWidth = value; }
        public int SvgHeight { get => mSvgHeight; set => mSvgHeight = value; }
        
        
        public Shape(string _desc, string _fill, string _strokeCol, double _strokeWidth)
        {
            this.mDescription = _desc;
            this.mFill = _fill;
            this.mStrokeColor = _strokeCol;
            this.mStrokeWidth = _strokeWidth;
            this.mSvgHeight = 100;
            this.mSvgWidth = 100;
        }

        public Shape()
        {
            this.mDescription = "";
            this.mFill = "";
            this.mStrokeColor = "";
            this.mStrokeWidth = 0;
            this.mSvgHeight = 0;
            this.mSvgWidth = 0;
        }

        public virtual double getArea()
        {
            return this.mSvgWidth * this.mSvgHeight;
        }

        public virtual string getSvg()
        {
            return "";
        }
    }
}