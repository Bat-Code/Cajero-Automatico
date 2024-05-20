using System.Security;

namespace CajeroAutomatico;

public class Cajero
{
    public int autenticacionInformacion(List<CuentaBancaria> cuentaBancarias)
    {
        Boolean cicloAutenticacion = true;
        int cuentaIndex = -1;
        //Inicio del Cajero
        Console.WriteLine("Bienvenido al Cajero Automatico");

        while (cicloAutenticacion)
        {
            try
            {
                Console.WriteLine("Por favor ingrese su numero de cuenta:");
                String numeroCuenta = Console.ReadLine();
                
                //Validamos que el numero de cuenta sea de 8 digitos y sea un numero
                if (numeroCuenta.Length != 8 || !long.TryParse(numeroCuenta, out _))
                {
                    throw new InvalidLengthNumberException();
                }
                // Solicitud de contraseña
                Console.WriteLine("Por favor ingrese su contraseña:");
                String password = Console.ReadLine();
                
                // Validacion de datos y certificacion del index
                for (int i = 0; i < cuentaBancarias.Count; i++)
                {
                    if (cuentaBancarias[i].getNumeroCuenta().Equals(numeroCuenta) && cuentaBancarias[i].getPassword().Equals(password))
                    {
                        Console.WriteLine("Funciono");
                        cicloAutenticacion = false;
                        cuentaIndex = i;
                        break;
                    }
                }
                // Se utiliza el if para que en el caso que la cuenta y contraseña sean incorrecta vote un error.
                if (cicloAutenticacion)
                {
                    throw new InvalidLengthNumberException("El numero de cuenta o contraseña son incorrectos.");
                }
                
            } catch (InvalidLengthNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        return cuentaIndex;
    }

    public void cantidadRetiro(CuentaBancaria cuenta)
    {
        Boolean cicloCantidad = true;

        try
        {
            if (cuenta.cantidadRetirada >= 2000000)
            {
                throw new Exception("Ha superado el limite de retiro diario de 2.000.000. Por favor intente mañana.");
            }

            while (cicloCantidad)
            {
                try
                {
                    Console.WriteLine("Por favor ingrese la cantidad a retirar:");
                    int cantidad = int.Parse(Console.ReadLine());
                    // verificar si la cantidad es mayor al saldo

                    if (cuenta.cantidadRetirada + cantidad > 2000000)
                    {
                        cicloCantidad = false;
                        throw new Exception(
                            "El retiro solicitado sobrepasa el limite diario de 2.000.000. Por favor intente con una cantidad menor.");
                    }

                    if (cantidad <= cuenta.getSaldo() && cantidad <= 2000000)
                    {
                        Console.WriteLine("\nQuerido usauario, su retiro ha sido exitoso.");
                        Console.WriteLine("Cantidad retirada es de: " + cantidad);
                        Console.WriteLine("Fecha y hora del retiro: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        cuenta.cantidadRetirada += cantidad;
                        cuenta.setSaldo(cuenta.getSaldo() - cantidad);
                        cicloCantidad = false;
                        break;
                    }

                    throw new Exception("No tiene suficiente saldo para realizar esta transaccion.");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}