using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csTipoMedicamento
    {
        #region Atributos
        public int Identificador_TipoMedicamento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        #endregion

        #region Contructores
        public csTipoMedicamento()
        {

        }

        public csTipoMedicamento(int pIdentificador_TipoMedicamento, string pNombre, string pDescripcion)
        {
            this.Identificador_TipoMedicamento = pIdentificador_TipoMedicamento;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;


        }
        #endregion

        #region Métodos y Funciones

        public void InsertTipoMedicamento()
        {

        }

        public void DeleteTipoMedicamento()
        {

        }

        public void UpdateTipoMedicamento()
        {

        }
        #endregion

    }
}