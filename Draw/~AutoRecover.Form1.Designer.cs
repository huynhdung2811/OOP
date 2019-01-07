namespace Draw
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
            this.tbtLine = new System.Windows.Forms.ToolStripButton();
            this.tbtCircle = new System.Windows.Forms.ToolStripButton();
            this.tbtRectangle = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtLine,
            this.tbtCircle,
            this.tbtRectangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtLine
            // 
            this.tbtLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtLine.Image = ((System.Drawing.Image)(resources.GetObject("tbtLine.Image")));
            this.tbtLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtLine.Name = "tbtLine";
            this.tbtLine.Size = new System.Drawing.Size(23, 22);
            this.tbtLine.Text = "Line";
            // 
            // tbtCircle
            // 
            this.tbtCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtCircle.Image = ((System.Drawing.Image)(resources.GetObject("tbtCircle.Image")));
            this.tbtCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtCircle.Name = "tbtCircle";
            this.tbtCircle.Size = new System.Drawing.Size(23, 22);
            this.tbtCircle.Text = "Circle";
            // 
            // tbtRectangle
            // 
            this.tbtRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tbtRectangle.Image")));
            this.tbtRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtRectangle.Name = "tbtRectangle";
            this.tbtRectangle.Size = new System.Drawing.Size(23, 22);
            this.tbtRectangle.Text = "Rectangle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 166);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "o;";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtLine;
        private System.Windows.Forms.ToolStripButton tbtCircle;
        private System.Windows.Forms.ToolStripButton tbtRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

