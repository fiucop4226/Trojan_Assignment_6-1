namespace Trojan_Assignment_6
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();

        public Graphics g;

        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);

        Bitmap surface;
        public Form1()
        {
            InitializeComponent();

            g = canvasPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(canvasPanel.Width, canvasPanel.Height);

            graph = Graphics.FromImage(surface);

            canvasPanel.BackgroundImage = surface;
            canvasPanel.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)paint_Size.Value;



        }

        private void main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(pen, old, current); 
                graph.DrawLine(pen, old, current);

                old = current;
            }
        }
        private Point mouseOffsetPos;
        private Boolean isMouseDown = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mousePos.X, mousePos.Y);
                this.Location = mousePos;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eraser_Icon_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void paint_Icon_Click(object sender, EventArgs e)
        {
            pen.Color = color_box.BackColor;
        }

        private void color_box_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) ;
            {
                pen.Color= cd.Color;
                color_box.BackColor = cd.Color;
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            canvasPanel.Invalidate();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Png Files (*png)| *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void paint_Icon_size_changed(object sender, EventArgs e)
        {
            pen.Width = (float)paint_Size.Value;
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}