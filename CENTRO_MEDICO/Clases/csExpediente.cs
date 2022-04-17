using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csExpediente
    {
        #region Atributos
        public int Identificador_Expediente { get; set; }
        public int  Identificador_Cliente{ get; set; }
        
        #endregion

        #region Contructores
        public csExpediente()
        {

        }

        public csExpediente(int pIdentificador_Expediente, int pIdentificador_Cliente)
        {
            this.Identificador_Expediente= pIdentificador_Expediente;
            this.Identificador_Cliente = pIdentificador_Cliente;
            

        }
        #endregion

        #region Métodos y Funciones

        public void InsertExpediente()
        {

        }

        public void DeleteExpediente()
        {

        }

        public void UpdateExpediente()
        {

        }
        #endregion

    }
}