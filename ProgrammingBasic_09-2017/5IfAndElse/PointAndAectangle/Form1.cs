using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointAndAectangle
{
    public partial class FormPointAndRectangle : Form
    {
        public FormPointAndRectangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Draw(object sender, EventArgs e)
        {
            
                // Get the rectangle and point coordinates from the form
                var x1 = this.numericUpDownX1.Value;
                var y1 = this.numericUpDownY1.Value;
                var x2 = this.numericUpDownX2.Value;
                var y2 = this.numericUpDownY2.Value;
                var x = this.numericUpDownX.Value;
                var y = this.numericUpDownY.Value;
                // Display the location of the point: Inside / Border / Outside
                DisplayPointLocation(x1, y1, x2, y2, x, y);
            }
            private void DisplayPointLocation(
            decimal x1, decimal y1, decimal x2, decimal y2, decimal x, decimal y)
            {
                var left = Math.Min(x1, x2);
                var right = Math.Max(x1, x2);
                var top = Math.Min(y1, y2);
                var bottom = Math.Max(y1, y2);
                if (x > left && x < right && …)
{
                this.labelLocation.Text = "Inside";
                this.labelLocation.BackColor = Color.LightGreen;
            }
else if (… || y < top || y > bottom)
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
    }
    }
}
