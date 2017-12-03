using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace IceDream
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }
        public static Thread thOpenMM;

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            timer_welcomeForm.Enabled = true;
            timer_welcomeForm.Start();
            pictureBox_welcomeForm.Image = Image.FromFile(IceDream.MainMenuForm.path + "\\welcome_Img.jpg");
            SoundPlayer simpleSound = new SoundPlayer(IceDream.MainMenuForm.path + "\\soundWelcome.wav");
            simpleSound.Play();
        }

        private void timer_welcomeForm_Tick(object sender, EventArgs e)
        {
            timer_welcomeForm.Stop();
            this.Close();
        }
    }
}
