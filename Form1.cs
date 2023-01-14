using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorDeImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {// sirve para seleccionar la imagen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {// cierra el programa
            
            this.Close();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        { // seleccionar el fondo
            
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        
    }

        private void buttonClear_Click(object sender, EventArgs e)
        {// este boton borra la imagen
            
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // este boton sirve para ampliar la imagen 
            
            
      
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
