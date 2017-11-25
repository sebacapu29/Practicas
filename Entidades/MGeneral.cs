using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class MGeneral : Medico,IMedico
    {

        public MGeneral(string nombre, string apellido):base(nombre,apellido)
        {

        }
        public void IniciarAtencion(Paciente p)
        {
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }

        protected override void Atender()
        {
            tiempoAleatorio.Next(1500,2200);
            Thread.Sleep(Convert.ToInt32(tiempoAleatorio));
            MessageBox.Show("La atención ha Finalizado");

            using (StreamWriter swAtencion = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "pacientes_atendidos.txt",true))
            {
                swAtencion.Write(this.EstaAtendiendoA);
            }
        }
    }
}
