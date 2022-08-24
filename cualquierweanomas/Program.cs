using System;
using System.Text.RegularExpressions;

namespace cualquierweanomas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****Bienvenido****");
            Console.WriteLine("Escriba su nombre completo.");
            String nombreUsuario = (Console.ReadLine());
            Console.WriteLine("Indique su rut con punton y guión.");
            String rutUsuario = (Console.ReadLine());
            rutUsuario = string.Join("", rutUsuario.Split('.', '-'));
            string dVerificador = rutUsuario.Substring(rutUsuario.Length - 1, 1);
            if (dVerificador == "k" || dVerificador == "K")
            {
                dVerificador = "0";
            }
            rutUsuario = rutUsuario.Substring(0, rutUsuario.Length - 1);
            int rut = int.Parse(rutUsuario);
            int numero = 2;
            int ultDigito;
            int resultado = 0;
            int division;
            int reMulti;
            int valor;
            int dvFinal;
            int digVer;
            for (int i = 0; i < 8; i++)
            {
                ultDigito = int.Parse(rutUsuario.Substring(rutUsuario.Length - 1, 1));
                rutUsuario = rutUsuario.Substring(0, rutUsuario.Length - 1);
                resultado += ultDigito * numero;
                numero++;
                if (numero == 8)
                {
                    numero = 2;
                }
            }
            division = resultado / 11;
            reMulti = division * 11;
            valor = resultado - reMulti;
            dvFinal = 11 - valor;
            digVer = int.Parse(dVerificador);
            if (dvFinal== digVer)
            {
                Console.WriteLine("El rut ingresado es correcto.");
            }
            else
            {
                Console.WriteLine("El rut ingresado no es válido.");
            }
            Console.WriteLine("Indique su número de teléfono.");
             int telUsuario = int.Parse((Console.ReadLine()));
             Console.WriteLine("Indique su correo electrónico.");
             String correoUsuario = (Console.ReadLine());


             Console.WriteLine("******************************************");
             Console.WriteLine("Los datos ingresados son los siguientes");
             Console.WriteLine("Nombre completo: " + nombreUsuario);
             Console.WriteLine("Rut: " + rut +"-"+ digVer);
             Console.WriteLine("Teléfono: " + telUsuario);
             Console.WriteLine("Correo Electrónico: " + correoUsuario);




        }
    }
}
