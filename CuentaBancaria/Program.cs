using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("***************** BANCO MUNDIAL*****************");
            //Variables
            double montoAr, saldoInicialAr;
            int opcion;
            string nombreAr, apellidosAr, direccionAr, nitAr;

            //Aviso de nueva  cuenta
            Console.Write("Esta a punto de crear una cuenta nueva, por favor presione cualquier tecla para continuar: ");
            Console.ReadKey();
            Console.WriteLine("\n Ingrese la informacion que se le solicita a continuacion: ");
            Console.Write("\n Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("\nApellidos: ");
            apellidosAr = Console.ReadLine();
            Console.Write("\nDireccion: ");
            direccionAr = Console.ReadLine();
            Console.Write("\nNit: ");
            nitAr = Console.ReadLine();

            Console.Write("\nIngrese su deposito inicial: $");
            saldoInicialAr = Convert.ToDouble(Console.ReadLine());
            //Instanciamos la clase
            CuentaBancaria cliente1 = new CuentaBancaria(nombreAr, apellidosAr,  saldoInicialAr,direccionAr, nitAr);
            //Mensaje de creacion de cuenta
            Console.WriteLine("Su cuenta ha sido creada con exito, presione cualquier tecla para continuar ");
            Console.ReadKey();

            // Menu 
            do
            {
                Console.WriteLine("\n1. Deposito");
                Console.WriteLine("\n2. Retiro");
                Console.WriteLine("\n3. Consultar Saldo ");
                Console.WriteLine("\n4. Mostrar Informacion de la Cuenta");
                Console.WriteLine("\n5. Salir");

                Console.Write("\nElija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {




                    case 1:
                        Console.Write("Ingrese el monto a depositar: $");
                        montoAr = Convert.ToDouble(Console.ReadLine());

                        cliente1.Deposito(montoAr);
                        break;

                    case 2:
                        Console.Write("Ingrese el monto a retirar: $");
                        montoAr = Convert.ToDouble(Console.ReadLine());

                        cliente1.Retiro(montoAr);
                        break;

                    case 3:
                        cliente1.ConsultaSaldo();
                        break;

                    case 4:
                        Console.WriteLine(cliente1.ToString());
                        break;

                }





            } while (opcion >= 1 && opcion <= 4);


        }
    }

    class CuentaBancaria
    {
        //Campo de tipo privado
        private string nombre, apellidos, direccion, nit;
        private double saldo;
        //Cnstructor
        public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string nitPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            nit = nitPa;
        }
        //metodos
        public double Deposito(double montoPa)
        {
            saldo += montoPa;
            return saldo;

        }
        public double Retiro(double montoPa)
        {
            if (saldo >= montoPa)
            {
                saldo -= montoPa;
            }
            else
            {
                Console.WriteLine("¡Saldo insuficiente!");

            }

            return saldo;

        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo es : ${0}", saldo);
        }
        public override string ToString()
        {
            string mensaje;
            mensaje =  "\nTitular:  " + nombre + " " + apellidos + "\nNIT: " + nit + "\nDireccion: " + direccion + "\nSaldo: $" + saldo;

            return mensaje;


        }
    }
}