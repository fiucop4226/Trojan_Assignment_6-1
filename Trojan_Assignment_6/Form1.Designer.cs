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
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.tool_Box = new System.Windows.Forms.Panel();
            this.color_box = new System.Windows.Forms.PictureBox();
            this.paint_Size = new System.Windows.Forms.NumericUpDown();
            this.eraser_Icon = new System.Windows.Forms.PictureBox();
            this.paint_Icon = new System.Windows.Forms.PictureBox();
            this.top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(800, 34);
            this.top_Panel.TabIndex = 0;
            this.top_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.top_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.top_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // x_button
            // 
            this.x_button.Location = new System.Drawing.Point(713, 5);
            this.x_button.Name = "x_button";
            this.x_button.Size = new System.Drawing.Size(75, 23);
            this.x_button.TabIndex = 4;
            this.x_button.Text = "X";
            this.x_button.UseVisualStyleBackColor = true;
            this.x_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(605, 5);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(514, 5);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawing App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.Controls.Add(this.tool_Box);
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 34);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(800, 416);
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
            this.tool_Box.Name = "tool_Box";
            this.tool_Box.Size = new System.Drawing.Size(48, 416);
            this.tool_Box.TabIndex = 0;
            // 
            // color_box
            // 
            this.color_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_box.Location = new System.Drawing.Point(3, 144);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(42, 50);
            this.color_box.TabIndex = 3;
            this.color_box.TabStop = false;
            this.color_box.Click += new System.EventHandler(this.color_box_Click);
            // 
            // paint_Size
            // 
            this.paint_Size.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.paint_Size.ForeColor = System.Drawing.SystemColors.Info;
            this.paint_Size.Location = new System.Drawing.Point(3, 115);
            this.paint_Size.Name = "paint_Size";
            this.paint_Size.Size = new System.Drawing.Size(42, 23);
            this.paint_Size.TabIndex = 2;
            this.paint_Size.ValueChanged += new System.EventHandler(this.paint_Icon_size_changed);
            // 
            // eraser_Icon
            // 
            this.eraser_Icon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eraser_Icon.Image = ((System.Drawing.Image)(resources.GetObject("eraser_Icon.Image")));
            this.eraser_Icon.Location = new System.Drawing.Point(3, 59);
            this.eraser_Icon.Name = "eraser_Icon";
            this.eraser_Icon.Size = new System.Drawing.Size(42, 50);
            this.eraser_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eraser_Icon.TabIndex = 1;
            this.eraser_Icon.TabStop = false;
            this.eraser_Icon.Click += new System.EventHandler(this.eraser_Icon_Click);
            // 
            // paint_Icon
            // 
            this.paint_Icon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paint_Icon.Image = ((System.Drawing.Image)(resources.GetObject("paint_Icon.Image")));
            this.paint_Icon.Location = new System.Drawing.Point(3, 3);
            this.paint_Icon.Name = "paint_Icon";
            this.paint_Icon.Size = new System.Drawing.Size(42, 50);
            this.paint_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.paint_Icon.TabIndex = 0;
            this.paint_Icon.TabStop = false;
            this.paint_Icon.Click += new System.EventHandler(this.paint_Icon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}