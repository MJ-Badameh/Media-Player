using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, musicnames;
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Windows_Player.URL = files[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "AVI Files| *.avi";

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                files = openFileDialog1.FileNames;
                musicnames = openFileDialog1.SafeFileNames;

                for (int i = 0; i < files.Length ; i++)
                {
                    listBox1.Items.Add(musicnames[i]);
                }
            }
        }
    }
}
