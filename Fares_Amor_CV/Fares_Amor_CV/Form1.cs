using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Cv_Fares;
namespace Fares_Amor_CV
{
    public partial class Form1 : Form
    {

        // private SerialPort serialPort1; // Déclaration de la variable serialPort1
        // int stm;


        [DllImport("Gdi32,d11", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (

        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWithEllipse,
        int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.Base1.Controls.Clear();
            //serialPort1.PortName = "COM3";
            // serialPort1.BaudRate = 9600;
            //serialPort1.Open();

            profil profil_1 = new profil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            profil_1.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(profil_1);
            profil_1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.BackColor = Color.FromArgb(46, 51, 73);


            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button7.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            profil profil_1 = new profil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            profil_1.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(profil_1);
            profil_1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button4.BackColor = Color.FromArgb(46, 51, 73);


            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);

            button5.BackColor = Color.FromArgb(24, 30, 54);
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button7.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            competences x = new competences() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            x.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(x);
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.BackColor = Color.FromArgb(46, 51, 73);
            button1.BackColor = Color.FromArgb(24, 30, 54);

            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button7.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            education education_1 = new education() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            education_1.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(education_1);
            education_1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button3.BackColor = Color.FromArgb(46, 51, 73);


            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);

            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button7.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            langue langue_1 = new langue() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            langue_1.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(langue_1);
            langue_1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button5.BackColor = Color.FromArgb(46, 51, 73);


            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);

            button6.BackColor = Color.FromArgb(24, 30, 54);
            button7.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            projets x = new projets() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            x.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(x);
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            button6.BackColor = Color.FromArgb(46, 51, 73);


            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);

            button7.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            associative x = new associative() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            x.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(x);
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            button7.BackColor = Color.FromArgb(46, 51, 73);


            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button6.BackColor = Color.FromArgb(24, 30, 54);

            this.Base1.Controls.Clear();
            contact x = new contact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            x.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(x);
            x.Show();
        }
    }
}
