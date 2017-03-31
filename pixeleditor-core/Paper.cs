using System;
using System.ComponentModel;
using System.Drawing;


namespace pixeleditor_core
{
    public class Paper
    {
       public int id;
       public Size size;
       public Bitmap drawArea;
       private Color background;

       public Paper(int height, int width, Bitmap drawArea)
       {
            size.Height = height;
            size.Width = width;
            this.drawArea = drawArea;
            background = Color.White;
       }

       public Paper()
       {
            id = -1;
       }
    }
}