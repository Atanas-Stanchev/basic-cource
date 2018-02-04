namespace PointAndRectangle
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormPointAndRectangle : Form
    {
        decimal ratio = 1.0m;
        int marginLeft = 50;
        int marginRight = 10;
        int marginTop = 10;
        int marginBottom = 50;
        decimal minX;
        decimal maxX;
        decimal minY;
        decimal maxY;
        decimal x1;
        decimal y1;
        decimal x2;
        decimal y2;
        decimal xx;
        decimal yy;
        decimal gr;

        public FormPointAndRectangle() { InitializeComponent(); }

        private void buttonDraw_Click(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownX2_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void numericUpDownGrid_ValueChanged(object sender, EventArgs e) { RefreshForm(); }

        private void FormPointAndRectangle_Load(object sender, EventArgs e) { RefreshForm(); }

        private void FormPointAndRectangle_Resize(object sender, EventArgs e) { RefreshForm(); }


        private void RefreshForm()
        {
            DisplayPointLocationInLabel(x1, y1, x2, y2, xx, yy);
            DrawDiagram();
        }

        private void DrawDiagram()
        {
            // Get the rectangle and point coordinates from the form
            this.x1 = this.numericUpDownX1.Value;
            this.y1 = this.numericUpDownY1.Value;
            this.x2 = this.numericUpDownX2.Value;
            this.y2 = this.numericUpDownY2.Value;
            this.xx = this.numericUpDownX.Value;
            this.yy = this.numericUpDownY.Value;
            this.gr = this.numericUpDownGrid.Value;

            int pictureBoxWidth = this.pictureBox.Width;
            int pictureBoxHeight = this.pictureBox.Height;

            CalculateScaleFactor(pictureBoxWidth, pictureBoxHeight);

            // Calculate the scaled rectangle coordinates
            var rectLeft = this.ScalePointX(Math.Min(this.x1, this.x2));
            var rectTop = this.ScalePointY(Math.Max(this.y1, this.y2));
            var rectWidth = (int)Math.Round(Math.Abs(this.x2 - this.x1) * this.ratio);
            var rectHeight = (int)Math.Round(Math.Abs(this.y2 - this.y1) * this.ratio);
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            // Calculate the scalled point coordinates
            var pointX = this.ScalePointX(xx);
            var pointY = this.ScalePointY(yy);
            var pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

            // Draw the diagram
            pictureBox.Image = new Bitmap(pictureBoxWidth, pictureBoxHeight);
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                // Draw diagram background (white area)
                g.Clear(Color.White);

                Pen pen;

                // Draw vertical gridlines
                pen = new Pen(Color.LightGray, 0.5f);
                for (int i = (int)this.minX; i <= (int)this.maxX; i += (int)this.gr)
                {
                    var pt1 = new Point(this.ScalePointX(i), this.ScalePointY(this.maxY));
                    var pt2 = new Point(this.ScalePointX(i), this.ScalePointY(this.minY));
                    g.DrawLine(pen, pt1, pt2);
                }

                // Draw horizontal gridlines
                for (int i = (int)this.minY; i <= (int)this.maxY; i += (int)this.gr)
                {
                    var pt1 = new Point(this.ScalePointX(this.minX), this.ScalePointY(i));
                    var pt2 = new Point(this.ScalePointX(this.maxX), this.ScalePointY(i));
                    g.DrawLine(pen, pt1, pt2);
                }

                // Draw the rectangle (scalled to the picture box size)
                pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect);

                // Draw the point (scalled to the picture box size)
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }
        }

        private void CalculateScaleFactor(int pictureBoxWidth, int pictureBoxHeight)
        {
            this.minX = Min(x1, x2, xx); this.minX = Math.Floor(this.minX / this.gr) * this.gr;
            this.minY = Min(y1, y2, yy); this.minY = Math.Floor(this.minY / this.gr) * this.gr;
            this.maxX = Max(x1, x2, xx); this.maxX = Math.Ceiling(this.maxX / this.gr) * this.gr;
            this.maxY = Max(y1, y2, yy); this.maxY = Math.Ceiling(this.maxY / this.gr) * this.gr;
            var diagramWidth = this.maxX - this.minX;
            var diagramHeight = this.maxY - this.minY;

            if (diagramWidth != 0 && diagramHeight != 0)
            {
                var ratioX = (pictureBoxWidth - this.marginLeft - this.marginRight - 1) / diagramWidth;
                var ratioY = (pictureBoxHeight - this.marginTop - this.marginBottom - 1) / diagramHeight;
                this.ratio = Math.Min(ratioX, ratioY);
            }
        }

        private void DisplayPointLocationInLabel(
            decimal x1, decimal y1, decimal x2, decimal y2, decimal x, decimal y)
        {
            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var top = Math.Min(y1, y2);
            var bottom = Math.Max(y1, y2);
            if (x > left && x < right && y > top && y < bottom)
            {
                this.labelLocation.Text = "Inside";
                this.labelLocation.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < top || y > bottom)
            {
                this.labelLocation.Text = "Outside";
                this.labelLocation.BackColor = Color.LightSalmon;
            }
            else
            {
                this.labelLocation.Text = "Border";
                this.labelLocation.BackColor = Color.Gold;
            }
        }

        private decimal Min(decimal val1, decimal val2, decimal val3) =>
            Math.Min(val1, Math.Min(val2, val3));

        private decimal Max(decimal val1, decimal val2, decimal val3) =>
            Math.Max(val1, Math.Max(val2, val3));

        private int ScalePointX(decimal x) =>
            (int)Math.Round(marginLeft + (x - this.minX) * ratio);

        private int ScalePointY(decimal y) =>
            (int)Math.Round(marginTop + (this.maxY - y) * ratio);

    }
}
