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
            this.picker_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.undo_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.redo_button = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.stamp_brush = new System.Windows.Forms.ToolStripButton();
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
            this.stamp_brush,
            this.toolStripSeparator5,
            this.picker_button,
            this.toolStripSeparator4,
            this.undo_button,
            this.toolStripSeparator6,
            this.redo_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1090, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // line_button
            // 
            this.line_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line_button.Image = ((System.Drawing.Image)(resources.GetObject("line_button.Image")));
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
            this.rec_button.Image = global::Scribble.Properties.Resources.rect;
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
            // picker_button
            // 
            this.picker_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.picker_button.Image = global::Scribble.Properties.Resources.picker;
            this.picker_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.picker_button.Name = "picker_button";
            this.picker_button.Size = new System.Drawing.Size(28, 28);
            this.picker_button.Text = "Color picker";
            this.picker_button.ToolTipText = "Color picker";
            this.picker_button.Click += new System.EventHandler(this.picker_button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // undo_button
            // 
            this.undo_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo_button.Image = global::Scribble.Properties.Resources.undo;
            this.undo_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo_button.Name = "undo_button";
            this.undo_button.Size = new System.Drawing.Size(28, 28);
            this.undo_button.Text = "Undo";
            this.undo_button.Click += new System.EventHandler(this.undo_button_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // redo_button
            // 
            this.redo_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo_button.Image = global::Scribble.Properties.Resources.redo;
            this.redo_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo_button.Name = "redo_button";
            this.redo_button.Size = new System.Drawing.Size(28, 28);
            this.redo_button.Text = "Redo";
            this.redo_button.Click += new System.EventHandler(this.redo_button_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // stamp_brush
            // 
            this.stamp_brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stamp_brush.Image = global::Scribble.Properties.Resources.star;
            this.stamp_brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stamp_brush.Name = "stamp_brush";
            this.stamp_brush.Size = new System.Drawing.Size(28, 28);
            this.stamp_brush.Text = "Star stamp";
            this.stamp_brush.Click += new System.EventHandler(this.stamp_brush_Click);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
        private System.Windows.Forms.ToolStripButton picker_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton undo_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton redo_button;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton stamp_brush;
    }
}

