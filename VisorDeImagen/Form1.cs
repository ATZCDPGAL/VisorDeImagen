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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); /*Cerrar el form*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true; /*Marcar que el link fue visto*/
            System.Diagnostics.Process.Start("Calc");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true; /*Marcar que el link fue visto*/
            System.Diagnostics.Process.Start("IExplore", "http://www.ucol.mx");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true; /*Marcar que el link fue visto*/
            System.Diagnostics.Process.Start("C:\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image;
            }
        }
    }
}
