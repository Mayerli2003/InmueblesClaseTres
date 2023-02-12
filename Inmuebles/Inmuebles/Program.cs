using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Program
    {

        static void Main(string[] args)
        {

            int id = 0;

            Inmuebles inmuebles= new Inmuebles();
            Personas persona = new Personas();
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Laboral laboral = new Laboral();
            Comercial comercial = new Comercial();
            Civil civil = new Civil();
            Mina mina = new Mina();
            Casa casa = new Casa();
            Terreno terreno = new Terreno();
           



            Console.WriteLine("----------  BIENVEDIDO/A  ----------");
            do
            {

                Console.WriteLine("------------- MENU:------------------");
                Console.WriteLine("Ingrese el numero de su consulta");
                Console.WriteLine("\n1 - Lista de empleados");
                Console.WriteLine("\n2 - Lista de clientes frecuentes");
                Console.WriteLine("\n3 - Lista de inmuebles");
                Console.WriteLine("\n4 - Comprar");
                Console.WriteLine("\n5 - Salir");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------------------------------------");


                Console.WriteLine("\nIngrese el numero de su consulta");
                id = Convert.ToInt32(Console.ReadLine());
                switch (id)
                {
                    case 1:
                        Console.WriteLine("-----------Datos de empleados----------");
                        empleado.Nombres();

                        break;
                        
                    case 2:
                        Console.WriteLine("-----------Clientes frecuentes----------");
                        cliente.Nombres();
                        break;

                    case 3:

                        Console.WriteLine("----------Datos de inmuebles----------");
                        Console.WriteLine("\n -Inmueble : " + mina.nombre() +
                          "\n -Valor monetario: " + "$ " + mina.valorMonetario() +
                          "\n -Tipo de inmueble: " + mina.tipo() +
                          "\n -Tamaño: " + mina.tamaño() +
                          "\n -Tipo de contrato: " + comercial.descripcion() +
                          "\n -Duracion del contrato: " + comercial.largoPlazo() +
                          "\n -Cliente: " + cliente.Cliente1() +
                          "\n -Empleado: " + empleado.Emplieado1() +

                          "\n ------------------------------------------------------- ");
                        Console.WriteLine("\n -Inmueble : " + casa.nombre() +
                          "\n -Valor monetario: " + "$ " + casa.valorMonetario() +
                          "\n -Tipo de inmueble: " + casa.tipo() +
                          "\n -Tamaño: " + casa.tamaño() +
                          "\n -Tipo de contrato: " + civil.descripcion() +
                          "\n -Duracion del contrato: " + civil.cortoPlazo() +
                          "\n -Cliente: " + cliente.Cliente2() +
                          "\n -Empleado: " + empleado.Emplieado2() +

                          "\n ------------------------------------------------------- ");
                        Console.WriteLine("\n -Inmueble : " + terreno.nombre() +
                          "\n -Valor monetario: " + "$ " + terreno.valorMonetario() +
                          "\n -Tipo de inmueble: " + terreno.tipo() +
                          "\n -Tamaño: " + terreno.tamaño() +
                          "\n -Tipo de contrato: " + comercial.descripcion() +
                          "\n -Duracion del contrato: " + comercial.cortoPlazo() +
                          "\n -Cliente: " + cliente.Cliente3() +
                          "\n -Empleado: " + empleado.Emplieado3() +

                          "\n ------------------------------------------------------- ");
                        Console.ReadLine();
                        break;

                    case 4:


                        persona.datos(persona.Nombre, persona.Apellido, persona.Edad, persona.Dui);

                        empleado.Empleados(empleado.Salario, empleado.Contrato, empleado.Tiempo_Contrato);

                        inmuebles.tipoMuebles(inmuebles.Nombre, inmuebles.Tamaño, inmuebles.ValorMuebles1, inmuebles.Tipo1);


                        Console.WriteLine(persona.Cliente());

                        Console.WriteLine(empleado.getEmpleados());

                        Console.WriteLine(inmuebles.gettipoMuebles());
                        Console.ReadLine();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("La opcion no es correcta");
                        break;


                }
                Console.ReadKey();
            }
            while (id != 10);
            {
                Console.WriteLine("Fin de  consultas");
            }


        }
        abstract class Persona
        {

            public void Razonar()
            {
                Console.WriteLine("Con capacidad de razonar");
            }

            public abstract void Nombres();

        }
        class Personas
        {
            private string nombre;

            private string apellido;

            private int edad;

            private int dui;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public int Edad { get => edad; set => edad = value; }
            public int Dui { get => dui; set => dui = value; }



            public void datos(string _nombre, string _Apellido, int _edad, int _dui)
            {
                this.Nombre = _nombre;
                this.Apellido = _Apellido;
                this.Edad = _edad;
                this.Dui = _dui;



                Console.WriteLine("-------------------------------------");

                Console.WriteLine("-----Ingrese  Sus Datos----- \n");

                Console.WriteLine("Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Su Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Su edad:");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su Dui:");
                Dui = int.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
            }
            public String Cliente()
            {
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + Nombre + " \n Apellido: " + Apellido + "\n Edad: " + Edad + "\n Dui: " + Dui;

                Console.WriteLine("-------------------------------------");
            }
        }
        class Empleado : Persona
        {
            Laboral laboral = new Laboral();


            public override void Nombres()
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
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.medianoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n2-" + nombreEmpleado[1] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.largoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n3-" + nombreEmpleado[2] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.cortoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n4-" + nombreEmpleado[3] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.medianoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n5-" + nombreEmpleado[4] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.cortoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n6-" + nombreEmpleado[5] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.cortoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n7-" + nombreEmpleado[6] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.medianoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n8-" + nombreEmpleado[7] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.largoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n9-" + nombreEmpleado[8] +
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.largoPlazo()
                    + "\n ------------------------------------------------------- " +
                    "\n10-" + nombreEmpleado[9]+
                    "\n -Tipo de Contrato: " + laboral.descripcion() +
                    "\n -Duracion: " + laboral.cortoPlazo()
                    + "\n ------------------------------------------------------- ");
                Console.ReadLine();

            }
            public string Emplieado1()
            {
                return ("Matias Castillo");
            }
            public string Emplieado2()
            {
                return ("Rigoberto Palacios");
            }
            public string Emplieado3()
            {
                return ("Maria Mendoza");
            }

            Personas personas = new Personas();
            private double salario;

            private string contrato;

            private string tiempo_Contrato;

            public double Salario { get => salario; set => salario = value; }
            public string Contrato { get => contrato; set => contrato = value; }
            public string Tiempo_Contrato { get => tiempo_Contrato; set => tiempo_Contrato = value; }

            public void Empleados(double _Salario, string _contrato, string _tiempo_Contrato)
            {
                this.Salario = _Salario;
                this.Contrato = _contrato;
                this.Tiempo_Contrato = _tiempo_Contrato;


                Console.WriteLine("----------Ingrese  Datos de Empleado----------\n");

                Console.WriteLine("Ingrese el nombre del Empleado:");
                personas.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del Empleado:");
                personas.Apellido = Console.ReadLine();
                Console.WriteLine("Digite el DUI del embleado:");
                personas.Dui = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el salario:");
                Salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Tipo de Contrato:");
                Contrato = Console.ReadLine();
                Console.WriteLine("Ingrese el Tiempo de Contrato:");
                Tiempo_Contrato = Console.ReadLine();

            }

            public String getEmpleados()
            {
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + personas.Nombre + " \n Apellido: " + personas.Apellido + "\n Dui: " + personas.Dui+" \n Salario: $ " + Salario + " \n Contrato: " + contrato + " \n Tiempo de contrato: " + Tiempo_Contrato ;
                Console.WriteLine("-------------------------------------");
            }

        }

        class Cliente : Persona
        {

            Comercial comercial = new Comercial();

            public override void Nombres()
            {
                string[] nombreCliente = new string[4];
                nombreCliente[0] = "Marcos Castilllo";
                nombreCliente[1] = "Azucena Montalvo";
                nombreCliente[2] = "Damaris Lopez";
                nombreCliente[3] = "Dora Martínez";


                Console.WriteLine("Lista de clientes:\n" +
                    "\n1-" + nombreCliente[0] 
                    + "\n ------------------------------------------------------- " +
                    "\n2-" + nombreCliente[1]
                    + "\n ------------------------------------------------------- " +
                    "\n3-" + nombreCliente[2]
                    + "\n ------------------------------------------------------- " +
                    "\n4-" + nombreCliente[3] 
                    + "\n ------------------------------------------------------- ");
            }
            public string Cliente1()
            {
                return ("Marcos Herrera");
            }
            public string Cliente2()
            {
                return ("Azucena Andry");
            }
            public string Cliente3()
            {
                return ("Damaris Lopez");
            }
        }

        abstract class Inmueble
        {


            public abstract string tamaño();
            public abstract double valorMonetario();
            public abstract string tipo();

            public abstract string nombre();


        }
        class Inmuebles
        {
            private string nombre;

            private string tamaño;

            private double ValorMuebles;

            private string Tipo;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Tamaño { get => tamaño; set => tamaño = value; }
            public double ValorMuebles1 { get => ValorMuebles; set => ValorMuebles = value; }
            public string Tipo1 { get => Tipo; set => Tipo = value; }

            public void tipoMuebles(string _nombres, string _tamaño, double _Valormuebles, string _tipo)
            {
                this.Nombre = _nombres;
                this.Tamaño = _tamaño;
                this.Tipo = _tipo;
                this.ValorMuebles1 = _Valormuebles;


                Console.WriteLine("-------------------------------------");
                Console.WriteLine("----------Ingrese datos de el inmueble----------\n");

                Console.WriteLine("Nombre de inmueble:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el tamaño:");
                Tamaño = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de inmueble:");
                Tipo = Console.ReadLine();
                Console.WriteLine("Ingrese el valor del inmueble:");
                ValorMuebles = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");

               

            }
            public String gettipoMuebles()
            {
                Console.WriteLine("-------------------------------------");
                return " \n Nombre: " + Nombre + " \n Tamaño: " + Tamaño + " \n Tipo: " + Tipo + "\n Valor del inmueble: $ " + ValorMuebles;
                Console.WriteLine("-------------------------------------");
            }
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
        class Casa : Inmueble
        {
            public override string nombre()
            {
                return("Casa-123");
            }

            public override string tamaño()
            {
                return("50 metros cuadrados");
            }

            public override string tipo()
            {
                return("Bien inmuble por naturaleza");
            }

            public override double valorMonetario()
            {
                return(12000);
            }
        }
        class Terreno : Inmueble
        {
            public override string nombre()
            {
                return("Terreno 003");
            }

            public override string tamaño()
            {
                return("1200000 metros cuadrados");
            }

            public override string tipo()
            {
                return("Bien inmuble por naturaleza");
            }

            public override double valorMonetario()
            {
                return(5000000);
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