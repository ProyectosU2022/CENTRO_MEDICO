using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csEnfermedades
    {
        #region Atributos
        public int Identificador_Enfermedad { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
       
        #endregion

        #region Contructores
        public csEnfermedades()
        {

        }

        public csEnfermedades(int  pIdentificador_Enfermedad, string pNombre, string pDescripción)
        {
            this.Identificador_Enfermedad = pIdentificador_Enfermedad;
            this.Nombre = pNombre;
            this.Descripción = pDescripción;

        }
        #endregion

        #region Métodos y Funciones

        public void InsertEnfermedades()
        {

        }

        public void DeleteEnfermedades()
        {

        }

        public void UpdateEnfermedades()
        {

        }
        #endregion

    }
}