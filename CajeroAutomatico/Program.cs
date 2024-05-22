using CajeroAutomatico;

/**
 * Juan David Ramos Salazar
 * Estudiante de Ingenieria de Sistemas
 * Universidad Nacional Abierta y a Distancia
 */
class Program
{
    static void Main(String[] args)
    {
        // Cargamos la Informacion de los usuarios
        List<CuentaBancaria> cuentas = new Datos().crearCuentasBancarias();
        Cajero funcionesCajero = new Cajero();
        while (true)
        {
            Console.Clear();
            int indexDeCuenta = funcionesCajero.autenticacionInformacion(cuentas);

            Boolean cicloMenu = true;
            while (cicloMenu)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido " + cuentas[indexDeCuenta].getNombreTitular());
                Console.WriteLine("Por favor elija una de las siguiente opciones:");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Retirar Dinero");
                Console.WriteLine("3. Consultar Puntos Colombia");
                Console.WriteLine("4. Enviar Dinero a otra cuenta");
                Console.WriteLine("5. Cerrar Sesion");
                Console.WriteLine("\nDigite su opcion:");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Solicitu de saldo
                        Console.WriteLine("\nSu saldo es de: " + cuentas[indexDeCuenta].getSaldoText());
                        Console.WriteLine("Presione cualquier tecla para escoger otra opcion.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        funcionesCajero.cantidadRetiro(cuentas[indexDeCuenta]);
                        Console.WriteLine("Presione cualquier tecla para escoger otra opcion.");
                        Console.ReadKey();
                        break;
                    case 3: // Soliciutd de puntos Colombia
                        Console.WriteLine("\n Actualmente usted posee " + cuentas[indexDeCuenta].getPuntosColombia() +
                                          " Puntos Colombia");
                        Console.WriteLine("Presione cualquier tecla para escoger otra opcion.");
                        Console.ReadKey();
                        break;
                    case 4: // Traspaso de dinero a otra cuenta
                        Console.Clear();
                        funcionesCajero.trasferirDinero(cuentas, cuentas[indexDeCuenta]);
                        Console.WriteLine("Presione cualquier tecla para escoger otra opcion.");
                        Console.ReadKey();
                        break;
                    case 5: // Cerrar Sesio
                        cicloMenu = false;
                        break;
                }
            }
        }
    }
}