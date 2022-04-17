using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csHorario
    {
        #region Atributos
        public int Identificador_Horario { get; set; }
        public string Descripcion { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string Receso_1 { get; set; }
        public string Receso_2 { get; set; }
        public string Receso_3 { get; set; }
        #endregion

        #region Contructores
        public csHorario()
        {

        }

        public csHorario(int pIdentificador_Horario, string pDescripcion, string pHora_Inicio, string pHora_Fin, string pReceso_1, string pReceso_2, string pReceso_3)
        {
            this.Identificador_Horario = pIdentificador_Horario;
            this.Descripcion = pDescripcion;
            this.Hora_Inicio = pHora_Inicio;
            this.Hora_Fin = pHora_Fin;
            this.Receso_1 = pReceso_1;
            this.Receso_2 = pReceso_2;
            this.Receso_3 = pReceso_3;

        }
        #endregion

        #region Métodos y Funciones

        public void InsertHorario()
        {

        }

        public void DeleteHorario()
        {

        }

        public void Updatehorario()
        {

        }
        #endregion

    }
}