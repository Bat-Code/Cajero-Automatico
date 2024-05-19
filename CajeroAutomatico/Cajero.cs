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

    public void menuCajero(CuentaBancaria cuenta)
    {
        Boolean cicloMenu = true;
        while (cicloMenu)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido " + cuenta.getNombreTitular());
            Console.WriteLine("Por favor elija una de las siguiente opciones:");
            Console.WriteLine("1. Consultar Saldo");
            Console.WriteLine("2. Retirar Dinero");
            Console.WriteLine("3. Consultar Puntos Colombia");
            Console.WriteLine("4. Enviar Dinero a otra cuenta");
            Console.WriteLine("5. Salir");
            Console.WriteLine("\nDigite su opcion:");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nSu saldo es de: " + cuenta.getSaldo());
                    Console.WriteLine("Presione cualquier tecla para escoger otra opcion.");
                    Console.ReadKey();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    cicloMenu = false;
                    break;
            }
        }
        
    }
}