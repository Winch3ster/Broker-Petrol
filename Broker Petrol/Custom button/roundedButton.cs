using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Broker_Petrol.Custom_button
{
    /// <summary>
    /// 
    /// Make a custom button with rounded corner using Drawing class
    /// 
    /// </summary>
    /// 

    class roundedButton : Button //Inherit button functionalities from the button class
    {
        //Buttons attributes
        private int borderSize = 0;
        private int borderRadius = 20;

        private Color buttonColor = Color.Blue;


        public roundedButton()
        {
            //Set the buttons attributes
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = buttonColor;
            this.ForeColor = Color.White;

        }

        //Methods 


        //Create the button shape
        public GraphicsPath GetFigurePath(Rectangle rect, int buttonRadius)
        {

            //Take the rectangle passed as arguments and add arc to it
            GraphicsPath outline = new GraphicsPath();
            float curveSize = buttonRadius * 2F;

            outline.StartFigure();//Start darwing

            // top left arc
            outline.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);

            //top right arc
            outline.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);

            //bottom right arc 
            outline.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);

            //bottom left arc
            outline.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            outline.CloseFigure();

            return outline;

        }

        //Override paint events to add new functionalities to the button (rounded features)
        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            base.OnPaint(paintEvent);
            paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Outer surface of the button
            Rectangle innerSurfaceButton = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle borderSurfaceButton = new Rectangle(1, 1, this.Width - 1, this.Height - 1);

            //instantiate rounded corner button
            if (borderRadius > 2)
            {
                GraphicsPath buttonSurfacePath = GetFigurePath(innerSurfaceButton, borderRadius);
                GraphicsPath buttonBorderPath = GetFigurePath(borderSurfaceButton, borderRadius - 1);
                Pen penSurface = new Pen(this.Parent.BackColor, 2);
                Pen penBorder = new Pen(buttonColor, borderSize); //Draw the button's border

                penBorder.Alignment = PenAlignment.Inset;

                //render button surface
                this.Region = new Region(buttonSurfacePath); //Create a region(panel) to store the button
                paintEvent.Graphics.DrawPath(penSurface, buttonSurfacePath);

                //if border size is more than or equal to 1, then render the border
                if (borderSize >= 1)
                {
                    //Draw button border
                    paintEvent.Graphics.DrawPath(penBorder, buttonBorderPath);
                }

            } // If the border radius of the button is set to less than 2, draw a square button instead
            else
            {
                //Instantiate a rectangle button
                this.Region = new Region(innerSurfaceButton);

                if (borderSize >= 1)
                {
                    Pen penBorder = new Pen(buttonColor, borderSize);

                    paintEvent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
}
