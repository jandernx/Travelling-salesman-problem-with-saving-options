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

namespace kursova
{
    public partial class Form1 : Form
    {
        int padding = 0;
        int[,] arr = new int[10, 10];
        private static List<int> minCycle = new List<int>();
        int minWeight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void onlydigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);

        }

        private void bunifuMetroTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void bunifuMetroTextbox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlydigits(sender, e);
        }

        private void set_padding()
        {
            bunifuMetroTextbox1.Location = new Point(bunifuMetroTextbox1.Location.X - padding * 15, bunifuMetroTextbox1.Location.Y - padding * 14);
            bunifuMetroTextbox2.Location = new Point(bunifuMetroTextbox2.Location.X - padding * 15, bunifuMetroTextbox2.Location.Y - padding * 14);
            bunifuMetroTextbox3.Location = new Point(bunifuMetroTextbox3.Location.X - padding * 15, bunifuMetroTextbox3.Location.Y - padding * 14);
            bunifuMetroTextbox4.Location = new Point(bunifuMetroTextbox4.Location.X - padding * 15, bunifuMetroTextbox4.Location.Y - padding * 14);
            bunifuMetroTextbox5.Location = new Point(bunifuMetroTextbox5.Location.X - padding * 15, bunifuMetroTextbox5.Location.Y - padding * 14);
            bunifuMetroTextbox6.Location = new Point(bunifuMetroTextbox6.Location.X - padding * 15, bunifuMetroTextbox6.Location.Y - padding * 14);
            bunifuMetroTextbox7.Location = new Point(bunifuMetroTextbox7.Location.X - padding * 15, bunifuMetroTextbox7.Location.Y - padding * 14);
            bunifuMetroTextbox8.Location = new Point(bunifuMetroTextbox8.Location.X - padding * 15, bunifuMetroTextbox8.Location.Y - padding * 14);
            bunifuMetroTextbox9.Location = new Point(bunifuMetroTextbox9.Location.X - padding * 15, bunifuMetroTextbox9.Location.Y - padding * 14);
            bunifuMetroTextbox10.Location = new Point(bunifuMetroTextbox10.Location.X - padding * 15, bunifuMetroTextbox10.Location.Y - padding * 14);
            bunifuMetroTextbox11.Location = new Point(bunifuMetroTextbox11.Location.X - padding * 15, bunifuMetroTextbox11.Location.Y - padding * 14);
            bunifuMetroTextbox12.Location = new Point(bunifuMetroTextbox12.Location.X - padding * 15, bunifuMetroTextbox12.Location.Y - padding * 14);
            bunifuMetroTextbox13.Location = new Point(bunifuMetroTextbox13.Location.X - padding * 15, bunifuMetroTextbox13.Location.Y - padding * 14);
            bunifuMetroTextbox14.Location = new Point(bunifuMetroTextbox14.Location.X - padding * 15, bunifuMetroTextbox14.Location.Y - padding * 14);
            bunifuMetroTextbox15.Location = new Point(bunifuMetroTextbox15.Location.X - padding * 15, bunifuMetroTextbox15.Location.Y - padding * 14);
            bunifuMetroTextbox16.Location = new Point(bunifuMetroTextbox16.Location.X - padding * 15, bunifuMetroTextbox16.Location.Y - padding * 14);
            bunifuMetroTextbox17.Location = new Point(bunifuMetroTextbox17.Location.X - padding * 15, bunifuMetroTextbox17.Location.Y - padding * 14);
            bunifuMetroTextbox18.Location = new Point(bunifuMetroTextbox18.Location.X - padding * 15, bunifuMetroTextbox18.Location.Y - padding * 14);
            bunifuMetroTextbox19.Location = new Point(bunifuMetroTextbox19.Location.X - padding * 15, bunifuMetroTextbox19.Location.Y - padding * 14);
            bunifuMetroTextbox20.Location = new Point(bunifuMetroTextbox20.Location.X - padding * 15, bunifuMetroTextbox20.Location.Y - padding * 14);
            bunifuMetroTextbox21.Location = new Point(bunifuMetroTextbox21.Location.X - padding * 15, bunifuMetroTextbox21.Location.Y - padding * 14);
            bunifuMetroTextbox22.Location = new Point(bunifuMetroTextbox22.Location.X - padding * 15, bunifuMetroTextbox22.Location.Y - padding * 14);
            bunifuMetroTextbox23.Location = new Point(bunifuMetroTextbox23.Location.X - padding * 15, bunifuMetroTextbox23.Location.Y - padding * 14);
            bunifuMetroTextbox24.Location = new Point(bunifuMetroTextbox24.Location.X - padding * 15, bunifuMetroTextbox24.Location.Y - padding * 14);
            bunifuMetroTextbox25.Location = new Point(bunifuMetroTextbox25.Location.X - padding * 15, bunifuMetroTextbox25.Location.Y - padding * 14);

        }
        private void add_button_MouseDown(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cities_label.Text) < 10)
            {
                if (Convert.ToInt32(cities_label.Text) == 3)
                {
                   
                }
                else
                {
                    this.Size = new Size(this.Width + 41, this.Height + 41);
                    bunifuFlatButton1.Location = new Point(bunifuFlatButton1.Location.X + 41, bunifuFlatButton1.Location.Y);
                    label3.Location = new Point(label3.Location.X + 41, label3.Location.Y);
                    label4.Location = new Point(label4.Location.X + 41, label4.Location.Y);
                    label5.Location = new Point(label5.Location.X + 41, label5.Location.Y);
                    label6.Location = new Point(label6.Location.X + 41, label6.Location.Y);
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 41, pictureBox1.Location.Y);
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 41, pictureBox2.Location.Y);
                }
                cities_label.Text = Convert.ToString(Convert.ToInt32(cities_label.Text) + 1);
                showTextboxes(Convert.ToInt32(cities_label.Text));
            }
        }

        private void remove_button_MouseDown(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cities_label.Text) > 3)
            {
                cities_label.Text = Convert.ToString(Convert.ToInt32(cities_label.Text) - 1);
                showTextboxes(Convert.ToInt32(cities_label.Text));
                if (Convert.ToInt32(cities_label.Text) == 3)
                {
                   
                }
                else
               {
                    this.Size = new Size(this.Width - 41, this.Height - 41);
                    bunifuFlatButton1.Location = new Point(bunifuFlatButton1.Location.X - 41, bunifuFlatButton1.Location.Y);
                    label3.Location = new Point(label3.Location.X - 41, label3.Location.Y);
                    label4.Location = new Point(label4.Location.X - 41, label4.Location.Y);
                    label5.Location = new Point(label5.Location.X - 41, label5.Location.Y);
                    label6.Location = new Point(label6.Location.X - 41, label6.Location.Y);
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 41, pictureBox1.Location.Y);
                    pictureBox2.Location = new Point(pictureBox2.Location.X - 41, pictureBox2.Location.Y);

               }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setWays(int n)
        {
            if (n == 3)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
            }

            if (n == 4)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
            }

            if (n == 5)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
                arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
                arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
                arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
                arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);

                arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
                arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
                arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
                arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
                arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
            }

            if (n == 6)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
                arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);
                arr[0, 5] = Convert.ToInt32(bunifuMetroTextbox50.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
                arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);
                arr[1, 5] = Convert.ToInt32(bunifuMetroTextbox45.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
                arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);
                arr[2, 5] = Convert.ToInt32(bunifuMetroTextbox40.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
                arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);
                arr[3, 5] = Convert.ToInt32(bunifuMetroTextbox35.Text);

                arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
                arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
                arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
                arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
                arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
                arr[4, 5] = Convert.ToInt32(bunifuMetroTextbox30.Text);

                arr[5, 0] = Convert.ToInt32(bunifuMetroTextbox75.Text);
                arr[5, 1] = Convert.ToInt32(bunifuMetroTextbox74.Text);
                arr[5, 2] = Convert.ToInt32(bunifuMetroTextbox73.Text);
                arr[5, 3] = Convert.ToInt32(bunifuMetroTextbox72.Text);
                arr[5, 4] = Convert.ToInt32(bunifuMetroTextbox71.Text);
                arr[5, 5] = Convert.ToInt32(bunifuMetroTextbox100.Text);


            }

            if (n == 7)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
                arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);
                arr[0, 5] = Convert.ToInt32(bunifuMetroTextbox50.Text);
                arr[0, 6] = Convert.ToInt32(bunifuMetroTextbox49.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
                arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);
                arr[1, 5] = Convert.ToInt32(bunifuMetroTextbox45.Text);
                arr[1, 6] = Convert.ToInt32(bunifuMetroTextbox44.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
                arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);
                arr[2, 5] = Convert.ToInt32(bunifuMetroTextbox40.Text);
                arr[2, 6] = Convert.ToInt32(bunifuMetroTextbox39.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
                arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);
                arr[3, 5] = Convert.ToInt32(bunifuMetroTextbox35.Text);
                arr[3, 6] = Convert.ToInt32(bunifuMetroTextbox34.Text);

                arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
                arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
                arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
                arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
                arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
                arr[4, 5] = Convert.ToInt32(bunifuMetroTextbox30.Text);
                arr[4, 6] = Convert.ToInt32(bunifuMetroTextbox29.Text);

                arr[5, 0] = Convert.ToInt32(bunifuMetroTextbox75.Text);
                arr[5, 1] = Convert.ToInt32(bunifuMetroTextbox74.Text);
                arr[5, 2] = Convert.ToInt32(bunifuMetroTextbox73.Text);
                arr[5, 3] = Convert.ToInt32(bunifuMetroTextbox72.Text);
                arr[5, 4] = Convert.ToInt32(bunifuMetroTextbox71.Text);
                arr[5, 5] = Convert.ToInt32(bunifuMetroTextbox100.Text);
                arr[5, 6] = Convert.ToInt32(bunifuMetroTextbox99.Text);

                arr[6, 0] = Convert.ToInt32(bunifuMetroTextbox70.Text);
                arr[6, 1] = Convert.ToInt32(bunifuMetroTextbox69.Text);
                arr[6, 2] = Convert.ToInt32(bunifuMetroTextbox68.Text);
                arr[6, 3] = Convert.ToInt32(bunifuMetroTextbox67.Text);
                arr[6, 4] = Convert.ToInt32(bunifuMetroTextbox66.Text);
                arr[6, 5] = Convert.ToInt32(bunifuMetroTextbox95.Text);
                arr[6, 6] = Convert.ToInt32(bunifuMetroTextbox94.Text);
            }

            if (n == 8)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
                arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);
                arr[0, 5] = Convert.ToInt32(bunifuMetroTextbox50.Text);
                arr[0, 6] = Convert.ToInt32(bunifuMetroTextbox49.Text);
                arr[0, 7] = Convert.ToInt32(bunifuMetroTextbox48.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
                arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);
                arr[1, 5] = Convert.ToInt32(bunifuMetroTextbox45.Text);
                arr[1, 6] = Convert.ToInt32(bunifuMetroTextbox44.Text);
                arr[1, 7] = Convert.ToInt32(bunifuMetroTextbox43.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
                arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);
                arr[2, 5] = Convert.ToInt32(bunifuMetroTextbox40.Text);
                arr[2, 6] = Convert.ToInt32(bunifuMetroTextbox39.Text);
                arr[2, 7] = Convert.ToInt32(bunifuMetroTextbox38.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
                arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);
                arr[3, 5] = Convert.ToInt32(bunifuMetroTextbox35.Text);
                arr[3, 6] = Convert.ToInt32(bunifuMetroTextbox34.Text);
                arr[3, 7] = Convert.ToInt32(bunifuMetroTextbox33.Text);

                arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
                arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
                arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
                arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
                arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
                arr[4, 5] = Convert.ToInt32(bunifuMetroTextbox30.Text);
                arr[4, 6] = Convert.ToInt32(bunifuMetroTextbox29.Text);
                arr[4, 7] = Convert.ToInt32(bunifuMetroTextbox28.Text);

                arr[5, 0] = Convert.ToInt32(bunifuMetroTextbox75.Text);
                arr[5, 1] = Convert.ToInt32(bunifuMetroTextbox74.Text);
                arr[5, 2] = Convert.ToInt32(bunifuMetroTextbox73.Text);
                arr[5, 3] = Convert.ToInt32(bunifuMetroTextbox72.Text);
                arr[5, 4] = Convert.ToInt32(bunifuMetroTextbox71.Text);
                arr[5, 5] = Convert.ToInt32(bunifuMetroTextbox100.Text);
                arr[5, 6] = Convert.ToInt32(bunifuMetroTextbox99.Text);
                arr[5, 7] = Convert.ToInt32(bunifuMetroTextbox98.Text);

                arr[6, 0] = Convert.ToInt32(bunifuMetroTextbox70.Text);
                arr[6, 1] = Convert.ToInt32(bunifuMetroTextbox69.Text);
                arr[6, 2] = Convert.ToInt32(bunifuMetroTextbox68.Text);
                arr[6, 3] = Convert.ToInt32(bunifuMetroTextbox67.Text);
                arr[6, 4] = Convert.ToInt32(bunifuMetroTextbox66.Text);
                arr[6, 5] = Convert.ToInt32(bunifuMetroTextbox95.Text);
                arr[6, 6] = Convert.ToInt32(bunifuMetroTextbox94.Text);
                arr[6, 7] = Convert.ToInt32(bunifuMetroTextbox93.Text);

                arr[7, 0] = Convert.ToInt32(bunifuMetroTextbox65.Text);
                arr[7, 1] = Convert.ToInt32(bunifuMetroTextbox64.Text);
                arr[7, 2] = Convert.ToInt32(bunifuMetroTextbox63.Text);
                arr[7, 3] = Convert.ToInt32(bunifuMetroTextbox62.Text);
                arr[7, 4] = Convert.ToInt32(bunifuMetroTextbox61.Text);
                arr[7, 5] = Convert.ToInt32(bunifuMetroTextbox90.Text);
                arr[7, 6] = Convert.ToInt32(bunifuMetroTextbox89.Text);
                arr[7, 7] = Convert.ToInt32(bunifuMetroTextbox88.Text);
            }

            if (n == 9)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
                arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);
                arr[0, 5] = Convert.ToInt32(bunifuMetroTextbox50.Text);
                arr[0, 6] = Convert.ToInt32(bunifuMetroTextbox49.Text);
                arr[0, 7] = Convert.ToInt32(bunifuMetroTextbox48.Text);
                arr[0, 8] = Convert.ToInt32(bunifuMetroTextbox47.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
                arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);
                arr[1, 5] = Convert.ToInt32(bunifuMetroTextbox45.Text);
                arr[1, 6] = Convert.ToInt32(bunifuMetroTextbox44.Text);
                arr[1, 7] = Convert.ToInt32(bunifuMetroTextbox43.Text);
                arr[1, 8] = Convert.ToInt32(bunifuMetroTextbox42.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
                arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);
                arr[2, 5] = Convert.ToInt32(bunifuMetroTextbox40.Text);
                arr[2, 6] = Convert.ToInt32(bunifuMetroTextbox39.Text);
                arr[2, 7] = Convert.ToInt32(bunifuMetroTextbox38.Text);
                arr[2, 8] = Convert.ToInt32(bunifuMetroTextbox37.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
                arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);
                arr[3, 5] = Convert.ToInt32(bunifuMetroTextbox35.Text);
                arr[3, 6] = Convert.ToInt32(bunifuMetroTextbox34.Text);
                arr[3, 7] = Convert.ToInt32(bunifuMetroTextbox33.Text);
                arr[3, 8] = Convert.ToInt32(bunifuMetroTextbox32.Text);

                arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
                arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
                arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
                arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
                arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
                arr[4, 5] = Convert.ToInt32(bunifuMetroTextbox30.Text);
                arr[4, 6] = Convert.ToInt32(bunifuMetroTextbox29.Text);
                arr[4, 7] = Convert.ToInt32(bunifuMetroTextbox28.Text);
                arr[4, 8] = Convert.ToInt32(bunifuMetroTextbox27.Text);

                arr[5, 0] = Convert.ToInt32(bunifuMetroTextbox75.Text);
                arr[5, 1] = Convert.ToInt32(bunifuMetroTextbox74.Text);
                arr[5, 2] = Convert.ToInt32(bunifuMetroTextbox73.Text);
                arr[5, 3] = Convert.ToInt32(bunifuMetroTextbox72.Text);
                arr[5, 4] = Convert.ToInt32(bunifuMetroTextbox71.Text);
                arr[5, 5] = Convert.ToInt32(bunifuMetroTextbox100.Text);
                arr[5, 6] = Convert.ToInt32(bunifuMetroTextbox99.Text);
                arr[5, 7] = Convert.ToInt32(bunifuMetroTextbox98.Text);
                arr[5, 8] = Convert.ToInt32(bunifuMetroTextbox97.Text);

                arr[6, 0] = Convert.ToInt32(bunifuMetroTextbox70.Text);
                arr[6, 1] = Convert.ToInt32(bunifuMetroTextbox69.Text);
                arr[6, 2] = Convert.ToInt32(bunifuMetroTextbox68.Text);
                arr[6, 3] = Convert.ToInt32(bunifuMetroTextbox67.Text);
                arr[6, 4] = Convert.ToInt32(bunifuMetroTextbox66.Text);
                arr[6, 5] = Convert.ToInt32(bunifuMetroTextbox95.Text);
                arr[6, 6] = Convert.ToInt32(bunifuMetroTextbox94.Text);
                arr[6, 7] = Convert.ToInt32(bunifuMetroTextbox93.Text);
                arr[6, 8] = Convert.ToInt32(bunifuMetroTextbox92.Text);

                arr[7, 0] = Convert.ToInt32(bunifuMetroTextbox65.Text);
                arr[7, 1] = Convert.ToInt32(bunifuMetroTextbox64.Text);
                arr[7, 2] = Convert.ToInt32(bunifuMetroTextbox63.Text);
                arr[7, 3] = Convert.ToInt32(bunifuMetroTextbox62.Text);
                arr[7, 4] = Convert.ToInt32(bunifuMetroTextbox61.Text);
                arr[7, 5] = Convert.ToInt32(bunifuMetroTextbox90.Text);
                arr[7, 6] = Convert.ToInt32(bunifuMetroTextbox89.Text);
                arr[7, 7] = Convert.ToInt32(bunifuMetroTextbox88.Text);
                arr[7, 8] = Convert.ToInt32(bunifuMetroTextbox87.Text);

                arr[8, 0] = Convert.ToInt32(bunifuMetroTextbox60.Text);
                arr[8, 1] = Convert.ToInt32(bunifuMetroTextbox59.Text);
                arr[8, 2] = Convert.ToInt32(bunifuMetroTextbox58.Text);
                arr[8, 3] = Convert.ToInt32(bunifuMetroTextbox57.Text);
                arr[8, 4] = Convert.ToInt32(bunifuMetroTextbox56.Text);
                arr[8, 5] = Convert.ToInt32(bunifuMetroTextbox85.Text);
                arr[8, 6] = Convert.ToInt32(bunifuMetroTextbox84.Text);
                arr[8, 7] = Convert.ToInt32(bunifuMetroTextbox83.Text);
                arr[8, 8] = Convert.ToInt32(bunifuMetroTextbox82.Text);
            }

            if (n == 10)
            {
                arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
                arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
                arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
                arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
                arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);
                arr[0, 5] = Convert.ToInt32(bunifuMetroTextbox50.Text);
                arr[0, 6] = Convert.ToInt32(bunifuMetroTextbox49.Text);
                arr[0, 7] = Convert.ToInt32(bunifuMetroTextbox48.Text);
                arr[0, 8] = Convert.ToInt32(bunifuMetroTextbox47.Text);
                arr[0, 9] = Convert.ToInt32(bunifuMetroTextbox46.Text);

                arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
                arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
                arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
                arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
                arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);
                arr[1, 5] = Convert.ToInt32(bunifuMetroTextbox45.Text);
                arr[1, 6] = Convert.ToInt32(bunifuMetroTextbox44.Text);
                arr[1, 7] = Convert.ToInt32(bunifuMetroTextbox43.Text);
                arr[1, 8] = Convert.ToInt32(bunifuMetroTextbox42.Text);
                arr[1, 9] = Convert.ToInt32(bunifuMetroTextbox41.Text);

                arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
                arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
                arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
                arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
                arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);
                arr[2, 5] = Convert.ToInt32(bunifuMetroTextbox40.Text);
                arr[2, 6] = Convert.ToInt32(bunifuMetroTextbox39.Text);
                arr[2, 7] = Convert.ToInt32(bunifuMetroTextbox38.Text);
                arr[2, 8] = Convert.ToInt32(bunifuMetroTextbox37.Text);
                arr[2, 9] = Convert.ToInt32(bunifuMetroTextbox36.Text);

                arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
                arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
                arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
                arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
                arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);
                arr[3, 5] = Convert.ToInt32(bunifuMetroTextbox35.Text);
                arr[3, 6] = Convert.ToInt32(bunifuMetroTextbox34.Text);
                arr[3, 7] = Convert.ToInt32(bunifuMetroTextbox33.Text);
                arr[3, 8] = Convert.ToInt32(bunifuMetroTextbox32.Text);
                arr[3, 9] = Convert.ToInt32(bunifuMetroTextbox31.Text);

                arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
                arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
                arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
                arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
                arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
                arr[4, 5] = Convert.ToInt32(bunifuMetroTextbox30.Text);
                arr[4, 6] = Convert.ToInt32(bunifuMetroTextbox29.Text);
                arr[4, 7] = Convert.ToInt32(bunifuMetroTextbox28.Text);
                arr[4, 8] = Convert.ToInt32(bunifuMetroTextbox27.Text);
                arr[4, 9] = Convert.ToInt32(bunifuMetroTextbox26.Text);

                arr[5, 0] = Convert.ToInt32(bunifuMetroTextbox75.Text);
                arr[5, 1] = Convert.ToInt32(bunifuMetroTextbox74.Text);
                arr[5, 2] = Convert.ToInt32(bunifuMetroTextbox73.Text);
                arr[5, 3] = Convert.ToInt32(bunifuMetroTextbox72.Text);
                arr[5, 4] = Convert.ToInt32(bunifuMetroTextbox71.Text);
                arr[5, 5] = Convert.ToInt32(bunifuMetroTextbox100.Text);
                arr[5, 6] = Convert.ToInt32(bunifuMetroTextbox99.Text);
                arr[5, 7] = Convert.ToInt32(bunifuMetroTextbox98.Text);
                arr[5, 8] = Convert.ToInt32(bunifuMetroTextbox97.Text);
                arr[5, 9] = Convert.ToInt32(bunifuMetroTextbox96.Text);

                arr[6, 0] = Convert.ToInt32(bunifuMetroTextbox70.Text);
                arr[6, 1] = Convert.ToInt32(bunifuMetroTextbox69.Text);
                arr[6, 2] = Convert.ToInt32(bunifuMetroTextbox68.Text);
                arr[6, 3] = Convert.ToInt32(bunifuMetroTextbox67.Text);
                arr[6, 4] = Convert.ToInt32(bunifuMetroTextbox66.Text);
                arr[6, 5] = Convert.ToInt32(bunifuMetroTextbox95.Text);
                arr[6, 6] = Convert.ToInt32(bunifuMetroTextbox94.Text);
                arr[6, 7] = Convert.ToInt32(bunifuMetroTextbox93.Text);
                arr[6, 8] = Convert.ToInt32(bunifuMetroTextbox92.Text);
                arr[6, 9] = Convert.ToInt32(bunifuMetroTextbox91.Text);

                arr[7, 0] = Convert.ToInt32(bunifuMetroTextbox65.Text);
                arr[7, 1] = Convert.ToInt32(bunifuMetroTextbox64.Text);
                arr[7, 2] = Convert.ToInt32(bunifuMetroTextbox63.Text);
                arr[7, 3] = Convert.ToInt32(bunifuMetroTextbox62.Text);
                arr[7, 4] = Convert.ToInt32(bunifuMetroTextbox61.Text);
                arr[7, 5] = Convert.ToInt32(bunifuMetroTextbox90.Text);
                arr[7, 6] = Convert.ToInt32(bunifuMetroTextbox89.Text);
                arr[7, 7] = Convert.ToInt32(bunifuMetroTextbox88.Text);
                arr[7, 8] = Convert.ToInt32(bunifuMetroTextbox87.Text);
                arr[7, 9] = Convert.ToInt32(bunifuMetroTextbox86.Text);

                arr[8, 0] = Convert.ToInt32(bunifuMetroTextbox60.Text);
                arr[8, 1] = Convert.ToInt32(bunifuMetroTextbox59.Text);
                arr[8, 2] = Convert.ToInt32(bunifuMetroTextbox58.Text);
                arr[8, 3] = Convert.ToInt32(bunifuMetroTextbox57.Text);
                arr[8, 4] = Convert.ToInt32(bunifuMetroTextbox56.Text);
                arr[8, 5] = Convert.ToInt32(bunifuMetroTextbox85.Text);
                arr[8, 6] = Convert.ToInt32(bunifuMetroTextbox84.Text);
                arr[8, 7] = Convert.ToInt32(bunifuMetroTextbox83.Text);
                arr[8, 8] = Convert.ToInt32(bunifuMetroTextbox82.Text);
                arr[8, 9] = Convert.ToInt32(bunifuMetroTextbox81.Text);

                arr[9, 0] = Convert.ToInt32(bunifuMetroTextbox55.Text);
                arr[9, 1] = Convert.ToInt32(bunifuMetroTextbox54.Text);
                arr[9, 2] = Convert.ToInt32(bunifuMetroTextbox53.Text);
                arr[9, 3] = Convert.ToInt32(bunifuMetroTextbox52.Text);
                arr[9, 4] = Convert.ToInt32(bunifuMetroTextbox51.Text);
                arr[9, 5] = Convert.ToInt32(bunifuMetroTextbox80.Text);
                arr[9, 6] = Convert.ToInt32(bunifuMetroTextbox79.Text);
                arr[9, 7] = Convert.ToInt32(bunifuMetroTextbox78.Text);
                arr[9, 8] = Convert.ToInt32(bunifuMetroTextbox77.Text);
                arr[9, 9] = Convert.ToInt32(bunifuMetroTextbox76.Text);
            }
        }
        private void hideALLtextboxes()
        {
            bunifuMetroTextbox1.Visible = false;
            bunifuMetroTextbox2.Visible = false;
            bunifuMetroTextbox3.Visible = false;
            bunifuMetroTextbox10.Visible = false;
            bunifuMetroTextbox9.Visible = false;
            bunifuMetroTextbox8.Visible = false;
            bunifuMetroTextbox15.Visible = false;
            bunifuMetroTextbox14.Visible = false;
            bunifuMetroTextbox13.Visible = false;
            bunifuMetroTextbox20.Visible = false;
            bunifuMetroTextbox19.Visible = false;
            bunifuMetroTextbox18.Visible = false;
            bunifuMetroTextbox17.Visible = false;
            bunifuMetroTextbox4.Visible = false;
            bunifuMetroTextbox7.Visible = false;
            bunifuMetroTextbox12.Visible = false;
            bunifuMetroTextbox25.Visible = false;
            bunifuMetroTextbox24.Visible = false;
            bunifuMetroTextbox23.Visible = false;
            bunifuMetroTextbox22.Visible = false;
            bunifuMetroTextbox21.Visible = false;
            bunifuMetroTextbox5.Visible = false;
            bunifuMetroTextbox6.Visible = false;
            bunifuMetroTextbox11.Visible = false;
            bunifuMetroTextbox16.Visible = false;
            bunifuMetroTextbox75.Visible = false;
            bunifuMetroTextbox74.Visible = false;
            bunifuMetroTextbox73.Visible = false;
            bunifuMetroTextbox72.Visible = false;
            bunifuMetroTextbox71.Visible = false;
            bunifuMetroTextbox100.Visible = false;
            bunifuMetroTextbox30.Visible = false;
            bunifuMetroTextbox35.Visible = false;
            bunifuMetroTextbox40.Visible = false;
            bunifuMetroTextbox45.Visible = false;
            bunifuMetroTextbox50.Visible = false;
            bunifuMetroTextbox70.Visible = false;
            bunifuMetroTextbox69.Visible = false;
            bunifuMetroTextbox68.Visible = false;
            bunifuMetroTextbox67.Visible = false;
            bunifuMetroTextbox66.Visible = false;
            bunifuMetroTextbox95.Visible = false;
            bunifuMetroTextbox94.Visible = false;
            bunifuMetroTextbox49.Visible = false;
            bunifuMetroTextbox44.Visible = false;
            bunifuMetroTextbox39.Visible = false;
            bunifuMetroTextbox34.Visible = false;
            bunifuMetroTextbox29.Visible = false;
            bunifuMetroTextbox99.Visible = false;
            bunifuMetroTextbox65.Visible = false;
            bunifuMetroTextbox64.Visible = false;
            bunifuMetroTextbox63.Visible = false;
            bunifuMetroTextbox62.Visible = false;
            bunifuMetroTextbox61.Visible = false;
            bunifuMetroTextbox90.Visible = false;
            bunifuMetroTextbox89.Visible = false;
            bunifuMetroTextbox88.Visible = false;
            bunifuMetroTextbox93.Visible = false;
            bunifuMetroTextbox98.Visible = false;
            bunifuMetroTextbox28.Visible = false;
            bunifuMetroTextbox33.Visible = false;
            bunifuMetroTextbox38.Visible = false;
            bunifuMetroTextbox43.Visible = false;
            bunifuMetroTextbox48.Visible = false;

            bunifuMetroTextbox60.Visible = false;
            bunifuMetroTextbox59.Visible = false;
            bunifuMetroTextbox58.Visible = false;
            bunifuMetroTextbox57.Visible = false;
            bunifuMetroTextbox56.Visible = false;
            bunifuMetroTextbox85.Visible = false;
            bunifuMetroTextbox84.Visible = false;
            bunifuMetroTextbox83.Visible = false;
            bunifuMetroTextbox82.Visible = false;
            bunifuMetroTextbox87.Visible = false;
            bunifuMetroTextbox92.Visible = false;
            bunifuMetroTextbox97.Visible = false;
            bunifuMetroTextbox27.Visible = false;
            bunifuMetroTextbox32.Visible = false;
            bunifuMetroTextbox37.Visible = false;
            bunifuMetroTextbox42.Visible = false;
            bunifuMetroTextbox47.Visible = false;
            bunifuMetroTextbox55.Visible = false;
            bunifuMetroTextbox54.Visible = false;
            bunifuMetroTextbox53.Visible = false;
            bunifuMetroTextbox52.Visible = false;
            bunifuMetroTextbox51.Visible = false;
            bunifuMetroTextbox80.Visible = false;
            bunifuMetroTextbox79.Visible = false;
            bunifuMetroTextbox78.Visible = false;
            bunifuMetroTextbox77.Visible = false;
            bunifuMetroTextbox76.Visible = false;
            bunifuMetroTextbox81.Visible = false;
            bunifuMetroTextbox86.Visible = false;
            bunifuMetroTextbox91.Visible = false;
            bunifuMetroTextbox96.Visible = false;
            bunifuMetroTextbox26.Visible = false;
            bunifuMetroTextbox31.Visible = false;
            bunifuMetroTextbox36.Visible = false;
            bunifuMetroTextbox41.Visible = false;
            bunifuMetroTextbox46.Visible = false;
        }
        private void showTextboxes(int n)
        {
            hideALLtextboxes();
            if (n == 3)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
            }

            else if (n == 4)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
            }

            else if (n == 5)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
                bunifuMetroTextbox25.Visible = true;
                bunifuMetroTextbox24.Visible = true;
                bunifuMetroTextbox23.Visible = true;
                bunifuMetroTextbox22.Visible = true;
                bunifuMetroTextbox21.Visible = true;
                bunifuMetroTextbox5.Visible = true;
                bunifuMetroTextbox6.Visible = true;
                bunifuMetroTextbox11.Visible = true;
                bunifuMetroTextbox16.Visible = true;
            }

            else if (n == 6)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
                bunifuMetroTextbox25.Visible = true;
                bunifuMetroTextbox24.Visible = true;
                bunifuMetroTextbox23.Visible = true;
                bunifuMetroTextbox22.Visible = true;
                bunifuMetroTextbox21.Visible = true;
                bunifuMetroTextbox5.Visible = true;
                bunifuMetroTextbox6.Visible = true;
                bunifuMetroTextbox11.Visible = true;
                bunifuMetroTextbox16.Visible = true;
                bunifuMetroTextbox75.Visible = true;
                bunifuMetroTextbox74.Visible = true;
                bunifuMetroTextbox73.Visible = true;
                bunifuMetroTextbox72.Visible = true;
                bunifuMetroTextbox71.Visible = true;
                bunifuMetroTextbox100.Visible = true;
                bunifuMetroTextbox30.Visible = true;
                bunifuMetroTextbox35.Visible = true;
                bunifuMetroTextbox40.Visible = true;
                bunifuMetroTextbox45.Visible = true;
                bunifuMetroTextbox50.Visible = true;
            }

            else if (n == 7)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
                bunifuMetroTextbox25.Visible = true;
                bunifuMetroTextbox24.Visible = true;
                bunifuMetroTextbox23.Visible = true;
                bunifuMetroTextbox22.Visible = true;
                bunifuMetroTextbox21.Visible = true;
                bunifuMetroTextbox5.Visible = true;
                bunifuMetroTextbox6.Visible = true;
                bunifuMetroTextbox11.Visible = true;
                bunifuMetroTextbox16.Visible = true;
                bunifuMetroTextbox75.Visible = true;
                bunifuMetroTextbox74.Visible = true;
                bunifuMetroTextbox73.Visible = true;
                bunifuMetroTextbox72.Visible = true;
                bunifuMetroTextbox71.Visible = true;
                bunifuMetroTextbox100.Visible = true;
                bunifuMetroTextbox30.Visible = true;
                bunifuMetroTextbox35.Visible = true;
                bunifuMetroTextbox40.Visible = true;
                bunifuMetroTextbox45.Visible = true;
                bunifuMetroTextbox50.Visible = true;
                bunifuMetroTextbox70.Visible = true;
                bunifuMetroTextbox69.Visible = true;
                bunifuMetroTextbox68.Visible = true;
                bunifuMetroTextbox67.Visible = true;
                bunifuMetroTextbox66.Visible = true;
                bunifuMetroTextbox95.Visible = true;
                bunifuMetroTextbox94.Visible = true;
                bunifuMetroTextbox49.Visible = true;
                bunifuMetroTextbox44.Visible = true;
                bunifuMetroTextbox39.Visible = true;
                bunifuMetroTextbox34.Visible = true;
                bunifuMetroTextbox29.Visible = true;
                bunifuMetroTextbox99.Visible = true;
            }

            else if (n == 8)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
                bunifuMetroTextbox25.Visible = true;
                bunifuMetroTextbox24.Visible = true;
                bunifuMetroTextbox23.Visible = true;
                bunifuMetroTextbox22.Visible = true;
                bunifuMetroTextbox21.Visible = true;
                bunifuMetroTextbox5.Visible = true;
                bunifuMetroTextbox6.Visible = true;
                bunifuMetroTextbox11.Visible = true;
                bunifuMetroTextbox16.Visible = true;
                bunifuMetroTextbox75.Visible = true;
                bunifuMetroTextbox74.Visible = true;
                bunifuMetroTextbox73.Visible = true;
                bunifuMetroTextbox72.Visible = true;
                bunifuMetroTextbox71.Visible = true;
                bunifuMetroTextbox100.Visible = true;
                bunifuMetroTextbox30.Visible = true;
                bunifuMetroTextbox35.Visible = true;
                bunifuMetroTextbox40.Visible = true;
                bunifuMetroTextbox45.Visible = true;
                bunifuMetroTextbox50.Visible = true;
                bunifuMetroTextbox70.Visible = true;
                bunifuMetroTextbox69.Visible = true;
                bunifuMetroTextbox68.Visible = true;
                bunifuMetroTextbox67.Visible = true;
                bunifuMetroTextbox66.Visible = true;
                bunifuMetroTextbox95.Visible = true;
                bunifuMetroTextbox94.Visible = true;
                bunifuMetroTextbox49.Visible = true;
                bunifuMetroTextbox44.Visible = true;
                bunifuMetroTextbox39.Visible = true;
                bunifuMetroTextbox34.Visible = true;
                bunifuMetroTextbox29.Visible = true;
                bunifuMetroTextbox99.Visible = true;

                bunifuMetroTextbox65.Visible = true;
                bunifuMetroTextbox64.Visible = true;
                bunifuMetroTextbox63.Visible = true;
                bunifuMetroTextbox62.Visible = true;
                bunifuMetroTextbox61.Visible = true;
                bunifuMetroTextbox90.Visible = true;
                bunifuMetroTextbox89.Visible = true;
                bunifuMetroTextbox88.Visible = true;
                bunifuMetroTextbox93.Visible = true;
                bunifuMetroTextbox98.Visible = true;
                bunifuMetroTextbox28.Visible = true;
                bunifuMetroTextbox33.Visible = true;
                bunifuMetroTextbox38.Visible = true;
                bunifuMetroTextbox43.Visible = true;
                bunifuMetroTextbox48.Visible = true;
            }

            else if (n == 9)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
                bunifuMetroTextbox25.Visible = true;
                bunifuMetroTextbox24.Visible = true;
                bunifuMetroTextbox23.Visible = true;
                bunifuMetroTextbox22.Visible = true;
                bunifuMetroTextbox21.Visible = true;
                bunifuMetroTextbox5.Visible = true;
                bunifuMetroTextbox6.Visible = true;
                bunifuMetroTextbox11.Visible = true;
                bunifuMetroTextbox16.Visible = true;
                bunifuMetroTextbox75.Visible = true;
                bunifuMetroTextbox74.Visible = true;
                bunifuMetroTextbox73.Visible = true;
                bunifuMetroTextbox72.Visible = true;
                bunifuMetroTextbox71.Visible = true;
                bunifuMetroTextbox100.Visible = true;
                bunifuMetroTextbox30.Visible = true;
                bunifuMetroTextbox35.Visible = true;
                bunifuMetroTextbox40.Visible = true;
                bunifuMetroTextbox45.Visible = true;
                bunifuMetroTextbox50.Visible = true;
                bunifuMetroTextbox70.Visible = true;
                bunifuMetroTextbox69.Visible = true;
                bunifuMetroTextbox68.Visible = true;
                bunifuMetroTextbox67.Visible = true;
                bunifuMetroTextbox66.Visible = true;
                bunifuMetroTextbox95.Visible = true;
                bunifuMetroTextbox94.Visible = true;
                bunifuMetroTextbox49.Visible = true;
                bunifuMetroTextbox44.Visible = true;
                bunifuMetroTextbox39.Visible = true;
                bunifuMetroTextbox34.Visible = true;
                bunifuMetroTextbox29.Visible = true;
                bunifuMetroTextbox99.Visible = true;
                bunifuMetroTextbox65.Visible = true;
                bunifuMetroTextbox64.Visible = true;
                bunifuMetroTextbox63.Visible = true;
                bunifuMetroTextbox62.Visible = true;
                bunifuMetroTextbox61.Visible = true;
                bunifuMetroTextbox90.Visible = true;
                bunifuMetroTextbox89.Visible = true;
                bunifuMetroTextbox88.Visible = true;
                bunifuMetroTextbox93.Visible = true;
                bunifuMetroTextbox98.Visible = true;
                bunifuMetroTextbox28.Visible = true;
                bunifuMetroTextbox33.Visible = true;
                bunifuMetroTextbox38.Visible = true;
                bunifuMetroTextbox43.Visible = true;
                bunifuMetroTextbox48.Visible = true;

                bunifuMetroTextbox60.Visible = true;
                bunifuMetroTextbox59.Visible = true;
                bunifuMetroTextbox58.Visible = true;
                bunifuMetroTextbox57.Visible = true;
                bunifuMetroTextbox56.Visible = true;
                bunifuMetroTextbox85.Visible = true;
                bunifuMetroTextbox84.Visible = true;
                bunifuMetroTextbox83.Visible = true;
                bunifuMetroTextbox82.Visible = true;
                bunifuMetroTextbox87.Visible = true;
                bunifuMetroTextbox92.Visible = true;
                bunifuMetroTextbox97.Visible = true;
                bunifuMetroTextbox27.Visible = true;
                bunifuMetroTextbox32.Visible = true;
                bunifuMetroTextbox37.Visible = true;
                bunifuMetroTextbox42.Visible = true;
                bunifuMetroTextbox47.Visible = true;

            }

            else if (n == 10)
            {
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox2.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                bunifuMetroTextbox10.Visible = true;
                bunifuMetroTextbox9.Visible = true;
                bunifuMetroTextbox8.Visible = true;
                bunifuMetroTextbox15.Visible = true;
                bunifuMetroTextbox14.Visible = true;
                bunifuMetroTextbox13.Visible = true;
                bunifuMetroTextbox20.Visible = true;
                bunifuMetroTextbox19.Visible = true;
                bunifuMetroTextbox18.Visible = true;
                bunifuMetroTextbox17.Visible = true;
                bunifuMetroTextbox4.Visible = true;
                bunifuMetroTextbox7.Visible = true;
                bunifuMetroTextbox12.Visible = true;
                bunifuMetroTextbox25.Visible = true;
                bunifuMetroTextbox24.Visible = true;
                bunifuMetroTextbox23.Visible = true;
                bunifuMetroTextbox22.Visible = true;
                bunifuMetroTextbox21.Visible = true;
                bunifuMetroTextbox5.Visible = true;
                bunifuMetroTextbox6.Visible = true;
                bunifuMetroTextbox11.Visible = true;
                bunifuMetroTextbox16.Visible = true;
                bunifuMetroTextbox75.Visible = true;
                bunifuMetroTextbox74.Visible = true;
                bunifuMetroTextbox73.Visible = true;
                bunifuMetroTextbox72.Visible = true;
                bunifuMetroTextbox71.Visible = true;
                bunifuMetroTextbox100.Visible = true;
                bunifuMetroTextbox30.Visible = true;
                bunifuMetroTextbox35.Visible = true;
                bunifuMetroTextbox40.Visible = true;
                bunifuMetroTextbox45.Visible = true;
                bunifuMetroTextbox50.Visible = true;
                bunifuMetroTextbox70.Visible = true;
                bunifuMetroTextbox69.Visible = true;
                bunifuMetroTextbox68.Visible = true;
                bunifuMetroTextbox67.Visible = true;
                bunifuMetroTextbox66.Visible = true;
                bunifuMetroTextbox95.Visible = true;
                bunifuMetroTextbox94.Visible = true;
                bunifuMetroTextbox49.Visible = true;
                bunifuMetroTextbox44.Visible = true;
                bunifuMetroTextbox39.Visible = true;
                bunifuMetroTextbox34.Visible = true;
                bunifuMetroTextbox29.Visible = true;
                bunifuMetroTextbox99.Visible = true;
                bunifuMetroTextbox65.Visible = true;
                bunifuMetroTextbox64.Visible = true;
                bunifuMetroTextbox63.Visible = true;
                bunifuMetroTextbox62.Visible = true;
                bunifuMetroTextbox61.Visible = true;
                bunifuMetroTextbox90.Visible = true;
                bunifuMetroTextbox89.Visible = true;
                bunifuMetroTextbox88.Visible = true;
                bunifuMetroTextbox93.Visible = true;
                bunifuMetroTextbox98.Visible = true;
                bunifuMetroTextbox28.Visible = true;
                bunifuMetroTextbox33.Visible = true;
                bunifuMetroTextbox38.Visible = true;
                bunifuMetroTextbox43.Visible = true;
                bunifuMetroTextbox48.Visible = true;

                bunifuMetroTextbox60.Visible = true;
                bunifuMetroTextbox59.Visible = true;
                bunifuMetroTextbox58.Visible = true;
                bunifuMetroTextbox57.Visible = true;
                bunifuMetroTextbox56.Visible = true;
                bunifuMetroTextbox85.Visible = true;
                bunifuMetroTextbox84.Visible = true;
                bunifuMetroTextbox83.Visible = true;
                bunifuMetroTextbox82.Visible = true;
                bunifuMetroTextbox87.Visible = true;
                bunifuMetroTextbox92.Visible = true;
                bunifuMetroTextbox97.Visible = true;
                bunifuMetroTextbox27.Visible = true;
                bunifuMetroTextbox32.Visible = true;
                bunifuMetroTextbox37.Visible = true;
                bunifuMetroTextbox42.Visible = true;
                bunifuMetroTextbox47.Visible = true;
                bunifuMetroTextbox55.Visible = true;
                bunifuMetroTextbox54.Visible = true;
                bunifuMetroTextbox53.Visible = true;
                bunifuMetroTextbox52.Visible = true;
                bunifuMetroTextbox51.Visible = true;
                bunifuMetroTextbox80.Visible = true;
                bunifuMetroTextbox79.Visible = true;
                bunifuMetroTextbox78.Visible = true;
                bunifuMetroTextbox77.Visible = true;
                bunifuMetroTextbox76.Visible = true;
                bunifuMetroTextbox81.Visible = true;
                bunifuMetroTextbox86.Visible = true;
                bunifuMetroTextbox91.Visible = true;
                bunifuMetroTextbox96.Visible = true;
                bunifuMetroTextbox26.Visible = true;
                bunifuMetroTextbox31.Visible = true;
                bunifuMetroTextbox36.Visible = true;
                bunifuMetroTextbox41.Visible = true;
                bunifuMetroTextbox46.Visible = true;

            }
        }

        private void showResult()
        {
            int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            String s = String.Empty;
            for (int i = 0; i <= Solution.n; i++)
            {
                a.SetValue(Solution.minimalCycle[i] + 1, i);
                if(i != Solution.n)
                s += a.GetValue(i) + Convert.ToString("->");
                else
                    s += a.GetValue(i);
            }
            //MessageBox.Show(Convert.ToString(a.GetValue(0)) + Convert.ToString(a.GetValue(1)) + Convert.ToString(a.GetValue(2)) + Convert.ToString(a.GetValue(3)) + Convert.ToString(a.GetValue(4)) + Convert.ToString(a.GetValue(5)) + Convert.ToString(Solution.minimalWeight));
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label5.Text = Convert.ToString(Solution.minimalWeight);
            label6.Text = s;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //arr[0, 0] = Convert.ToInt32(bunifuMetroTextbox1.Text);
            //arr[0, 1] = Convert.ToInt32(bunifuMetroTextbox2.Text);
            //arr[0, 2] = Convert.ToInt32(bunifuMetroTextbox3.Text);
            //arr[0, 3] = Convert.ToInt32(bunifuMetroTextbox4.Text);
            //arr[0, 4] = Convert.ToInt32(bunifuMetroTextbox5.Text);
            //arr[1, 0] = Convert.ToInt32(bunifuMetroTextbox10.Text);
            //arr[1, 1] = Convert.ToInt32(bunifuMetroTextbox9.Text);
            //arr[1, 2] = Convert.ToInt32(bunifuMetroTextbox8.Text);
            //arr[1, 3] = Convert.ToInt32(bunifuMetroTextbox7.Text);
            //arr[1, 4] = Convert.ToInt32(bunifuMetroTextbox6.Text);
            //arr[2, 0] = Convert.ToInt32(bunifuMetroTextbox15.Text);
            //arr[2, 1] = Convert.ToInt32(bunifuMetroTextbox14.Text);
            //arr[2, 2] = Convert.ToInt32(bunifuMetroTextbox13.Text);
            //arr[2, 3] = Convert.ToInt32(bunifuMetroTextbox12.Text);
            //arr[2, 4] = Convert.ToInt32(bunifuMetroTextbox11.Text);
            //arr[3, 0] = Convert.ToInt32(bunifuMetroTextbox20.Text);
            //arr[3, 1] = Convert.ToInt32(bunifuMetroTextbox19.Text);
            //arr[3, 2] = Convert.ToInt32(bunifuMetroTextbox18.Text);
            //arr[3, 3] = Convert.ToInt32(bunifuMetroTextbox17.Text);
            //arr[3, 4] = Convert.ToInt32(bunifuMetroTextbox16.Text);
            //arr[4, 0] = Convert.ToInt32(bunifuMetroTextbox25.Text);
            //arr[4, 1] = Convert.ToInt32(bunifuMetroTextbox24.Text);
            //arr[4, 2] = Convert.ToInt32(bunifuMetroTextbox23.Text);
            //arr[4, 3] = Convert.ToInt32(bunifuMetroTextbox22.Text);
            //arr[4, 4] = Convert.ToInt32(bunifuMetroTextbox21.Text);
            //textBox1.Text = Convert.ToString(Solution.getmin(arr, Convert.ToInt32(cities_label.Text)));
            Solution begining = new Solution();
            int n = Convert.ToInt32(cities_label.Text);
            setWays(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Solution.adjMatrix[i, j] = arr[i, j];
                }        
            }
            Solution.n = n;

            begining.algorithm();
            if (Solution.minimalWeight == -1)
                MessageBox.Show("We have not found any Hamilton cycles");
            else
            {
                showResult();
                pictureBox2.Visible = true;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = 0;
                }
            }
            for (int i = 0; i < Solution.n; i++)
            {
                minCycle.Add(0);
            }
            for (int i = 0; i < Solution.n; i++)
            {
                minCycle[i] = Solution.minimalCycle[i];
            }
            minWeight = Solution.minimalWeight;
            for (int i = 0; i < n; i++)
            {
                Solution.minimalCycle[i] = 0;
            }
            Solution.minimalWeight = 10000;
        }

        private void bunifuMetroTextbox40_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox35_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void generateValues(int n) 
        {
            Random rand = new Random();

            if (n == 3)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
            }

            else if (n == 4)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
            }

            else if (n == 5)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox25.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox24.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox23.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox22.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox21.Text = Convert.ToString(0);
                bunifuMetroTextbox5.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox6.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox11.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox16.Text = Convert.ToString(rand.Next(1, 20));
            }

            else if (n == 6)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox25.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox24.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox23.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox22.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox21.Text = Convert.ToString(0);
                bunifuMetroTextbox5.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox6.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox11.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox16.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox75.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox74.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox73.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox72.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox71.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox100.Text = Convert.ToString(0);
                bunifuMetroTextbox30.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox35.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox40.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox45.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox50.Text = Convert.ToString(rand.Next(1, 20));
            }

            else if (n == 7)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox25.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox24.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox23.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox22.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox21.Text = Convert.ToString(0);
                bunifuMetroTextbox5.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox6.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox11.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox16.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox75.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox74.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox73.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox72.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox71.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox100.Text = Convert.ToString(0);
                bunifuMetroTextbox30.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox35.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox40.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox45.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox50.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox70.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox69.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox68.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox67.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox66.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox95.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox94.Text = Convert.ToString(0);
                bunifuMetroTextbox49.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox44.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox39.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox34.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox29.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox99.Text = Convert.ToString(rand.Next(1, 20));
            }

            else if (n == 8)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox25.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox24.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox23.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox22.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox21.Text = Convert.ToString(0);
                bunifuMetroTextbox5.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox6.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox11.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox16.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox75.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox74.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox73.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox72.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox71.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox100.Text = Convert.ToString(0);
                bunifuMetroTextbox30.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox35.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox40.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox45.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox50.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox70.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox69.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox68.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox67.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox66.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox95.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox94.Text = Convert.ToString(0);
                bunifuMetroTextbox49.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox44.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox39.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox34.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox29.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox99.Text = Convert.ToString(rand.Next(1, 20));

                bunifuMetroTextbox65.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox64.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox63.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox62.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox61.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox90.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox89.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox88.Text = Convert.ToString(0);
                bunifuMetroTextbox93.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox98.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox28.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox33.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox38.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox43.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox48.Text = Convert.ToString(rand.Next(1, 20));
            }

            else if (n == 9)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox25.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox24.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox23.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox22.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox21.Text = Convert.ToString(0);
                bunifuMetroTextbox5.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox6.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox11.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox16.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox75.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox74.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox73.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox72.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox71.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox100.Text = Convert.ToString(0);
                bunifuMetroTextbox30.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox35.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox40.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox45.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox50.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox70.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox69.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox68.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox67.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox66.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox95.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox94.Text = Convert.ToString(0);
                bunifuMetroTextbox49.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox44.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox39.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox34.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox29.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox99.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox65.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox64.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox63.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox62.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox61.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox90.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox89.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox88.Text = Convert.ToString(0);
                bunifuMetroTextbox93.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox98.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox28.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox33.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox38.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox43.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox48.Text = Convert.ToString(rand.Next(1, 20));

                bunifuMetroTextbox60.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox59.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox58.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox57.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox56.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox85.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox84.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox83.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox82.Text = Convert.ToString(0);
                bunifuMetroTextbox87.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox92.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox97.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox27.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox32.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox37.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox42.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox47.Text = Convert.ToString(rand.Next(1, 20));

            }

            else if (n == 10)
            {
                bunifuMetroTextbox1.Text = Convert.ToString(0);
                bunifuMetroTextbox2.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox3.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox10.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox9.Text = Convert.ToString(0);
                bunifuMetroTextbox8.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox15.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox14.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox13.Text = Convert.ToString(0);
                bunifuMetroTextbox20.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox19.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox18.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox17.Text = Convert.ToString(0);
                bunifuMetroTextbox4.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox7.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox12.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox25.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox24.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox23.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox22.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox21.Text = Convert.ToString(0);
                bunifuMetroTextbox5.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox6.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox11.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox16.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox75.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox74.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox73.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox72.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox71.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox100.Text = Convert.ToString(0);
                bunifuMetroTextbox30.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox35.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox40.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox45.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox50.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox70.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox69.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox68.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox67.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox66.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox95.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox94.Text = Convert.ToString(0);
                bunifuMetroTextbox49.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox44.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox39.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox34.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox29.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox99.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox65.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox64.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox63.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox62.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox61.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox90.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox89.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox88.Text = Convert.ToString(0);
                bunifuMetroTextbox93.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox98.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox28.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox33.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox38.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox43.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox48.Text = Convert.ToString(rand.Next(1, 20));

                bunifuMetroTextbox60.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox59.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox58.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox57.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox56.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox85.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox84.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox83.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox82.Text = Convert.ToString(0);
                bunifuMetroTextbox87.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox92.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox97.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox27.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox32.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox37.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox42.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox47.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox55.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox54.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox53.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox52.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox51.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox80.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox79.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox78.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox77.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox76.Text = Convert.ToString(0);
                bunifuMetroTextbox81.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox86.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox91.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox96.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox26.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox31.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox36.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox41.Text = Convert.ToString(rand.Next(1, 20));
                bunifuMetroTextbox46.Text = Convert.ToString(rand.Next(1, 20));

            }
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(cities_label.Text);
            generateValues(n);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "input.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.Write("Кількість міст: " + Solution.n);
                writer.WriteLine(); writer.WriteLine(); writer.WriteLine();
                writer.Write("Матриця вартості шляхів: ");
                writer.WriteLine();
                for (int i = 0; i < Solution.n; i++)
                {
                    for (int j = 0; j < Solution.n; j++)
                    {
                        writer.Write(Solution.adjMatrix[i, j].ToString() + " ");
                    }
                    writer.WriteLine();
                }
                writer.WriteLine(); writer.WriteLine(); writer.WriteLine();
                writer.Write("Мінімальний шлях: "); writer.Write(minWeight);
                writer.WriteLine();
                writer.Write("Маршрут: ");
                for (int i = 0; i < Solution.n; i++)
                {
                    if (i == Solution.n - 1)
                        writer.Write(minCycle[i] + 1 + " -> 1");
                    else
                        writer.Write(minCycle[i] + 1 + " -> ");
                }
                writer.WriteLine();
                writer.Dispose();
                writer.Close();
            }
        }

    }
}
