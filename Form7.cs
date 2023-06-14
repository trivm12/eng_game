using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_game
{
    public partial class Form7 : Form
    {
        string[] ans_fruit =
                        {
                            "apple",
                            "banana",
                            "cherry",
                            "dragon fruit",
                            "mango",
                            "orange",
                            "papaya",
                            "pineapple",
                            "grape",
                            "strawberry",
                        };
        string[] trans_fruit =
                        {
                            "táo",
                            "chuối",
                            "anh đào",
                            "thanh long",
                            "xoài",
                            "cam",
                            "đu đủ",
                            "dứa",
                            "nho",
                            "dâu",
                        };
        string[] ans_vehi =
                        {
                            "ambulance",
                            "truck",
                            "bicycle",
                            "motorbike",
                            "car",
                            "forklift",
                            "train",
                            "firetruck",
                            "plane",
                            "excavator",
                        };
        string[] trans_vehi =
                        {
                            "xe cấp cứu",
                            "xe tải",
                            "xe đạp",
                            "xe gắn máy",
                            "xe hơi",
                            "xe nâng",
                            "tàu hoả",
                            "xe chữa cháy",
                            "máy bay",
                            "xe xúc đất",
                        };
        string[] ans_ani =
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
        string[] trans_ani =
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
        string[] lib_fr, lib_ani, lib_vehi;


        System.Media.SoundPlayer player = new SoundPlayer();
        public Form7()
        {
            InitializeComponent();
            this.player.SoundLocation = @"theme.wav";
            this.player.Play();
            this.player.PlayLooping();
        }

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
            Form1 f1 = new Form1();
            f1.Location = this.Location;
            f1.Show();
            Hide();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            lib_fr = new string[ans_fruit.Length];
            lib_vehi = new string[ans_vehi.Length];
            lib_ani = new string[ans_ani.Length];
            for (int i = 0; i < ans_fruit.Length; i++)
            {
                if (ans_fruit[i].Length >= 18)
                    lib_fr[i] = ans_fruit[i].ToString() + "\t" + trans_fruit[i];
                else if (ans_fruit[i].Length >= 10)
                    lib_fr[i] = ans_fruit[i].ToString() + "\t\t" + trans_fruit[i];
                else
                    lib_fr[i] = ans_fruit[i].ToString() + "\t\t\t" + trans_fruit[i];
            }
            lib_vehi[0] = ans_vehi[0].ToString() + "\t\t" + trans_vehi[0];
            for (int i = 1; i < ans_vehi.Length; i++)
            {
                if (ans_vehi[i].Length >= 18)
                    lib_vehi[i] = ans_vehi[i].ToString() + "\t" + trans_vehi[i];
                else if (ans_vehi[i].Length >= 11)
                    lib_vehi[i] = ans_vehi[i].ToString() + "\t\t" + trans_vehi[i];
                else
                    lib_vehi[i] = ans_vehi[i].ToString() + "\t\t\t" + trans_vehi[i];
            }
            for (int i = 0; i < ans_ani.Length; i++)
            {
                if (ans_ani[i].Length >= 18)
                    lib_ani[i] = ans_ani[i].ToString() + "\t" + trans_ani[i];
                else if (ans_ani[i].Length >= 11)
                    lib_ani[i] = ans_ani[i].ToString() + "\t\t" + trans_ani[i];
                else
                    lib_ani[i] = ans_ani[i].ToString() + "\t\t\t" + trans_ani[i];
            }
            textBox1.Text = string.Join(Environment.NewLine, lib_fr.Select(array => array));
            textBox2.Text = string.Join(Environment.NewLine, lib_vehi.Select(array => array));
            textBox3.Text = string.Join(Environment.NewLine, lib_ani.Select(array => array));
        }
    }
}
