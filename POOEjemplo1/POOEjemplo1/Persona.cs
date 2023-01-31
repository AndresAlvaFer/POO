using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEjemplo1
{
    internal class Persona
    {
        #region Atributos
        
        private String nombre, apellido;

        #endregion

        #region Sobrecarga y sobreescritura

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
        }

        public Persona(String pNom)
        {
            this.nombre = pNom;
        }

        public Persona(String pNom, String pApe)
        {
            this.nombre = pNom;
            this.apellido = pApe;
        }

        #endregion

        #region Metodos

        public String Nombre
        {

            set { nombre = value.ToUpper(); }
            get { return nombre; }
        }

        public String Apellido
        {

            set { apellido = value.ToUpper(); }
            get { return apellido; }
        }

        #endregion
    }
}
