using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrictor.UI
{
    public partial class Restrictor : Form
    {
        private static Restrictor _instance;
        public static Restrictor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Restrictor();
                return _instance;
            }
        }
        public Restrictor()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            guna2Button1.FillColor = Color.White;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button3.FillColor = Color.Transparent;
            guna2Button4.FillColor = Color.Transparent;
            guna2PictureBox1.Location = new Point(103, 91);
            guna2Button1.TextAlign = HorizontalAlignment.Left;
            guna2Button2.TextAlign = HorizontalAlignment.Center;
            guna2Button3.TextAlign = HorizontalAlignment.Center;
            guna2Button4.TextAlign = HorizontalAlignment.Center;
            if (!guna2Panel3.Controls.Contains(WebBlock.Instance))
            {
                guna2Panel3.Controls.Add(WebBlock.Instance);
                WebBlock.Instance.Dock = DockStyle.Fill;
                WebBlock.Instance.BringToFront();
            }
            else
            {
                WebBlock.Instance.BringToFront();
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Restrictor_Load(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            guna2Button2.FillColor = Color.White;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button3.FillColor = Color.Transparent;
            guna2Button4.FillColor = Color.Transparent;
            guna2PictureBox1.Location = new Point(103, 189);
            guna2Button1.TextAlign = HorizontalAlignment.Center;
            guna2Button2.TextAlign = HorizontalAlignment.Left;
            guna2Button3.TextAlign = HorizontalAlignment.Center;
            guna2Button4.TextAlign = HorizontalAlignment.Center;
            if (!guna2Panel3.Controls.Contains(AppBlock.Instance))
            {
                guna2Panel3.Controls.Add(AppBlock.Instance);
                AppBlock.Instance.Dock = DockStyle.Fill;
                AppBlock.Instance.BringToFront();
            }
            else
            {
                AppBlock.Instance.BringToFront();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            guna2PictureBox1.Visible = true;
            guna2Button3.FillColor = Color.White;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button4.FillColor = Color.Transparent;
            guna2PictureBox1.Location = new Point(103, 287);
            guna2Button1.TextAlign = HorizontalAlignment.Center;
            guna2Button2.TextAlign = HorizontalAlignment.Center;
            guna2Button3.TextAlign = HorizontalAlignment.Left;
            guna2Button4.TextAlign = HorizontalAlignment.Center;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            guna2Button4.FillColor = Color.White;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button3.FillColor = Color.Transparent;
            guna2PictureBox1.Location = new Point(103, 385);
            guna2Button1.TextAlign = HorizontalAlignment.Center;
            guna2Button2.TextAlign = HorizontalAlignment.Center;
            guna2Button3.TextAlign = HorizontalAlignment.Center;
            guna2Button4.TextAlign = HorizontalAlignment.Left;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
