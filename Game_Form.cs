using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Game_project
{
    public partial class Game_Form : Form
    {
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
            btn_Spin.Enabled = true;
            btn_Load.Enabled = false;

            //code to display image in picture box on button click   

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_project.Resources.Cricket.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            Image_showBox.Image = bmp_Object;
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
        }
    }
}
