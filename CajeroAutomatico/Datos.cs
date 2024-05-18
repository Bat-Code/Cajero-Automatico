namespace CajeroAutomatico;

public class Datos
{
    public List<CuentaBancaria> crearCuentasBancarias()
    {
        List<CuentaBancaria> cuentasGeneradas = new List<CuentaBancaria>();

        CuentaBancaria cuenta1 = new CuentaBancaria("Andres Mejia",
            "amdresmejia@mail.com", 300000, "24591758","2510");
        CuentaBancaria cuenta2 = new CuentaBancaria("Miguel Muñoz",
            "miguelmuñoz@mail.com", 3420000, "59426878","3110");
        CuentaBancaria cuenta3 = new CuentaBancaria("Daniela Andrade",
            "danielaandrade@mail.com", 930000, "18934567", "0511");
        CuentaBancaria cuenta4 = new CuentaBancaria("Leonel Messi",
            "leonelmessi@mail.com", 5400000, "84351261","2301");
        CuentaBancaria cuenta5 = new CuentaBancaria("Antonela Roccuzzo",
            "antonelarocuzzo@mail.com", 2600000, "34568129","2005");
        
        cuentasGeneradas.Add(cuenta1);
        cuentasGeneradas.Add(cuenta2);
        cuentasGeneradas.Add(cuenta3);
        cuentasGeneradas.Add(cuenta4);
        cuentasGeneradas.Add(cuenta5);
        
        return cuentasGeneradas;
    }
    
}