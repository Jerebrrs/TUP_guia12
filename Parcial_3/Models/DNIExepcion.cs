

namespace Parcial_3.Models
{
    public class DNIExepcion: ApplicationException
    {
        public DNIExepcion():base("Error al cargar el DNI.")
        {
            
        }
        public DNIExepcion(string msg) : base(msg)
        {

        }
        public DNIExepcion(string msg, Exception ex) : base(msg,ex)
        {

        }
    }
}
