using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wysw7seg
{
    public partial class _7segment : UserControl
    {
        private Color ColA { get; set; }
        private Color ColB { get; set; }
        private Color ColC { get; set; }
        private Color ColD { get; set; }
        private Color ColE { get; set; }
        private Color ColF { get; set; }
        private Color ColG { get; set; }
        private Color ColDot { get; set; }
        public Color ColOff { get; set; }
        public Color ColOn { get; set; }
        public Color BgColor { get; set; }

        public string Nr { get; set; }
        public int NumberOfDisplays { get; set; }
        private char Number { get; set; }
        private bool Error { get; set; }
        public _7segment()
        {
            InitializeComponent();
            NumberOfDisplays = 1;
            Nr = "0";
            ColOn = Color.Red;
            ColOff = Color.DarkGray;
            this.BorderStyle = BorderStyle.FixedSingle;
            BgColor = Color.LightGray;
            this.BackColor = BgColor;

        }

        

        private void _7segment_Paint(object sender, PaintEventArgs e)
        {
            this.Size = new Size(NumberOfDisplays * 89 + 14, 150);
            Error = false;
            
            Graphics g = e.Graphics;

            ErrorCheck();

            if (Error)
                OnErrorDo(g);
            else
                DrawNumber(g);


            if (Nr.Contains(","))
            {
                DoIfContainsDot(g);
            }
        }

        void DrawDot(Color col, Graphics g, int x, int y)
        {
            Brush brush = new SolidBrush(col);
            g.FillRectangle(brush, x, y, 10, 10);
        }
        void DrawSegVer(Color Col, Graphics g, int x, int y)
        {
            Brush brush = new SolidBrush(Col);
            Point point1 = new Point(x - 5, y + 5);
            Point point2 = new Point(x, y);
            Point point3 = new Point(x + 5, y + 5);
            Point point4 = new Point(x - 5, y + 55);
            Point point5 = new Point(x, y + 60);
            Point point6 = new Point(x + 5, y + 55);
            Point[] points = { point1, point2, point3, point6, point5, point4 };
            g.FillPolygon(brush, points);
        }

        void DrawSegHor(Color Col, Graphics g, int x, int y)
        {
            Brush brush = new SolidBrush(Col);
            Point point1 = new Point(x + 5, y - 5);
            Point point2 = new Point(x, y);
            Point point3 = new Point(x + 5, y + 5);
            Point point4 = new Point(x + 55, y - 5);
            Point point5 = new Point(x + 60, y);
            Point point6 = new Point(x + 55, y + 5);
            Point[] points = { point1, point2, point3, point6, point5, point4 };
            g.FillPolygon(brush, points);
        }

        void SetSegmentsColors(char nr)
        {
            if (nr.Equals('0'))
            {
                ColA = ColOn;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOn;
                ColE = ColOn;
                ColF = ColOn;
                ColG = ColOff;
            }

            else if (nr.Equals('1'))
            {
                ColA = ColOff;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOff;
                ColE = ColOff;
                ColF = ColOff;
                ColG = ColOff;
            }

            else if (nr.Equals('2'))
            {
                ColA = ColOn;
                ColB = ColOn;
                ColC = ColOff;
                ColD = ColOn;
                ColE = ColOn;
                ColF = ColOff;
                ColG = ColOn;
            }

            else if (nr.Equals('3'))
            {
                ColA = ColOn;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOn;
                ColE = ColOff;
                ColF = ColOff;
                ColG = ColOn;
            }

            else if (nr.Equals('4'))
            {
                ColA = ColOff;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOff;
                ColE = ColOff;
                ColF = ColOn;
                ColG = ColOn;
            }

            else if (nr.Equals('5'))
            {
                ColA = ColOn;
                ColB = ColOff;
                ColC = ColOn;
                ColD = ColOn;
                ColE = ColOff;
                ColF = ColOn;
                ColG = ColOn;
            }

            else if (nr.Equals('6'))
            {
                ColA = ColOn;
                ColB = ColOff;
                ColC = ColOn;
                ColD = ColOn;
                ColE = ColOn;
                ColF = ColOn;
                ColG = ColOn;
            }

            else if (nr.Equals('7'))
            {
                ColA = ColOn;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOff;
                ColE = ColOff;
                ColF = ColOff;
                ColG = ColOff;
            }

            else if (nr.Equals('8'))
            {
                ColA = ColOn;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOn;
                ColE = ColOn;
                ColF = ColOn;
                ColG = ColOn;
            }

            else if (nr.Equals('9'))
            {
                ColA = ColOn;
                ColB = ColOn;
                ColC = ColOn;
                ColD = ColOn;
                ColE = ColOff;
                ColF = ColOn;
                ColG = ColOn;
            }

            else if (nr.Equals('-'))
            {
                ColA = ColOff;
                ColB = ColOff;
                ColC = ColOff;
                ColD = ColOff;
                ColE = ColOff;
                ColF = ColOff;
                ColG = ColOn;
            }
        }
        void OnErrorDo(Graphics g)
        {
            for (int i = 0; i < NumberOfDisplays; i++)
            {
                if (NumberOfDisplays - i > 5)
                {
                    DrawSegHor(ColOff, g, 17 + i * 89, 14);
                    DrawSegVer(ColOff, g, 79 + i * 89, 75);
                    DrawSegVer(ColOff, g, 79 + i * 89, 15);
                    DrawSegHor(ColOff, g, 17 + i * 89, 135);
                    DrawSegVer(ColOff, g, 15 + i * 89, 75);
                    DrawSegVer(ColOff, g, 15 + i * 89, 15);
                    DrawSegHor(ColOff, g, 17 + i * 89, 75);
                    DrawDot(ColOff, g, 86 + i * 89, 130);
                }

                else if (NumberOfDisplays - i == 5)
                {
                    DrawSegHor(ColOn, g, 17 + i * 89, 14);
                    DrawSegVer(ColOff, g, 79 + i * 89, 75);
                    DrawSegVer(ColOff, g, 79 + i * 89, 15);
                    DrawSegHor(ColOn, g, 17 + i * 89, 135);
                    DrawSegVer(ColOn, g, 15 + i * 89, 75);
                    DrawSegVer(ColOn, g, 15 + i * 89, 15);
                    DrawSegHor(ColOn, g, 17 + i * 89, 75);
                    DrawDot(ColOff, g, 86 + i * 89, 130);
                }
                else if (NumberOfDisplays - i == 2)
                {
                    DrawSegHor(ColOff, g, 17 + i * 89, 14);
                    DrawSegVer(ColOn, g, 79 + i * 89, 75);
                    DrawSegVer(ColOff, g, 79 + i * 89, 15);
                    DrawSegHor(ColOn, g, 17 + i * 89, 135);
                    DrawSegVer(ColOn, g, 15 + i * 89, 75);
                    DrawSegVer(ColOff, g, 15 + i * 89, 15);
                    DrawSegHor(ColOn, g, 17 + i * 89, 75);
                    DrawDot(ColOff, g, 86 + i * 89, 130);
                }
                else
                {
                    DrawSegHor(ColOff, g, 17 + i * 89, 14);
                    DrawSegVer(ColOff, g, 79 + i * 89, 75);
                    DrawSegVer(ColOff, g, 79 + i * 89, 15);
                    DrawSegHor(ColOff, g, 17 + i * 89, 135);
                    DrawSegVer(ColOn, g, 15 + i * 89, 75);
                    DrawSegVer(ColOff, g, 15 + i * 89, 15);
                    DrawSegHor(ColOn, g, 17 + i * 89, 75);
                    DrawDot(ColOff, g, 86 + i * 89, 130);
                }
            }
        }
        void DoIfContainsDot(Graphics g)
        {
            if (NumberOfDisplays <= Nr.Length - 1)
            {
                SetSegmentsColors(Nr[0]);

                DrawSegHor(ColA, g, 17, 14);
                DrawSegVer(ColC, g, 79, 75);
                DrawSegVer(ColB, g, 79, 15);
                DrawSegHor(ColD, g, 17, 135);
                DrawSegVer(ColE, g, 15, 75);
                DrawSegVer(ColF, g, 15, 15);
                DrawSegHor(ColG, g, 17, 75);

                if (Nr[1].Equals(','))
                {
                    DrawDot(ColOn, g, 86, 130);
                }

                else
                {
                    DrawDot(ColOff, g, 86, 130);
                }
            }
            else
            {
                DrawSegHor(ColOff, g, 17, 14);
                DrawSegVer(ColOff, g, 79, 75);
                DrawSegVer(ColOff, g, 79, 15);
                DrawSegHor(ColOff, g, 17, 135);
                DrawSegVer(ColOff, g, 15, 75);
                DrawSegVer(ColOff, g, 15, 15);
                DrawSegHor(ColOff, g, 17, 75);
                DrawDot(ColOff, g, 86, 130);
            }
        }
        void DrawNumber(Graphics g)
        {
            int x = 0;
            int add = 0;

            if (Nr.Contains(","))
            {
                add = 89;
            }

            for (int i = 0; i < NumberOfDisplays; i++)
            {
                int dif = NumberOfDisplays - Nr.Length;

                if (i >= dif)
                {
                    Number = Nr[i - dif];

                    if (Number.Equals(','))
                    {
                        ColDot = ColOn;
                        x = 1;
                    }
                    else
                        ColDot = ColOff;

                    SetSegmentsColors(Number);

                    DrawSegHor(ColA, g, 17 + (i - x) * 89 + add, 14);
                    DrawSegVer(ColC, g, 79 + (i - x) * 89 + add, 75);
                    DrawSegVer(ColB, g, 79 + (i - x) * 89 + add, 15);
                    DrawSegHor(ColD, g, 17 + (i - x) * 89 + add, 135);
                    DrawSegVer(ColE, g, 15 + (i - x) * 89 + add, 75);
                    DrawSegVer(ColF, g, 15 + (i - x) * 89 + add, 15);
                    DrawSegHor(ColG, g, 17 + (i - x) * 89 + add, 75);
                    DrawDot(ColDot, g, 86 + (i - x) * 89 + add, 130);
                }
                else
                {
                    DrawSegHor(ColOff, g, 17 + i * 89 + add, 14);
                    DrawSegVer(ColOff, g, 79 + i * 89 + add, 75);
                    DrawSegVer(ColOff, g, 79 + i * 89 + add, 15);
                    DrawSegHor(ColOff, g, 17 + i * 89 + add, 135);
                    DrawSegVer(ColOff, g, 15 + i * 89 + add, 75);
                    DrawSegVer(ColOff, g, 15 + i * 89 + add, 15);
                    DrawSegHor(ColOff, g, 17 + i * 89 + add, 75);
                    DrawDot(ColOff, g, 86 + i * 89 + add, 130);
                }

            }

        }
        void ErrorCheck()
        {
            for (int i = 0; i < Nr.Length; i++)
            {
                if (!(Nr[i].Equals('0') ||
                    Nr[i].Equals('1') ||
                    Nr[i].Equals('2') ||
                    Nr[i].Equals('3') ||
                    Nr[i].Equals('4') ||
                    Nr[i].Equals('5') ||
                    Nr[i].Equals('6') ||
                    Nr[i].Equals('7') ||
                    Nr[i].Equals('8') ||
                    Nr[i].Equals('9') ||
                    Nr[i].Equals('-') ||
                    Nr[i].Equals(',')))
                {
                    Error = true;
                }
            }
        }

        private void _7segment_Load(object sender, EventArgs e)
        {

        }
    }
}
