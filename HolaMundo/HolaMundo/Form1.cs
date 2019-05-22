using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        long recibe = 0;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnllamar_Click(object sender, EventArgs e)
        {
            Tareas t = new Tareas();
            recibe= t.Sumar();
            lblprimer.Text = recibe.ToString();
        }

        private void Btnejecutar_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            lblsegundo.Text = cont.ToString();
        }
    }
}
