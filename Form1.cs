using System.Net;
using System;

namespace Graph
{
    public partial class Form1 : Form
    {
        private Boolean isDrawingLine = false;
        private Boolean isDrawingRect = false;
        private Boolean isDrawingFillRect = false;
        private Boolean isDrawingCircle = false;
        private Boolean isDrawingEllip = false;
        private Boolean isDrawingPoly = false;

        private System.Windows.Forms.Timer timer;
        private int lightIndex = 0;

        private int currDuration;
        private Dictionary<int, int> lightDurations = new Dictionary<int, int>
        {
            { 0, 30 },
            { 1, 3 },
            { 2, 20 },
        };

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += lightTimer_Tick;
            currDuration = lightDurations[lightIndex];
            timer.Start();

            System.Windows.Forms.Timer timerPresen = new System.Windows.Forms.Timer();
            timerPresen.Interval = 1000;
            timerPresen.Tick += timerPresent_Tick;
            timerPresen.Start();

        }
        private void drawTTable_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isDrawingLine)
            {

                using (Pen pen = new Pen(Color.DarkCyan, 10))
                {
                    g.DrawLine(pen, 50, 200, 100, 200);
                }
            }

            if (isDrawingRect)
            {
                using (Pen pen = new Pen(Color.DarkCyan, 10))
                {
                    g.DrawRectangle(pen, 151, 110, 75, 75);
                }
            }

            if (isDrawingFillRect)
            {
                using (Pen pen = new Pen(Color.DarkCyan, 10))
                {
                    g.FillRectangle(new SolidBrush(Color.DarkCyan), 151, 200, 75, 75);
                }
            }

            if (isDrawingCircle)
            {
                using (Pen pen = new Pen(Color.DarkCyan, 10))
                {
                    g.DrawEllipse(pen, 260, 150, 50, 50);
                }
            }

            if (isDrawingEllip)
            {
                using (Pen pen = new Pen(Color.DarkCyan, 5))
                {
                    g.DrawEllipse(pen, 352, 150, 80, 50);
                }
            }

            if (isDrawingPoly)
            {
                using (Pen pen = new Pen(Color.DarkCyan, 5))
                {
                    Point[] points = { new Point(450, 250), new Point(500, 150), new Point(550, 250) };
                    g.DrawPolygon(pen, points);
                }
            }

        }

        private void lineGbtn_Click_1(object sender, EventArgs e)
        {
            isDrawingLine = true;
            drawTTable.Invalidate();
        }

        private void rectangleGbtn_Click(object sender, EventArgs e)
        {
            isDrawingRect = true;
            isDrawingFillRect = true;
            drawTTable.Invalidate();
        }

        private void circleGbtn_Click(object sender, EventArgs e)
        {
            isDrawingCircle = true;
            drawTTable.Invalidate();
        }

        private void drawEllipseGbtn_Click(object sender, EventArgs e)
        {
            isDrawingEllip = true;
            drawTTable.Invalidate();
        }

        private void drawPolygonGbtn_Click(object sender, EventArgs e)
        {
            isDrawingPoly = true;
            drawTTable.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            currDuration--;
            if (currDuration < 0)
            {
                lightIndex = (lightIndex + 1) % 3;
                currDuration = lightDurations[lightIndex];
            }
            animationTp.Invalidate();
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{

        //}

        private void animationTp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Black, 50, 50, 100, 300);
            Brush red = lightIndex == 0 ? Brushes.Red : Brushes.Gray;
            Brush yellow = lightIndex == 1 ? Brushes.Yellow : Brushes.Gray;
            Brush green = lightIndex == 2 ? Brushes.Green : Brushes.Gray;
            g.FillEllipse(red, 75, 60, 50, 50);   // Đèn đỏ
            g.FillEllipse(yellow, 75, 140, 50, 50); // Đèn vàng
            g.FillEllipse(green, 75, 220, 50, 50); // Đèn xanh

            using (Font font = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Point))
            {
                g.DrawString(currDuration.ToString(), font, Brushes.White, 80, 290);
            }
        }

        private void timerPresent_Tick(object sender, EventArgs e)
        {
            this.tSLTime.Text = $"Ngay: {DateTime.Now.ToString("dd/MM/yyyy")} - " +
                $"{DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void openToolStrMItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "AVI file|*.avi|MPEG File|*.mpeg|Wav File|*.Wav|" +
             "Midi File|*.midi|Mp4 File|*.mp4|MP3|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWMPlayer.URL = openFileDialog.FileName;
            }
        }

        private void exitToolSMItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
