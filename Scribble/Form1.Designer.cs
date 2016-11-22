namespace Scribble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.line_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.free_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rec_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.red_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.blue_button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.line_button,
            this.toolStripSeparator1,
            this.free_button,
            this.toolStripSeparator2,
            this.rec_button,
            this.toolStripSeparator3,
            this.red_button,
            this.toolStripSeparator4,
            this.blue_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1090, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // line_button
            // 
            this.line_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line_button.Image = global::Scribble.Properties.Resources.line;
            this.line_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line_button.Name = "line_button";
            this.line_button.Size = new System.Drawing.Size(28, 28);
            this.line_button.Text = "Line";
            this.line_button.Click += new System.EventHandler(this.line_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // free_button
            // 
            this.free_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.free_button.Image = global::Scribble.Properties.Resources.free;
            this.free_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.free_button.Name = "free_button";
            this.free_button.Size = new System.Drawing.Size(28, 28);
            this.free_button.Text = "Free Draw";
            this.free_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.free_button.Click += new System.EventHandler(this.free_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // rec_button
            // 
            this.rec_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rec_button.Image = ((System.Drawing.Image)(resources.GetObject("rec_button.Image")));
            this.rec_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rec_button.Name = "rec_button";
            this.rec_button.Size = new System.Drawing.Size(28, 28);
            this.rec_button.Text = "Rectangle";
            this.rec_button.Click += new System.EventHandler(this.rec_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // red_button
            // 
            this.red_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.red_button.Image = global::Scribble.Properties.Resources.red;
            this.red_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.red_button.Name = "red_button";
            this.red_button.Size = new System.Drawing.Size(28, 28);
            this.red_button.Text = "Red brush";
            this.red_button.Click += new System.EventHandler(this.red_button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // blue_button
            // 
            this.blue_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blue_button.Image = global::Scribble.Properties.Resources.blue;
            this.blue_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blue_button.Name = "blue_button";
            this.blue_button.Size = new System.Drawing.Size(28, 28);
            this.blue_button.Text = "Blue brush";
            this.blue_button.Click += new System.EventHandler(this.blue_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 616);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Scribble";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton line_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton free_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton rec_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton red_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton blue_button;
    }
}

