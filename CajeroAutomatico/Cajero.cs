namespace CajeroAutomatico;

public class Cajero
{
    public Boolean autenticacionInformacion(List<CuentaBancaria> cuentaBancarias)
    {
        Boolean cicloAutenticacion = true;
        //Inicio del Cajero
        Console.WriteLine("Bienvenido al Cajero Automatico");

        while (cicloAutenticacion)
        {
            try
            {
                Console.WriteLine("Por favor ingrese su numero de cuenta:");
                String numeroCuenta = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su contraseña:");
                String password = Console.ReadLine();

                if (numeroCuenta.Length != 8 || !long.TryParse(numeroCuenta, out _))
                {
                    throw new InvalidLengthNumberException();
                }
                foreach (CuentaBancaria cuenta in cuentaBancarias)
                {
                    
                    if (cuenta.getNumeroCuenta().Equals(numeroCuenta) && cuenta.getPassword().Equals(password))
                    {
                        Console.WriteLine("Funciono");
                        cicloAutenticacion = false;
                        break;
                    }
                    throw new InvalidLengthNumberException("El numero de cuenta o contraseña son incorrectos.");
                }
                
            } catch (InvalidLengthNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        return true;
    }
}