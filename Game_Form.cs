using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Game_project
{
    public partial class Game_Form : Form
    {
        Game_Logic Obj_Logic = new Game_Logic();
        public Game_Form()
        {
            InitializeComponent();
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }

        private void btn_PlayAgain_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void btn_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Load_Click(object sender, System.EventArgs e)
        {
            btn_Spin.Enabled = true; // this code enables the spin button
            btn_Load.Enabled = false; // disable the load button

            //code to display image in picture box on button click   

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_project.Resources.Cricket.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            Image_showBox.Image = bmp_Object;

            //code to play an audio on button click
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_project.Properties.Resources.gun);
            Sound_Object.Play();

            //Load logic
            Obj_Logic.Hammer_Position = 1;
        }

        private void btn_Spin_Click(object sender, System.EventArgs e)
        {
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            btn_Spin.Enabled = false;

            //code to display image in picture box on button click   

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_project.Resources.Football.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            Image_showBox.Image = bmp_Object;

            //code to play an audio on button click
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_project.Properties.Resources.spinnn);
            Sound_Object.Play();

            //spin the bullet
            Random Obj_random = new Random();
            Obj_Logic.Bullet_Position = Obj_random.Next(1, 7);
            MessageBox.Show("Bullet position " + Obj_Logic.Bullet_Position);
        }

        private void btn_rules_Click(object sender, System.EventArgs e)
        {
            Instuction_Form Obj_inst = new Instuction_Form();
            Obj_inst.Show();
        }

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            Obj_Logic.Fire_on_Head = Obj_Logic.shoot();
            if (Obj_Logic.Fire_on_Head == 1)
            {

                MessageBox.Show("Sorry, you are dead now");



            }
            else
            {
                MessageBox.Show("Empty Shot");


            }
        }
    }
}
