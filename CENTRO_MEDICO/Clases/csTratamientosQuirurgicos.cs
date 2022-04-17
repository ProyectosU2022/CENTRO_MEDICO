using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csTratamientosQuirurgicos
    {
        #region Atributos
        public int Identificador_Tratamiento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        #endregion

        #region Contructores
        public csTratamientosQuirurgicos()
        {

        }

        public csTratamientosQuirurgicos(int pIdentificador_Tratamiento, string pNombre, string pDescripcion)
        {
            this.Identificador_Tratamiento = pIdentificador_Tratamiento;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;


        }
        #endregion

        #region Métodos y Funciones

        public void InsertcsTratamientosQuirurgicos()
        {

        }

        public void DeletecsTratamientosQuirurgicos()
        {

        }

        public void UpdatecsTratamientosQuirurgicos()
        {

        }
        #endregion

    }
}