using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        private Especialidad _especialidad;
        public MEspecialista(string nombre, string apellido, Especialidad especialidad) :base(nombre,apellido)
        {
            this._especialidad = especialidad;
        }
        public void IniciarAtencion(Paciente p)
        {
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }

        protected override void Atender()
        {
            tiempoAleatorio.Next(5000, 10000);
            Thread.Sleep(Convert.ToInt32(tiempoAleatorio));
            MessageBox.Show("La atención ha Finalizado");
        }
        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        };
    }
}
