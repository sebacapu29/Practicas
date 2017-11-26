using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico:Persona
    {
        private Paciente pacienteActual;
        protected Random tiempoAleatorio;
        private delegate void FinAtencionPaciente(object sender, EventArgs e);
        private event FinAtencionPaciente AtencionFinalizada;

        static Medico()
        {

        }
        public Medico(string nombre, string apellido):base(nombre,apellido)
        {

        }
        public Paciente AtenderA
        {
            set {  this.pacienteActual=value; }
        }
        public virtual string EstaAtendiendoA
        {
            get { return this.pacienteActual.ToString(); }
        }
        protected abstract void Atender();

        public void FinalizarAtencion()
        {
            this.AtencionFinalizada(this, new EventArgs());
            this.pacienteActual = null;

        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
