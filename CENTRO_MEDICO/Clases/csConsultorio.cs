using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csConsultorio
    {
        #region Atributos
        public int Identificador_Consultorio { get; set; }
        public int Numero_Consultorio { get; set; }
        public int Piso_Consultorio { get; set; }
       
        #endregion

        #region Contructores
        public csConsultorio()
        {

        }

        public csConsultorio(int pIdentificador_Consultorio, int pNumero_Consultorio, int pPiso_Consultorio)
        {
            this.Identificador_Consultorio = pIdentificador_Consultorio;
            this.Numero_Consultorio = pNumero_Consultorio;
            this.Piso_Consultorio = pPiso_Consultorio;
            

        }
        #endregion

        #region Métodos y Funciones

        public void InsertConsultorio()
        {

        }

        public void DeleteConsultorio()
        {

        }

        public void UpdateConsultorio()
        {

        }
        #endregion

    }
}