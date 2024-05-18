using System.Runtime.InteropServices.JavaScript;

namespace CajeroAutomatico;

public class CuentaBancaria
{
    private String nombreTitular;
    private String emailTitular;
    private float Saldo;
    private String numeroCuenta;
    private int puntosColombia;
    private Boolean limite = true;
    private String password;
    
    private int calculoPuntosColombia()
    {
        int puntos = (int)(this.Saldo / 7);
        return puntos;
    }

    public CuentaBancaria(String nombreTitular, String emailTitular, float saldo, String numeroCuenta, String password)
    {
        this.nombreTitular = nombreTitular;
        this.emailTitular = emailTitular;
        this.Saldo = saldo;
        this.numeroCuenta = numeroCuenta;
        this.puntosColombia = calculoPuntosColombia();
        this.password = password;
    }


    public String getNumeroCuenta()
    {
        return this.numeroCuenta;
    }

    public String getPassword()
    {
        return this.password;
    }

    public String getNombreTitular()
    {
        return this.nombreTitular;
    }
}