using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csEspecialidadMedica
    {
        #region Atributos
        public int Identificador_Especialidad { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }

        #endregion

        #region Contructores
        public csEspecialidadMedica()
        {

        }

        public csEspecialidadMedica(int pIdentificador_Especialidad, string pNombre, string pDescripción)
        {
            this.Identificador_Especialidad = pIdentificador_Especialidad;
            this.Nombre = pNombre;
            this.Descripción = pDescripción;

        }
        #endregion

        #region Métodos y Funciones

        public void InsertEspecialidadMedica()
        {

        }

        public void DeleteEspecialidadMedica()
        {

        }

        public void UpdateEspecialidadMedica()
        {

        }
        #endregion

    }
}