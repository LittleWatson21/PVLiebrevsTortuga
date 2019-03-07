using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera_Liebre_y_Tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Liebre L1 = new Liebre(1);
        Tortuga T1 = new Tortuga(2);
        Tortuga T2 = new Tortuga(3);
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void iniciar_Carrera_Click(object sender, EventArgs e)
        {
            do
            {
                L1.avance();
                Carrera.Text = L1.ToString() + Environment.NewLine;
                T1.avance();
                Carrera.Text = T1.ToString() + Environment.NewLine;
                T2.avance();
                Carrera.Text = T2.ToString() + Environment.NewLine;
            }
            while (L1.Posicion <= 100 || T1.Posicion <= 100  || T2.Posicion <= 100);

            if (L1.Posicion > T1.Posicion && L1.Posicion > T2.Posicion)
                Carrera.Text = "La liebre" + L1.numeroCorredor.ToString() + " gano la carrera";
            else if (T1.Posicion > L1.Posicion && T1.Posicion > T2.Posicion)
                Carrera.Text += "La tortuga" + T1.numeroCorredor.ToString() + " gano la carrera";
            else
                Carrera.Text += "La tortuga" + T2.numeroCorredor.ToString() + "gano la carrera";

        }

        private void Carrera_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



