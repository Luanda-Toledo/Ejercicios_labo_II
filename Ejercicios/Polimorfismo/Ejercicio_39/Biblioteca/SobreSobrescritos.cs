namespace Biblioteca
{
    public class SobreSobrescritos : Sobreescritos
    {
        // Implementación de la propiedad abstracta
        public override string MiPropiedad
        {
            get { return miAtributo; }
        }

        // Implementación del método abstracto
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}