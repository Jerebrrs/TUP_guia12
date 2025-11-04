

namespace Examen_1.Models
{
    public class ExeptionDni : ApplicationException
    {

        public ExeptionDni() : base("El Dni debe ser un numero y menor a 5000000.")
        {

        }
        public ExeptionDni(string str) : base(str)
        {

        }

        public ExeptionDni(string str, Exception ex) : base(str, ex)
        {

        }
    }
}
