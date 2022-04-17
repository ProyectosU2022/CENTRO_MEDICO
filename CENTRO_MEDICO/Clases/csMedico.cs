using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csMedico
    {
        #region Atributos
        public int Identificador_Medico { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Nombre_completo { get; set; }
        public string Telefono_Principal { get; set; }
        public string Telefono_Secundario { get; set; }
        public string Email { get; set; }
        public string Carnet_Colegio_Respectivo { get; set; }
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public int Distrito { get; set; }
        public string Direccion_Fisica { get; set; }
        public int Identificador_Especialidad { get; set; }
        public int Identificador_Horario{ get; set; }

        #endregion

        #region Contructores
        public csMedico()
        {

        }

        public csMedico(int pIdentificador_Medico, string pCedula, string pGenero, DateTime pFecha_Nacimiento, string pNombre, string pTelefono_Principal, string pTelefono_Secundario, string pEmail, string Carnet_Colegio_Respectivo, int pProvincia, int pCanton, int pDistrito, string pDireccion_Fisica, int Identificador_Especialidad, int Identificador_Horario)
        {
            this.Identificador_Medico = pIdentificador_Medico;
            this.Cedula = pCedula;
            this.Genero = pGenero;
            this.Fecha_Nacimiento = pFecha_Nacimiento;
            this.Nombre_completo = pNombre;
            this.Telefono_Principal = pTelefono_Principal;
            this.Telefono_Secundario = pTelefono_Secundario;
            this.Email = pEmail;
            this.Carnet_Colegio_Respectivo = Carnet_Colegio_Respectivo;
            this.Provincia = pProvincia;
            this.Canton = pCanton;
            this.Distrito = pDistrito;
            this.Direccion_Fisica = pDireccion_Fisica;
            this.Identificador_Especialidad = Identificador_Especialidad;
            this.Identificador_Horario = Identificador_Horario;
        }
        #endregion


        #region Métodos y Funciones

        public void InsertMedico()
        {

        }

        public void DeleteMedico()
        {

        }

        public void UpdateMedico()
        {

        }
        #endregion

    }
}


