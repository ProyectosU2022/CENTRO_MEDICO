using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csEquipoMedico
    {
        #region Atributos
        public int Identificador_Equipo_Medico { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }

        #endregion

        #region Contructores
        public csEquipoMedico()
        {

        }

        public csEquipoMedico(int pIdentificador_Equipo_Medico, string pNombre, string pDescripción)
        {
            this.Identificador_Equipo_Medico = pIdentificador_Equipo_Medico;
            this.Nombre = pNombre;
            this.Descripción = pDescripción;

        }
        #endregion

        #region Métodos y Funciones

        public void InsertEquipoMedico()
        {

        }

        public void DeleteEquipo_medico()
        {

        }

        public void UpdateEquipo_Medico()
        {

        }
        #endregion

    }
}