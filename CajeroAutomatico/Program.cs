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

        funcionesCajero.autenticacionInformacion(cuentas);
    }
}
