using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csMedicamento
    {
        #region Atributos
        public int Identificador_Medicamento { get; set; }
        public int Identificador_Tipo_Medicamento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion{ get; set; }
        
        #endregion

        #region Contructores
        public csMedicamento()
        {

        }

        public csMedicamento(int pIdentificador_Medicamento, int pIdentificador_Tipo_Medicamento, string pNombre, string pDescripcion)
        {
            this.Identificador_Medicamento = pIdentificador_Medicamento;
            this.Identificador_Tipo_Medicamento = pIdentificador_Tipo_Medicamento;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            

        }
        #endregion

        #region Métodos y Funciones

        public void InsertMedicamento()
        {

        }

        public void DeleteMedicamento()
        {

        }

        public void UpdateMedicamento()
        {

        }
        #endregion

    }
}