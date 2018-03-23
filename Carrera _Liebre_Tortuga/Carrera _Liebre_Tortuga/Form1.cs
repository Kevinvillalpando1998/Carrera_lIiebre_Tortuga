using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera__Liebre_Tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Liebre liebre;
        Tortuga tortuga;


        private void button1_Click(object sender, EventArgs e)
        {
            txttablero.Clear();
            string Nliebre;
            string Ntortuga;
            Ntortuga = Convert.ToString((txtNtortuga.Text));
            Nliebre = Convert.ToString(txtNliebre.Text);
            liebre = new Liebre(Nliebre);
            tortuga = new Tortuga(Ntortuga);



            while (liebre.Pocision < 80 && tortuga.Pocision < 80)
            {
                liebre.avanzar();
                txttablero.Text += liebre.ToString();
                tortuga.avanzar();
                txttablero.Text += tortuga.ToString();

            }
            if (liebre.Pocision >= 80)
            {
                txttablero.Text += "la liebre gano";
            }
            else if (liebre.Pocision == tortuga.Pocision)
                txttablero.Text += " la carrera esta empatada";
            
            else 
                txttablero.Text += "la tortuga gano ";
            

        }
    }
}
