using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void stretchCBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (stretchCBox.Checked)
            {
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                imageBox.SizeMode = PictureBoxSizeMode.Normal;
                imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
               
           
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            //First, it calls up a dialogue box, then checks to see if it pulled a valid filename. 
            if(imageFileDialog.ShowDialog() == DialogResult.OK)
            /*At this point, the file is valid, so it tells the pictureBox to load the file attached to
             the file dialog box. 
             */
            {
                imageBox.Load(imageFileDialog.FileName);
                imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            if(backgroundColorPicker.ShowDialog() == DialogResult.OK) 
            {
                imageBox.BackColor = backgroundColorPicker.Color;

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            imageBox.Image = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Chosen Weapon: "+ Convert.ToString(wpnComboBox.SelectedItem);
            Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
            textBox1.Width = size.Width;
            textBox1.Height = size.Height;
        }

        private void levelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Weapon Enhancement: +" + levelNumericUpDown.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(textBox2.Text, textBox2.Font);
            textBox2.Width = size.Width;
            textBox2.Height = size.Height;

        }
    }
}
