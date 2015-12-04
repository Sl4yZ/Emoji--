using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookEmojis
{
    public partial class SmileyList : MetroFramework.Forms.MetroForm
    {
        public static Announce announce;
        bool hidden = false;
        public SmileyList()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckUpdate();
        }
        private void CheckUpdate()
        {
            
            string localVersion = File.ReadAllText("version.emo");
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("http://www.emojiplusplus.altervista.org/version.emo");

            string webData = System.Text.Encoding.UTF8.GetString(raw);
            if (webData != localVersion)
            {
                MessageBox.Show("A new version is available, the update will only take a few seconds");
                Process.Start("updater.exe");
                Application.Exit();
            }
        }
        public int CountEmojis()
        {

            int fCount = Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\res\\", "*", SearchOption.TopDirectoryOnly).Length;

            return fCount;

        }
        private void z(string Text)
        {
            Clipboard.SetText(Text);
            routine();
        }
        public void routine()
        {
            announce = new Announce();
            announce.Show(this);
            
            announce.TopMost = true;
            announce.FadeEffects();

            }
        private void MainUI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
            else
            {

            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            z(" :P "); 
        }

        private void pictureBox180_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            z(" :) ");
        }
        
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            z(" 😃 ");
        }

        private void MainUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void MainUI_KeyDown(object sender, KeyEventArgs e)
        {
         /*   if (e.KeyCode == Keys.F12)
            {
               // MessageBox.Show("F12");
                if (hidden == false)
                {
                    this.WindowState = FormWindowState.Minimized;
                    hidden = true;
                }
                else if (hidden == true)
                {
                    this.WindowState = FormWindowState.Normal;
                    hidden = false;
                }
                
            }
            */
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            z(" =D ");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            z(" :o ");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            z(" ;) "); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            z(" :v ");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            z(" >:( ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            z(" :( ");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            z(" :/ ");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            z(" :'( ");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            z(" ^_^ ");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            z(" 8-) ");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            z(" B| ");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            z("❤");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            z(" 3:) ");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            z(" O:) ");
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            z(" -_- ");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            z(" o.O ");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            z(" O.o ");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            z(" >:o ");
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            z(" :* ");
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            z("☺");
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            z("😔");
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            z("😢");
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            z("😽");
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            z("😁");
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            z("😍");
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            z("😂");
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            z("😷");
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            z("😵");
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            z("😳");
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            z("😲");
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            z("😱");
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            z("😰");
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            z("😭");
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            z("😪");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            z("😨");
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            z("😥");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            z("😡");
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            z("😚");
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            z("😘");
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            z("😖");
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            z("😒");
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            z("😏");
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            z("😌");
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            z("😊");
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            z("💑");
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            z("💃");
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            z("💂");
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            z("💀");
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            z("👿");
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            z("👾");
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            z("👽");
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            z("👼");
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            z("👻");
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            z("👷");
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            z("👶");
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            z("👵");
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            z("👴");
        }

        private void pictureBox125_Click(object sender, EventArgs e)
        {
            z("👯");
        }

        private void pictureBox124_Click(object sender, EventArgs e)
        {
            z("👮");
        }

        private void pictureBox123_Click(object sender, EventArgs e)
        {
            z("👩");
        }

        private void pictureBox122_Click(object sender, EventArgs e)
        {
            z("👨");
        }

        private void pictureBox121_Click(object sender, EventArgs e)
        {
            z("👧");
        }

        private void pictureBox119_Click(object sender, EventArgs e)
        {
            z("👦");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            z(" :3 ");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            z("👍");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            z(" :poop: ");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            z("😠");
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            z("😝");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            z("😜");
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            z("👳");
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            z("👲");
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            z("👱");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SmileyList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }


        

       
       
    }
}
