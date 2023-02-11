using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int id;
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Laboral laboral = new Laboral();
            Comercial comercial = new Comercial();
            Civil civil= new Civil();
            Mina mina = new Mina();

            

            Console.WriteLine("----------  BIENVEDIDO/A  ----------");
            Console.WriteLine("MENU:");
            Console.WriteLine("Ingrese el numero de su consulta" +
               "\n1 - Lista de empleados" +
               "\n2 - Lista de inmuebles"+
               "\n3 - Datos de la compra de inmubles");

            Console.WriteLine("\nIngrese el numero de su consulta");
            id = int.Parse(Console.ReadLine());
            if(id == 1)
            {

                empleado.nombre();
            }
            if (id == 2)
            {

            }
            if (id == 3)
            {
                Console.WriteLine("----------Datos de la compra de un inmueble----------");
                Console.WriteLine("\n -Inmueble : " + mina.nombre() +
                    "\n -Valor monetario: " + mina.valorMonetario()+
                    "\n -Tipo de inmueble: " + mina.tipo()+
                    "\n -Tamaño: " + mina.tamaño() +
                    "\n -Tipo de contrato: " + comercial.descripcion() +
                    "\n -Duracion del contrato: " + comercial.largoPlazo() +
                    "\n -Cliente: " + cliente.Cliente1()+
                    "\n -Empleado: " + empleado.Empleado1() +

                     "\n ------------------------------------------------------- " );
            }
            else
            {
                Console.WriteLine("El numero de consulta que usted eligio es incorrecto");
            }
        }
        abstract class Persona
        {

            public void Razonar()
            {
                Console.WriteLine("Con capacidad de razonar");
            }

            public abstract void nombre();


        }
        class Empleado: Persona
        {
            Laboral laboral = new Laboral();
            public override void nombre()
            {


                string[] nombreEmpleado = new string[10];
                nombreEmpleado[0] = "Matias Castilllo";
                nombreEmpleado[1] = "Rigoberto Montalvo";
                nombreEmpleado[2] = "Maria Monterrosa";
                nombreEmpleado[3] = "Judith Martínez";
                nombreEmpleado[4] = "Marta Caballero";
                nombreEmpleado[5] = "Ricardo Guardado";
                nombreEmpleado[6] = "Marbely Martínez";
                nombreEmpleado[7] = "Roberto Fuentes";
                nombreEmpleado[8] = "Margarita Madrid";
                nombreEmpleado[9] = "Dania Herrera";
                
                Console.WriteLine("Lista de empleados:\n" +
                    "\n1-" + nombreEmpleado[0] +
                    "\n -Tipo de Contrato: " + laboral.descripcion()+
                    "\n -Duracion: " + laboral.medianoPlazo()
                    +"\n ------------------------------------------------------- "+
                    "\n2-" + nombreEmpleado[1]+
                    "\n3-" + nombreEmpleado[2]+
                    "\n4-" + nombreEmpleado[3] +
                    "\n5-" + nombreEmpleado[4] +
                    "\n6-" + nombreEmpleado[5]+
                    "\n7-" + nombreEmpleado[6] +
                    "\n8-" + nombreEmpleado[7] +
                    "\n9-" + nombreEmpleado[8] +
                    "\n10-" + nombreEmpleado[9]);

                
            }
            public string Empleado1()
            {
                return ("Matias Castilllo");
            }
        }

        class Cliente : Persona
        {

            Comercial comercial = new Comercial();
            

            public override void nombre()
            {

                string[] nombreCliente = new string[10];
                nombreCliente[0] = "Bilma Aguilar";
                nombreCliente[1] = "Lili Montezino";
                nombreCliente[2] = "Aracely Mendoza";
                nombreCliente[3] = "Abel Serrano";
                nombreCliente[4] = "Dayana Nuñez";
                nombreCliente[5] = "Nicolle Chanchan";
                nombreCliente[6] = "Damaris Ayala";
                nombreCliente[7] = "Marcela Perez";
                nombreCliente[8] = "Cristina Lopez";
                nombreCliente[9] = "Isabel Menjivar";

                Console.WriteLine("Lista de empleados:\n" +
                    "\n1-" + nombreCliente[0] +
                    "\n -Tipo de Contrato: " + comercial.descripcion() +
                    "\n -Duracion: " + comercial.cortoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n2-" + nombreCliente[1] +
                    "\n3-" + nombreCliente[2] +
                    "\n4-" + nombreCliente[3] +
                    "\n5-" + nombreCliente[4] +
                    "\n6-" + nombreCliente[5] +
                    "\n7-" + nombreCliente[6] +
                    "\n8-" + nombreCliente[7] +
                    "\n9-" + nombreCliente[8] +
                    "\n10-" + nombreCliente[9]);

            }
            public string Cliente1()
            {
                return ("Bilma Aguilar");

            }



        }


        abstract class Inmueble
        {
            public abstract string tamaño();
            public abstract double valorMonetario();
            public abstract string tipo();

            public abstract string nombre();
            

        }
        class Mina: Inmueble
        {
            public override string tamaño()
            {
                return("1000 metros cuadrados");
            }
            public override double valorMonetario()
            {
                return(2000000);
            }
            public override string tipo()
            {
                return("Bien inmueble por naturaleza");
            }
            public override string nombre()
            {
                return("Carlin y Goldstrike");
            }

        }
        

        abstract class Contrato
        {
            public abstract string cortoPlazo();
            public abstract string medianoPlazo();
            public abstract string largoPlazo();
            public abstract string descripcion();
            


        }
        class Laboral : Contrato
        {
            public override string cortoPlazo()
            {
                return("Tres meses de duracion");
            }
            public override string medianoPlazo()
            {
                return("Un año");
            }
            public override string largoPlazo()
            {
                return("Tres años");
            }
            public override string descripcion()
            {
                return("Contrato laboral");
            }

        }
        class Civil : Contrato
        {
            public override string cortoPlazo()
            {
                return ("Seis meses de duracion");
            }
            public override string medianoPlazo()
            {
                return ("Un año y medio");
            }
            public override string largoPlazo()
            {
                return ("Dos años");
            }
            public override string descripcion()
            {
                return ("Contrato civil");
            }


        }
        class Comercial : Contrato
        {
            public override string cortoPlazo()
            {
                return ("Dos meses de duracion");
            }
            public override string medianoPlazo()
            {
                return ("Seis meses");
            }
            public override string largoPlazo()
            {
                return ("Dos años");
            }
            public override string descripcion()
            {
                return ("Contrato comercial");
            }

        }
    }
}