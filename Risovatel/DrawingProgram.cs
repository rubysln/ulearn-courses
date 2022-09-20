using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Painter
    {
        static float x, y;
        static Graphics graph;

        public static void Initializer(Graphics newGraph)
        {
            graph = newGraph;
            graph.SmoothingMode = SmoothingMode.None;
            graph.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {x = x0; y = y0;}

        public static void MakeIt(Pen pen, double length, double angle)
        {
        //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
        var x1 = (float)(x + length * Math.Cos(angle));
        var y1 = (float)(y + length * Math.Sin(angle));
        graph.DrawLine(pen, x, y, x1, y1);
        x = x1;
        y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle)); 
           y = (float)(y + length * Math.Sin(angle));
           }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double angleOfRotation, Graphics graph)
        {
            // ugolPovorota пока не используется, но будет использоваться в будущем
            Painter.Initializer(graph);

            var min = Math.Min(width, height);

            var diagonalLength = Math.Sqrt(2) * (min * 0.375f + min * 0.04f) / 2;
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Painter.SetPosition(x0, y0);

            //Рисуем 1-ую сторону
            Painter.MakeIt(Pens.Yellow, min * 0.375f, 0);
            Painter.MakeIt(Pens.Yellow, min * 0.04f * Math.Sqrt(2), Math.PI / 4);
            Painter.MakeIt(Pens.Yellow, min * 0.375f, Math.PI);
            Painter.MakeIt(Pens.Yellow, min * 0.375f - min * 0.04f, Math.PI / 2);

            Painter.Change(min * 0.04f, -Math.PI);
            Painter.Change(min * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);

            //Рисуем 2-ую сторону
            Painter.MakeIt(Pens.Yellow, min * 0.375f, -Math.PI / 2);
            Painter.MakeIt(Pens.Yellow, min * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Painter.MakeIt(Pens.Yellow, min * 0.375f, -Math.PI / 2 + Math.PI);
            Painter.MakeIt(Pens.Yellow, min * 0.375f - min * 0.04f, -Math.PI / 2 + Math.PI / 2);

            Painter.Change(min * 0.04f, -Math.PI / 2 - Math.PI);
            Painter.Change(min * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);

            //Рисуем 3-ю сторону
            Painter.MakeIt(Pens.Yellow, min * 0.375f, Math.PI);
            Painter.MakeIt(Pens.Yellow, min * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Painter.MakeIt(Pens.Yellow, min * 0.375f, Math.PI + Math.PI);
            Painter.MakeIt(Pens.Yellow, min * 0.375f - min * 0.04f, Math.PI + Math.PI / 2);

            Painter.Change(min * 0.04f, Math.PI - Math.PI);
            Painter.Change(min * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);

            //Рисуем 4-ую сторону
            Painter.MakeIt(Pens.Yellow, min * 0.375f, Math.PI / 2);
            Painter.MakeIt(Pens.Yellow, min * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Painter.MakeIt(Pens.Yellow, min * 0.375f, Math.PI / 2 + Math.PI);
            Painter.MakeIt(Pens.Yellow, min * 0.375f - min * 0.04f, Math.PI / 2 + Math.PI / 2);

            Painter.Change(min * 0.04f, Math.PI / 2 - Math.PI);
            Painter.Change(min * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}