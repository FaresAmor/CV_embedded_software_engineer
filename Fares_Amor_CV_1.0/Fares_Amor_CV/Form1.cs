using Cv_Fares;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Fares_Amor_CV
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1;
        private int receivedData;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        private void ButtonAction(int buttonNumber)
        {
            // Reset all buttons' colors
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button7.BackColor = Color.FromArgb(24, 30, 54);

            // Set the selected button's color
            switch (buttonNumber)
            {
                case 1:
                    button1.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new profil());
                    break;
                case 2:
                    button4.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new education());
                    break;
                case 3:
                    button2.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new langue());
                    break;
                case 4:
                    button3.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new competences());
                    break;
                case 5:
                    button5.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new projets());
                    break;
                case 6:
                    button6.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new associative());
                    break;
                case 7:
                    button7.BackColor = Color.FromArgb(46, 51, 73);
                    ShowForm(new contact());
                    break;
            }
        }

        private void ShowForm(Form form)
        {
            this.Base1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Base1.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e) => ButtonAction(1);
        private void button2_Click(object sender, EventArgs e) => ButtonAction(2);
        private void button3_Click(object sender, EventArgs e) => ButtonAction(3);
        private void button4_Click(object sender, EventArgs e) => ButtonAction(4);
        private void button5_Click(object sender, EventArgs e) => ButtonAction(5);
        private void button6_Click(object sender, EventArgs e) => ButtonAction(6);
        private void button7_Click(object sender, EventArgs e) => ButtonAction(7);

        private void InitializeSerialPort()
        {
            serialPort1 = new SerialPort("COM3", 9600)
            {
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort1.Open();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadLine();
                if (int.TryParse(data, out int result))
                {
                    receivedData = result;
                    this.Invoke(new MethodInvoker(() =>
                    {
                        ButtonAction(receivedData);
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        //textBox1.Text = "Failed to convert data to integer.";
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    //textBox1.Text = $"Error: {ex.Message}";
                }));
            }
        }
    }
}
