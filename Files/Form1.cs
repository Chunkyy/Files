﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing;
using System.Timers;
using System.Speech.Synthesis;

namespace Files
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer aTimer = null;
        public Form1()
        {
            InitializeComponent();
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

            string filepath = openFileDialog1.FileName;

            if (!string.IsNullOrEmpty(filepath))
            {
                tb1.Text = File.ReadAllText(filepath);
            }
            
        }

        public void tb1_TextChanged(object sender, EventArgs e)
        {
        }

        public void pbtn_Click(object sender, EventArgs e)
        {
            string audiofile = pthtb.Text;

            try
            {
                if (!string.IsNullOrEmpty(audiofile))
                {

                    SoundPlayer play = new SoundPlayer(audiofile);

                    play.Play();
                    pbtn.BackColor = Color.Red;
                    pbtn.ForeColor = Color.White;

                    aTimer = new System.Timers.Timer();
                    aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                    aTimer.Interval = 1000;
                    aTimer.Enabled = true;
                    aTimer.Start();
                }
                else
                {
                    MessageBox.Show("No file selected");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found.");
            }
        }

        public void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if (pbtn.BackColor == Color.Red && pbtn.ForeColor == Color.White)
            {
                pbtn.BackColor = SystemColors.ButtonFace;
                pbtn.ForeColor = Color.Black;
            }

            aTimer.Elapsed -= new ElapsedEventHandler(OnTimedEvent);
            aTimer = null;
        }

        public void bwsbtn1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "E:\\Code\\Windows application\\Files";
            openFileDialog1.Filter = "Wav File|*.wav";
            openFileDialog1.Title = "Open Audio File";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK);
            {
                pthtb.Text = openFileDialog1.FileName;
            }
        }

        private void pbtnsp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb1.Text))
            {
                SpeechSynthesizer speak = new SpeechSynthesizer();

                speak.Speak(tb1.Text);
            }
            else
            {
                MessageBox.Show("Field is Empty.");
            }
        }
    }
}
