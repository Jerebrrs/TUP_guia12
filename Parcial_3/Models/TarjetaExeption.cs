

namespace Parcial_3.Models
{
    internal class TarjetaExeption : ApplicationException
    {
        public TarjetaExeption(): base("Error en el numero de Tarjeta.") { }
        public TarjetaExeption(string msg) : base(msg) { }
        public TarjetaExeption(string msg,Exception ex) : base(msg,ex) { }
    }
}
