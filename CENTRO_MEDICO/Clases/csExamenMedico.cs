using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csExamenMedico
    {
        #region Atributos
        public int Identificador_Examen { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }

        #endregion

        #region Contructores
        public csExamenMedico()
        {

        }

        public csExamenMedico(int pIdentificador_Examen, string pNombre, string pDescripción)
        {
            this.Identificador_Examen = pIdentificador_Examen;
            this.Nombre = pNombre;
            this.Descripción = pDescripción;

        }
        #endregion

        #region Métodos y Funciones

        public void InsertExamenMedico()
        {

        }

        public void DeleteExamenMedico()
        {

        }

        public void UpdateExamenMedico()
        {

        }
        #endregion

    }
}