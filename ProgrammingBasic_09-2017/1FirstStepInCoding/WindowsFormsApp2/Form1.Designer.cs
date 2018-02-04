namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCatchMe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonCatchMe
            // 
            this.buttonCatchMe.CausesValidation = false;
            this.buttonCatchMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCatchMe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCatchMe.Location = new System.Drawing.Point(61, 50);
            this.buttonCatchMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCatchMe.Name = "buttonCatchMe";
            this.buttonCatchMe.Size = new System.Drawing.Size(111, 98);
            this.buttonCatchMe.TabIndex = 0;
            this.buttonCatchMe.Text = "Хвани ме де!";
            this.buttonCatchMe.UseVisualStyleBackColor = true;
            this.buttonCatchMe.LocationChanged += new System.EventHandler(this.button1_LocationChanged);
            this.buttonCatchMe.TextChanged += new System.EventHandler(this.buttonCatchMe_TextChanged);
            this.buttonCatchMe.Click += new System.EventHandler(this.button1_LocationChanged);
            this.buttonCatchMe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openFileDialog1_FileOk);
            this.buttonCatchMe.MouseCaptureChanged += new System.EventHandler(this.button1_LocationChanged);
            this.buttonCatchMe.MouseHover += new System.EventHandler(this.button1_LocationChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "БРАВОООО";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCatchMe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(399, 385);
            this.Controls.Add(this.buttonCatchMe);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.buttonCatchMe_TextChanged);
            this.Click += new System.EventHandler(this.buttonCatchMe_TextChanged);
            this.MouseCaptureChanged += new System.EventHandler(this.buttonCatchMe_TextChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCatchMe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

