using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Components;
using Gma.System.MouseKeyHook;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;


namespace kingvonhook
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;


        }

        public static class paths // yay super paths
        {
            public static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            public static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            public static string combined = Path.Combine(path + "\\NexPy");
            public static string kingvonpath = Path.Combine(path + "\\ChiefKeef.cc");
            public static string misc = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            public static string misc2 = Path.Combine(misc + "cleaner.cmd");
            public static string bakkesmod = Path.Combine(path + "\\bakkesmod\\bakkesmod\\plugins");
            public static string RevoSDK = Path.Combine(localAppData + "\\RevoSDK");
            

        }


        private IKeyboardEvents _globalHook;

        private void Form1_Load(object sender, EventArgs e)
        {
            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += Globalhook_KeyDown;
        }

        private void Globalhook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                if (guna2Panel2.Visible == true)
                {
                    guna2Panel2.Visible = false;
                    guna2Panel4.Visible = false;
                    guna2Panel5.Visible = false;
                    guna2Panel6.Visible = false;
                    guna2Button1.Visible = false;
                    guna2Button2.Visible = false;
                    guna2Button3.Visible = false;

                }
                else
                {
                    guna2Panel2.Visible = true;
                    guna2Button1.Visible = true;
                    guna2Button2.Visible = true;
                    guna2Button3.Visible = true;
                    if (guna2Button1.Checked == true)
                    {
                        guna2Panel4.Visible = true;
                    }
                    if (guna2Button2.Checked == true)
                    {
                        guna2Panel5.Visible = true;
                    }
                    if (guna2Button3.Checked == true)
                    {
                        guna2Panel6.Visible = true;
                    }
                }

            }

            if (e.KeyCode == Keys.F1)
            {
                if (guna2HtmlLabel12.Text == "Disabled")
                {
                    guna2HtmlLabel12.Text = "Enabled";
                    guna2HtmlLabel12.ForeColor = Color.MediumAquamarine;
                }
                else
                {
                    guna2HtmlLabel12.Text = "Disabled";
                    guna2HtmlLabel12.ForeColor = Color.CornflowerBlue;
                }
            }

            if (e.KeyCode == Keys.F3)
            {


                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }





            }


        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Checked == true)
            {
                guna2Panel4.Visible = true;
            }
            else
            {
                guna2Panel4.Visible = false;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            

        }

        private void guna2CustomCheckBox6_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox6.Checked == true)
            {
                cuiFormHideCaptureScreenshot1.TargetForm = this;
            }
            else
            {
                cuiFormHideCaptureScreenshot1.TargetForm = null;
            } 
                

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // OVERLAY TOGGLING
            if (guna2CustomCheckBox1.Checked == true)
            {
                guna2CustomCheckBox2.Visible = true;
                guna2CustomCheckBox4.Visible = true;
                guna2HtmlLabel6.Visible = true;
                guna2HtmlLabel8.Visible = true;
                guna2Panel3.Visible = true;
                if (guna2CustomCheckBox4.Checked == true)
                {
                    pictureBox4.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = false;
                }
            }
            else
            {
                guna2CustomCheckBox2.Visible = false;
                guna2CustomCheckBox4.Visible = false;
                guna2HtmlLabel6.Visible = false;
                guna2HtmlLabel8.Visible = false;
                guna2Panel3.Visible = false;
                pictureBox4.Visible = false;
            }
            guna2Panel1.Visible = guna2CustomCheckBox3.Checked;


            // OVERLAY ELEMENTS

            if (guna2CustomCheckBox2.Checked == true)
            {
                guna2HtmlLabel11.Visible = true;
                guna2HtmlLabel12.Visible = true;

            }
            else
            {
                guna2HtmlLabel11.Visible = false;
                guna2HtmlLabel12.Visible = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button2.Checked == true)
            {
                guna2Panel5.Visible = true;
            }
            else
            {
                guna2Panel5.Visible = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3.Checked == true)
            {
                guna2Panel6.Visible = true;
            }
            else
            {
                guna2Panel6.Visible = false;
            }
        }

        
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/sincerelyryan/KingVonBot-Plugins/raw/refs/heads/main/clean.cmd", paths.misc2);
            Process.Start(paths.misc2).WaitForExit();
            File.Delete(paths.misc2);
        }
        public static string pluginPath = Path.Combine(paths.bakkesmod + "\\Octane2Fennec.dll");
        private void guna2CustomCheckBox7_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox7.Checked == true)
            {
                if (File.Exists(pluginPath))
                {
                    MessageBox.Show("Plugin is already installed");
                    
                }
                else
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://github.com/sincerelyryan/KingVonBot-Plugins/raw/refs/heads/main/Octane2Fennec.dll", pluginPath);
                }
                

            }
            else
            {
                File.Delete(pluginPath);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("Revo.exe");
        }

         

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://gofile.io/d/WlvVmR"); // libtorch_CUDA
            Process.Start("https://gofile.io/d/KrbzE0"); // libtorch_CPU
             

            

        }

        private void guna2CustomCheckBox5_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox5.Checked == true)
            {
                guna2CustomCheckBox8.Checked = false;
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\RevoSDK\\loader_ui.ini";
                if (File.ReadAllText(filePath).Contains("gui_mode=advanced"))
                {
                    MessageBox.Show("Already advanced GUI");
                }
                if (File.ReadAllText(filePath).Contains("gui_mode=simple"))
                {
                    string user = Environment.UserName;
                    string[] config = { $"dependencies_path=C:\\Users\\{user}\\AppData\\Local\\RevoSDK" +
                $"\ndependencies_path=C:\\Users\\{user}\\AppData\\Local\\RevoSDK\\collision_meshes" +
                $"\nskip_path_setup=1" +
                $"\nskip_color_setup=1" +
                $"\nloader_color1=0.066667,0.066667,0.066667,0.360000" +
                $"\nloader_color2=1.000000,0.280000,0.720000,0.340000" +
                $"\ningame_color1=0.066667,0.066667,0.066667,1.000000" +
                $"\ningame_color2=1.000000,0.280000,0.720000,1.000000"};
                    foreach (string i in config)
                    {
                        File.WriteAllText(filePath, i);
                        File.AppendAllText(filePath, "\ngui_mode=advanced");
                    }
                }
                else
                {
                    File.AppendAllText(filePath, "\ngui_mode=advanced");
                }
            }
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string revoPath = Path.Combine(appData + "\\RevoSDK");

            
            if (Directory.Exists(revoPath))
            {
                if (File.Exists(revoPath + "\\loader_ui.ini"))
                {
                    SetConfig();
                }
                else
                {
                    File.Create(revoPath + "\\loader_ui.ini").Close();
                    SetConfig();

                }
            }
            else
            {
                Directory.CreateDirectory(revoPath);
                if (File.Exists(revoPath + "\\loader_ui.ini"))
                {
                    try
                    {
                        SetConfig();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        File.Create(revoPath + "\\loader_ui.ini").Close();
                        SetConfig();
                    }
                    catch
                    {

                    }
                    

                }
            }
            MessageBox.Show("All Files have been created.");
            
        }

        public static void SetConfig()
        {
            bool writing = true;
            while (writing == true)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\RevoSDK\\loader_ui.ini";
                string user = Environment.UserName;
                string[] config = { $"dependencies_path=C:\\Users\\{user}\\AppData\\Local\\RevoSDK" +
                $"\ndependencies_path=C:\\Users\\{user}\\AppData\\Local\\RevoSDK\\collision_meshes" +
                $"\nskip_path_setup=1" +
                $"\nskip_color_setup=1" +
                $"\nloader_color1=0.066667,0.066667,0.066667,0.360000" +
                $"\nloader_color2=1.000000,0.280000,0.720000,0.340000" +
                $"\ningame_color1=0.066667,0.066667,0.066667,1.000000" +
                $"\ningame_color2=1.000000,0.280000,0.720000,1.000000"};
                foreach (string i in config)
                {
                    File.WriteAllText(filePath, i);
                    writing = false;
                }
                
            }

            
        }

        private void guna2CustomCheckBox8_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox8.Checked == true)
            {
                guna2CustomCheckBox5.Checked = false;
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\RevoSDK\\loader_ui.ini";
                if (File.ReadAllText(filePath).Contains("gui_mode=simple"))
                {
                    MessageBox.Show("Already simple GUI");
                }
                if (File.ReadAllText(filePath).Contains("gui_mode=advanced"))
                {
                    string user = Environment.UserName;
                    string[] config = { $"dependencies_path=C:\\Users\\{user}\\AppData\\Local\\RevoSDK" +
                $"\ndependencies_path=C:\\Users\\{user}\\AppData\\Local\\RevoSDK\\collision_meshes" +
                $"\nskip_path_setup=1" +
                $"\nskip_color_setup=1" +
                $"\nloader_color1=0.066667,0.066667,0.066667,0.360000" +
                $"\nloader_color2=1.000000,0.280000,0.720000,0.340000" +
                $"\ningame_color1=0.066667,0.066667,0.066667,1.000000" +
                $"\ningame_color2=1.000000,0.280000,0.720000,1.000000"};
                    foreach (string i in config)
                    {
                        File.WriteAllText(filePath, i);
                        File.AppendAllText(filePath, "\ngui_mode=simple");
                    }
                }
                else
                {
                    File.AppendAllText(filePath, "\ngui_mode=simple");
                }
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string user = Environment.UserName;
            string collisionPath = $"C:\\Users\\{user}\\AppData\\Local\\RevoSDK\\collision_meshes.zip";
            string RevoSDK = $"C:\\Users\\{user}\\AppData\\Local\\RevoSDK";
            if (Directory.Exists(RevoSDK + "\\collision_meshes"))
            {
                MessageBox.Show("Meshes Already Installed");
            }
            else
            {
                wc.DownloadFile("https://github.com/sincerelyryan/kv.pub-plugins/raw/refs/heads/main/collision_meshes.zip", collisionPath);
                ZipFile.ExtractToDirectory(collisionPath, RevoSDK);
                File.Delete(collisionPath);
                MessageBox.Show("Collision Meshes Installed");
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox9.Checked == true)
            {
                MessageBox.Show("This is a one time thing, if you ever delete the plugin file from bakkesmod, then do this again. Otherwise dont.");
                WebClient wc = new WebClient();
                wc.DownloadFile("https://github.com/sincerelyryan/kv.pub-plugins/raw/refs/heads/main/VonBypass.dll", Path.Combine(paths.bakkesmod + "\\VonBypass.dll"));
                MessageBox.Show($"Installed plugin to {paths.bakkesmod}");
            }
            else
            if (guna2CustomCheckBox10.Checked == true)
            {
                MessageBox.Show("Press Ok to Inject bypass.");
                WebClient wc = new WebClient();
                wc.DownloadFile("https://github.com/sincerelyryan/kv.pub-plugins/raw/refs/heads/main/TNTsTemplate.dll", Path.Combine(paths.RevoSDK + "\\bypass.dll"));
                wc.DownloadFile("https://github.com/sincerelyryan/kv.pub-plugins/raw/refs/heads/main/InjectorChief.bin", Path.Combine(paths.RevoSDK + "\\injector.exe"));
                ProcessStartInfo Injector = new ProcessStartInfo
                {
                    FileName = "injector.exe",
                    UseShellExecute = true,
                    Verb = "runas",
                    WorkingDirectory = paths.RevoSDK
                };
                Process.Start(Injector);

            }
            else
            {
                MessageBox.Show("No Method Selected.");
            }
        }
    }
}
