using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MusicplayerApp : Form
    {
        public MusicplayerApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to select song
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple files
           ofd.Multiselect = true;


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                files = ofd.SafeFileNames;
                path = ofd.FileNames;
          for (int i = 0; i < files.Length; i++){
                listBoxsongs.Items.Add(files[i]);
               }
            }
        }
        //create Global variable
        string[] path, files;

        private void MusicplayerApp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxsongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsMediaPlayermusic.URL = path[listBoxsongs.SelectedIndex];
        }
    }
}
