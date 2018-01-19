using System;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        }

        private void sabtn1_Click(object sender, EventArgs e)
        {
            //Display a SaveFileDialog so the user can save the Image
            //Assigned to sabtn1
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save an Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, tb1.Text);
            }            
        }

        public void opbtn1_Click(object sender, EventArgs e)
        {
            //Display OpenFileDialog so the user can open a text file
            //Assigned to opbtn1
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "E:\\Code\\";
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();

            tb1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        public void tb1_TextChanged(object sender, EventArgs e)
        {
        }

        public void pbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer play = new SoundPlayer(pthtb.Text);

            play.Play();
            pbtn.BackColor = Color.Red;
        }

        public void bwsbtn1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "E:\\Code\\";
            openFileDialog1.Filter = "Wav File|*.wav";
            openFileDialog1.Title = "Open Audio File";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK);
            {
                pthtb.Text = openFileDialog1.FileName;
            }
        
        }
    }
}
