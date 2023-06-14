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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new SoundPlayer();
        public Form2()
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
            DialogResult d=MessageBox.Show("Are you sure you want to go back to the main menu?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if(d == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Location = this.Location;
                f1.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Location = this.Location;
            f3.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Location = this.Location;
            f4.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Location = this.Location;
            f5.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Location = this.Location;
            f6.Show();
            //Hide();
        }
    }
}
