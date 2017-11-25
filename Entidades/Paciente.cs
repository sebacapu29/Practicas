using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        private static int ultimoTurnoDado;
        private int turno;

        public int Turno
        {
            get { return this.turno; }

        }
        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }
        public Paciente(string nombre, string apellido):base(nombre,apellido)
        {
            this.turno = Paciente.ultimoTurnoDado++;
            
        }
        public Paciente(string nombre, string apellido, int turno):this(nombre,apellido)
        {
            Paciente.ultimoTurnoDado = turno;
        }
        public override string ToString()
        {
            StringBuilder buildPaciente = new StringBuilder();
            buildPaciente.AppendFormat("Turno Nº{ 0}: { 2}, { 1}", this.turno, this.apellido, this.nombre);
            
            return base.ToString();
        }
    }
}
