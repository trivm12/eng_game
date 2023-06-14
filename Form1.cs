using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace English_game
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            this.player.SoundLocation = @"theme.wav";
            this.player.Play();
            this.player.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Location = this.Location;
            f2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Location = this.Location;
            f7.Show();
            Hide();
        }
    }


    
}
