namespace Trojan_Assignment_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_Panel = new System.Windows.Forms.Panel();
            this.x_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.tool_Box = new System.Windows.Forms.Panel();
            this.color_box = new System.Windows.Forms.PictureBox();
            this.paint_Size = new System.Windows.Forms.NumericUpDown();
            this.eraser_Icon = new System.Windows.Forms.PictureBox();
            this.paint_Icon = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            this.tool_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.top_Panel.Controls.Add(this.x_button);
            this.top_Panel.Controls.Add(this.clear_button);
            this.top_Panel.Controls.Add(this.save_button);
            this.top_Panel.Controls.Add(this.label1);
            this.top_Panel.Controls.Add(this.pictureBox1);
            this.top_Panel.Controls.Add(this.menuStrip1);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Margin = new System.Windows.Forms.Padding(6);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1486, 73);
            this.top_Panel.TabIndex = 0;
            this.top_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.top_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.top_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // x_button
            // 
            this.x_button.Location = new System.Drawing.Point(1324, 11);
            this.x_button.Margin = new System.Windows.Forms.Padding(6);
            this.x_button.Name = "x_button";
            this.x_button.Size = new System.Drawing.Size(139, 49);
            this.x_button.TabIndex = 4;
            this.x_button.Text = "X";
            this.x_button.UseVisualStyleBackColor = true;
            this.x_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(1124, 11);
            this.clear_button.Margin = new System.Windows.Forms.Padding(6);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(139, 49);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(955, 11);
            this.save_button.Margin = new System.Windows.Forms.Padding(6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(139, 49);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(696, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawing App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penToolStripMenuItem,
            this.penToolStripMenuItem1,
            this.brushToolStripMenuItem1,
            this.brushToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1486, 42);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // penToolStripMenuItem1
            // 
            this.penToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.customDashToolStripMenuItem,
            this.compoundToolStripMenuItem});
            this.penToolStripMenuItem1.Name = "penToolStripMenuItem1";
            this.penToolStripMenuItem1.Size = new System.Drawing.Size(73, 36);
            this.penToolStripMenuItem1.Text = "Pen";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(289, 44);
            this.solidToolStripMenuItem.Text = "Solid";
            // 
            // customDashToolStripMenuItem
            // 
            this.customDashToolStripMenuItem.Name = "customDashToolStripMenuItem";
            this.customDashToolStripMenuItem.Size = new System.Drawing.Size(289, 44);
            this.customDashToolStripMenuItem.Text = "Custom Dash";
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(289, 44);
            this.compoundToolStripMenuItem.Text = "Compound";
            // 
            // brushToolStripMenuItem1
            // 
            this.brushToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.hashToolStripMenuItem,
            this.linearGradientToolStripMenuItem});
            this.brushToolStripMenuItem1.Name = "brushToolStripMenuItem1";
            this.brushToolStripMenuItem1.Size = new System.Drawing.Size(94, 36);
            this.brushToolStripMenuItem1.Text = "Brush";
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(309, 44);
            this.solidToolStripMenuItem1.Text = "Solid";
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.hashToolStripMenuItem.Text = "Hash";
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.linearGradientToolStripMenuItem.Text = "Linear Gradient";
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.brushToolStripMenuItem.Text = "Color";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.Controls.Add(this.tool_Box);
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 73);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(6);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(1486, 887);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Panel_Paint);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // tool_Box
            // 
            this.tool_Box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tool_Box.Controls.Add(this.color_box);
            this.tool_Box.Controls.Add(this.paint_Size);
            this.tool_Box.Controls.Add(this.eraser_Icon);
            this.tool_Box.Controls.Add(this.paint_Icon);
            this.tool_Box.Dock = System.Windows.Forms.DockStyle.Left;
            this.tool_Box.Location = new System.Drawing.Point(0, 0);
            this.tool_Box.Margin = new System.Windows.Forms.Padding(6);
            this.tool_Box.Name = "tool_Box";
            this.tool_Box.Size = new System.Drawing.Size(89, 887);
            this.tool_Box.TabIndex = 0;
            // 
            // color_box
            // 
            this.color_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_box.Location = new System.Drawing.Point(6, 307);
            this.color_box.Margin = new System.Windows.Forms.Padding(6);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(78, 107);
            this.color_box.TabIndex = 3;
            this.color_box.TabStop = false;
            this.color_box.Click += new System.EventHandler(this.color_box_Click);
            // 
            // paint_Size
            // 
            this.paint_Size.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.paint_Size.ForeColor = System.Drawing.SystemColors.Info;
            this.paint_Size.Location = new System.Drawing.Point(6, 245);
            this.paint_Size.Margin = new System.Windows.Forms.Padding(6);
            this.paint_Size.Name = "paint_Size";
            this.paint_Size.Size = new System.Drawing.Size(78, 39);
            this.paint_Size.TabIndex = 2;
            this.paint_Size.ValueChanged += new System.EventHandler(this.paint_Icon_size_changed);
            // 
            // eraser_Icon
            // 
            this.eraser_Icon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eraser_Icon.Image = ((System.Drawing.Image)(resources.GetObject("eraser_Icon.Image")));
            this.eraser_Icon.Location = new System.Drawing.Point(6, 126);
            this.eraser_Icon.Margin = new System.Windows.Forms.Padding(6);
            this.eraser_Icon.Name = "eraser_Icon";
            this.eraser_Icon.Size = new System.Drawing.Size(78, 107);
            this.eraser_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eraser_Icon.TabIndex = 1;
            this.eraser_Icon.TabStop = false;
            this.eraser_Icon.Click += new System.EventHandler(this.eraser_Icon_Click);
            // 
            // paint_Icon
            // 
            this.paint_Icon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paint_Icon.Image = ((System.Drawing.Image)(resources.GetObject("paint_Icon.Image")));
            this.paint_Icon.Location = new System.Drawing.Point(6, 6);
            this.paint_Icon.Margin = new System.Windows.Forms.Padding(6);
            this.paint_Icon.Name = "paint_Icon";
            this.paint_Icon.Size = new System.Drawing.Size(78, 107);
            this.paint_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.paint_Icon.TabIndex = 0;
            this.paint_Icon.TabStop = false;
            this.paint_Icon.Click += new System.EventHandler(this.paint_Icon_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(99, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.canvasPanel.ResumeLayout(false);
            this.tool_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel top_Panel;
        private Button x_button;
        private Button clear_button;
        private Button save_button;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel canvasPanel;
        private Panel tool_Box;
        private PictureBox color_box;
        private NumericUpDown paint_Size;
        private PictureBox eraser_Icon;
        private PictureBox paint_Icon;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem penToolStripMenuItem;
        private ToolStripMenuItem penToolStripMenuItem1;
        private ToolStripMenuItem solidToolStripMenuItem;
        private ToolStripMenuItem brushToolStripMenuItem;
        private ToolStripMenuItem brushToolStripMenuItem1;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem customDashToolStripMenuItem;
        private ToolStripMenuItem compoundToolStripMenuItem;
        private ToolStripMenuItem solidToolStripMenuItem1;
        private ToolStripMenuItem hashToolStripMenuItem;
        private ToolStripMenuItem linearGradientToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}