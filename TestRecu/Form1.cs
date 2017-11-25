using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRecu
{
    public partial class Form1 : Form
    {
        private MEspecialista medicoEspeialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;
        Sanatorio sanatorio;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void AtenderPaciente(IMedico medico)
        {
            if(this.pacientesEnEspera!=null)
            {
                medico.IniciarAtencion(this.pacientesEnEspera.Dequeue());       
            }
                    
                
        }
        public void FinAtencion(Paciente p, Medico m)
        {

        }
        private void MockPaciente()
        {
            Random numRan = new Random();
            numRan.Next(1, 10000);
            string nombre = "Paciente" + numRan;
            Paciente p = new Paciente(nombre, "Apellido");
           
        }
    }
}
