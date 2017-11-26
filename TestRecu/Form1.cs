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
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;
        Sanatorio sanatorio;

        public Form1()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
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
            StringBuilder buildFinAtencion = new StringBuilder();
            buildFinAtencion.AppendFormat("Finalizó la atención de {0} por {1}!", p.ToString(), m.ToString());
            m.FinalizarAtencion();
            MessageBox.Show(buildFinAtencion.ToString());
        }
        private void MockPaciente()
        {
            Random numRan = new Random();
            numRan.Next(1, 10000);
            string nombre = "Paciente" + numRan;
            Paciente p = new Paciente(nombre, "Apellido");
            this.pacientesEnEspera.Enqueue(p);
            Thread.Sleep(5000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.mocker = new Thread()
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mocker.IsAlive)
                this.mocker.Abort();
        }
    }
}
