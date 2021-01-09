using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNC___Bank_Note_Calculator
{
    public partial class Form1 : Form
    {
        int summa = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            summing();
        }

        private void summing()
        {
            summa = 0;
            summa += Convert.ToInt32(label14.Text);
            summa += Convert.ToInt32(label15.Text);
            summa += Convert.ToInt32(label16.Text);
            summa += Convert.ToInt32(label17.Text);
            summa += Convert.ToInt32(label18.Text);
            summa += Convert.ToInt32(label19.Text);
            textBox_SUM.Text = Convert.ToString(summa);

            this.notifyIcon1.BalloonTipText = textBox_SUM.Text;
            this.notifyIcon1.BalloonTipTitle = "SUM";
            //this.notifyIcon1.Icon = new Icon("icon.ico");
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.ShowBalloonTip(100000);
            //notifyIcon1.s

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_SUM.Text = String.Empty;
            try
            {
                if (textBox1.Text == String.Empty)
                    label14.Text = "0";
                else
                    label14.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 500);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong number format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_SUM.Text = String.Empty;
            try
            {
                if (textBox2.Text == String.Empty)
                    label15.Text = "0";
                else
                    label15.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) * 1000);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong number format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox_SUM.Text = String.Empty;
            try
            {
                if (textBox3.Text == String.Empty)
                    label16.Text = "0";
                else
                    label16.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * 2000);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong number format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox_SUM.Text = String.Empty;
            try
            {
                if (textBox6.Text == String.Empty)
                    label17.Text = "0";
                else
                    label17.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) * 5000);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong number format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox_SUM.Text = String.Empty;
            try
            {
                if (textBox5.Text == String.Empty)
                    label18.Text = "0";
                else
                    label18.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) * 10000);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong number format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox_SUM.Text = String.Empty;
            try
            {
                if (textBox4.Text == String.Empty)
                    label19.Text = "0";
                else
                    label19.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * 20000);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong number format!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("ESC");
                this.Close();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        /*private void SendNotificationsOfPrintJobWithButton_LongerDisplay()
        {
            if (ApplicationServices.SessionId == PrintJobSessionId())
            {
                UserNotifications.RequestNotification(
                    "Your prints are ready!",
                    "Touch the image in this notification to open the Photo Print application.",
                    "C:\\Program Files\\PhotoPrint\\Images\\AppIcon_320x240.png",
                    TimeSpan.FromSeconds(20),
                    "PhotoPrint"
                    );
            }
        }*/
        /*
                private void SendNotifications_LongerDisplay()
                {
                    UserNotifications.RequestNotification(
                            "Your prints are ready!",
                            "Touch the image in this notification to open the Photo Print application.",
                            "C:\\Program Files\\PhotoPrint\\Images\\AppIcon_320x240.png",
                            TimeSpan.FromSeconds(20),
                            "PhotoPrint"
                            );

                }
        */
    }
}
