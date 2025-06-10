using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    class FreeHandDrawable : IDrawable
    {

        //private PointF _point = PointF.Zero;
        //public void setTouchPoint(PointF point) => _point = point;
        //public void Draw(ICanvas canvas, RectF dirtyRect)
        //{
        //    if (_point.IsEmpty) return;
        //    canvas.StrokeColor = Colors.Red;
        //    canvas.StrokeSize = 10;

        //    //PointF point = new PointF(0, 0);
        //    canvas.DrawCircle(_point, 5);
        //}

        private List<PointF> _points = [];
        public void AddTouchPoint(PointF point) => _points.Add(point);
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (_points.Count == 0) return;
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 10;
            foreach (var point in _points) { 
            
            canvas.DrawCircle(point, 5);
            }
        }
    }
}
