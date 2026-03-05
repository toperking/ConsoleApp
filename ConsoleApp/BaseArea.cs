using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public interface IBaseArea
    {
        public void Area();
    }

    public class CircleArea : IBaseArea
    {
        public float radius;
         public CircleArea(float radius)
        {
            this.radius = radius;
        }
        public void Area()
        {
            var area = Math.PI * radius * radius;   
            Console.WriteLine($"圓面積是:{area.ToString("F3")}");
        }
    }

    public class  RectangleArea : IBaseArea
    {
        public float width;
        public float height;
        public RectangleArea(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public void Area()
        {
            var area = width * height;   
            Console.WriteLine($"矩形面積是:{area}");
        }
    }

    public class TriangleArea : IBaseArea
    {
        public float width;
        public float height;
        public TriangleArea(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public void Area()
        {
            var area = width * height / 2;   
            Console.WriteLine($"三角形面積是:{area}");
        }
    }

    public class TrapezoidArea : IBaseArea
    {
        public float top;
        public float button;
        public float height;
        public TrapezoidArea(float top, float button, float height)
        { 
            this.top = top;
            this.button = button;
            this.height = height;
        }
        public void Area()
        {
            var area = (top + button) * height / 2;
            Console.WriteLine($"梯形面積是:{area}");
        }
    }



    public class NormalArea : IBaseArea
    {
        public float top;
        public float button;
        public float height;
        public NormalArea(float top, float button, float height)
        {
            this.top = top;
            this.button = button;
            this.height = height;
        }
        public void Area()
        {
            var area = (top + button) * height / 2;
            Console.WriteLine($"一般面積是:{area}");
        }
    }

    public class AreaFactory
    {
        private IBaseArea areaModel = null!;

        public AreaFactory(IBaseArea areaModel)
        {
            this.areaModel = areaModel;
        }

        public void Area()
        {
            areaModel.Area();
        }   
    }
}
