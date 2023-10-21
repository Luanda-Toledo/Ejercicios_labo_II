using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Sobreescritos
    {
        protected string miAtributo;

        // Constructor que inicializa miAtributo
        public Sobreescritos()
        {
            miAtributo = "Probar abstractos";
        }

        // Propiedad abstracta de solo lectura
        public abstract string MiPropiedad { get; }

        // Método abstracto
        public abstract string MiMetodo();
    }
}
