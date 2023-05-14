namespace Entidades
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string? mensaje) : this(mensaje, null)
        {

        }

        public ParametrosVaciosException(string? mensaje, Exception innerException) 
            : base(mensaje, innerException) 
        { 

        }
        
    }
}