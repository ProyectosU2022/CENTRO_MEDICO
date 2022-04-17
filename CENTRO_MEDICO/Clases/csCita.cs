using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csCita
    {
        #region Atributos
        public int Identificador_Cita { get; set; }
        public int Identificador_Doctor{ get; set; }
        public int Identificador_Cliente{ get; set; }
        public int Identificador_Especialidad { get; set; }
        public DateTime Fecha_Hora_Cita { get; set; }
        public string Observaciones { get; set; }
        public string Estado_Cita { get; set; }
        #endregion

        #region Contructores
        public csCita()
        {

        }

        public csCita(int pIdentificador_Cita, int pIdentificador_Doctor, int pIdentificador_Cliente, int pIdentificador_Especialidad, DateTime pFecha_Hora_Cita, string pObservaciones, string pEstado_Cita)
        {
            this.Identificador_Cita = pIdentificador_Cita;
            this.Identificador_Doctor = pIdentificador_Doctor;
            this.Identificador_Cliente = pIdentificador_Cliente;
            this.Identificador_Especialidad = pIdentificador_Especialidad;
            this.Fecha_Hora_Cita = pFecha_Hora_Cita;
            this.Observaciones = pObservaciones;
            this.Estado_Cita = pEstado_Cita;
            
        }
        #endregion

        #region Métodos y Funciones

        public void InsertCita()
        {

        }

        public void DeleteCita()
        {

        }

        public void UpdateCita()
        {

        }
        #endregion

    }
}