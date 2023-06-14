using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace English_game
{
    public partial class Form5 : Form
    {
        System.Media.SoundPlayer player = new SoundPlayer();
        public Form5()
        {
            InitializeComponent();
            this.player.SoundLocation = @"theme.wav";
            this.player.Play();
            this.player.PlayLooping();
        }
        string[] ds;
        int index;
        int[] used;
        int usedId = -1;
        string[] ans =
                        {
                            "butterfly",
                            "cat",
                            "chicken",
                            "cow",
                            "dog",
                            "elephant",
                            "horse",
                            "sheep",
                            "spider",
                            "squirrel",
                        };
        string[] trans =
                        {
                            "bươm bướm",
                            "mèo",
                            "gà",
                            "bò",
                            "chó",
                            "voi",
                            "ngựa",
                            "cừu",
                            "nhện",
                            "sóc",
                        };
        int diem = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            this.player.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            this.player.Play();
            this.player.PlayLooping();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to go back to the main menu?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Location = this.Location;
                f1.Show();
                Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to go back to choosing topic?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.Yes)
            {
                Form2 f2 = new Form2();
                f2.Location = this.Location;
                f2.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usedId == used.Length - 1)
            {
                MessageBox.Show("You have reach the end.", "The end!");
            }
            else
            {
                bool f;
                do
                {
                    Random rd = new Random();
                    index = rd.Next(0, ds.Length);

                    f = true;
                    for (int i = 0; i <= usedId; i++)
                    {
                        if (used[i] == index)
                        {
                            f = false;
                            break;
                        }
                    }

                    if (f)
                    {
                        pictureBox5.BackgroundImage = Image.FromFile(ds[index]);
                        pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;

                        used[usedId] = index;
                        usedId++;
                    }
                }
                while (f == false);
                button2.Enabled = true;
                textBox1.Clear();
            }
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            ds = new string[10];
            //Doc anh
            for (int i = 1; i <= ds.Length; i++)
                ds[i - 1] = "animal/" + i + ".jpg";

            used = new int[ds.Length];
            //ans = new string[ds.Length]; //o day
            Random rd = new Random();
            index = rd.Next(0, ds.Length);

            //diem = 0;
            //name = "unknown";

            usedId = 0;
            used[usedId] = index;
            usedId++;

            pictureBox5.BackgroundImage = Image.FromFile(ds[index]);
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ans[index])
            {
                MessageBox.Show("Congrat!");
                diem += 10;
                button2.Enabled = false;
                label1.Text = "Score:" + diem.ToString();
            }
            else
            {
                MessageBox.Show("Wrong answer. :(");
            }
        }
    }

}
