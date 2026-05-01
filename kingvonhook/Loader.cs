using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kingvonhook
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Text = "Waiting For Rocket League...";
            Thread.Sleep(200);
            timer2.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                
                Thread.Sleep(2000);
                timer1.Stop();
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
                
                

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RocketLeague").Length > 0)
            {
                guna2HtmlLabel2.Text = "Rocket League Found, Starting Overlay!";
                timer1.Start();
                timer2.Stop();
            }
            else
            {
                return;
            }
        }

        public static string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string config = Path.Combine(documents + "\\My Games\\Rocket League\\TAGame\\Config\\TASystemSettings.ini");
        public static string appData  =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static void installTextures()
        {

            MessageBox.Show("Config has been backed up, Press OK to replace with Dark Textures");
            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/sincerelyryan/KingVonBot-Plugins/raw/refs/heads/main/TASystemSettings.ini", config);
            MessageBox.Show("Dark Textures Config has been added");
        }



        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RocketLeague").Length > 0)
            {
                MessageBox.Show("Please quit Rocket League before using this");
            }
            else
            {


                if (File.Exists(config))
                {
                    File.Copy(config, config + ".backup", true);
                    installTextures();

                }
                else
                {
                    installTextures();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7SFRgk3yQP");
        }

        
    }
}
