using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CENTRO_MEDICO.Clases
{
    public class csCliente
    {
        #region Atributos
        public string Identificador { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Nombre_completo { get; set; }
        public string Telefono_principal { get; set; }
        public string Telefono_secundario { get; set; }
        public string Email { get; set; }
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public int Distrito { get; set; }
        public string Direccion_Fisica { get; set; }
        #endregion

        #region Contructores
        public csCliente()
        {

        }

        public csCliente(string pIdentificador, string pCedula, string pGenero, DateTime pFecha_nacimiento, string pNombre, string pTelefono_principal, string pTelefono_secundario, string pEmail, int pProvicia, int pCanton, int pDistrito, string pDireccion )
        {
            this.Identificador = pIdentificador;
            this.Cedula = pCedula;
            this.Genero = pGenero;
            this.Fecha_nacimiento = pFecha_nacimiento;
            this.Nombre_completo = pNombre;
            this.Telefono_principal = pTelefono_principal;
            this.Telefono_secundario = pTelefono_secundario;
            this.Email = pEmail;
            this.Provincia = pProvicia;
            this.Canton = pCanton;
            this.Distrito = pDistrito;
            this.Direccion_Fisica = pDireccion;
        }
        #endregion

        #region Métodos y Funciones

        public void InsertCliente()
        {

        }

        public void DeleteCliente()
        {

        }

        public void UpdateCliente()
        {

        }
        #endregion

    }
}