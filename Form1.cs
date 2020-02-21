using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MouseMovement
{
    public partial class Form1 : Form
    {
        Random RDM = new Random();
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.Start();
        }

        private void tmr_mouse_Tick(object sender, global::System.EventArgs e)
        {
            //lbl_pos.Text = @"x-pos: " + global::System.Windows.Forms.Cursor.Position.X + @"     y-pos: " + global::System.Windows.Forms.Cursor.Position.Y;
            Cursor.Position = new Point(Cursor.Position.X + (RDM.Next() % 3 - 1) * (RDM.Next() % ((int)sw.Elapsed.Seconds*1000 / 2200 + 2)),
                Cursor.Position.Y + (RDM.Next() % 3 - 1) * (RDM.Next() % ((int)sw.Elapsed.Seconds * 1000 / 2200 + 2)));
            lbl_pos.Text = Convert.ToString(sw.Elapsed.Seconds);
            //Cursor.Position = new Point(Cursor.Position.X + RDM.Next(-1, 2), Cursor.Position.Y + RDM.Next(-1, 2));
        }
    }
}

//SetCursorPos(cursor.x + (random() % 3 - 1) * (random() % (runtime / 2200 + 2)), cursor.y + (random() % 3 - 1) * (random() % (runtime / 2200 + 2)));