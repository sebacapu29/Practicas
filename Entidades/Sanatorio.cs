using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sanatorio
    {
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private  Queue<Paciente> pacientesEnEspera;
        private int turnosTotales;

        private Sanatorio()
        {
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
        }
        public Sanatorio(int numero)
        {

        }
        //serializa xml
        private static void TomarDatos(Persona p)
        {

        }
        public static Sanatorio operator +(Sanatorio sanatorio, Paciente p)
        {
            sanatorio.pacientesEnEspera.Enqueue(p);
            return sanatorio;
        }
    }
}
