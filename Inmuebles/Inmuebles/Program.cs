using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------  BIENVEDIDO/A  ----------");
            Console.WriteLine("MENU:");
            Console.WriteLine("Ingrese el numero de su consulta" +
               "\n1 - Datos de la compra de inmuble" +
               "\n2 - Martes" +
               "\n3 - Miercoles" +
               "\n4 - Jueves" +
               "\n5 - Viernes" +
               "\n6 - Sabado" +
               "\n7 - Domingo");
        }

        abstract class Persona
        {
            
            public void Razonar()
            {
                Console.WriteLine("Con capacidad de razonar");
            }

            public abstract void nombre();
           

        }
        class Cliente: Persona
        {
            Comercial contratoComercial = new Comercial();
            

            public override void nombre()
            {

                string[] nombreCliente = new string[10];
                nombreCliente[0] = "Matias Castilllo";
                nombreCliente[1] = "Rigoberto Montalvo";
                nombreCliente[2] = "Maria Monterrosa";
                nombreo[3] = "Judith Martíz";
                nombreEmpleado[4] = "Marta Caballero";
                nombreEmpleado[5] = "Ricardo Guardado";
                nombreEmpleado[6] = "Marbely Martínez";
                nombreEmpleado[7] = "Roberto Fuentes";
                nombreEmpleado[8] = "Margarita Madrid";
                nombreEmpleado[9] = "Dania Herrera";

            }
            
        }
        class Empleado : Persona
        {
            Laboral contratoLaboral = new Laboral();
            

            public override void nombre()
            {
                string[] nombreEmpleado= new string[10];
                nombreEmpleado[0] = "Matias Castilllo";
                nombreEmpleado[1] = "Rigoberto Montalvo";
                nombreEmpleado[2] = "Maria Monterrosa";
                nombreEmpleado[3] = "Judith Martíz";
                nombreEmpleado[4] = "Marta Caballero";
                nombreEmpleado[5] = "Ricardo Guardado";
                nombreEmpleado[6] = "Marbely Martínez";
                nombreEmpleado[7] = "Roberto Fuentes";
                nombreEmpleado[8] = "Margarita Madrid";
                nombreEmpleado[9] = "Dania Herrera";

            }

            
        }
        
        abstract class Inmueble
        {
            public abstract void valorMonetario();
            
            public abstract void durabilidad();

            //public string heterogeneidad;
            //public string localizacion;



        }
       
        abstract class Contrato
        {
            public string duracion;
            public string contenido;
            public string forma;
            public string interpretacion;
            public string eficacia;

        }
        class Laboral : Contrato
        {

        }
        class  Civil: Contrato
        {

        }
        class Comercial : Contrato
        {

        }
        //Crear un menu con la opciones
        //que permita elegir entre el tipo de mobiliario
        //Bienes inmuebles por naturaleza. ...
        //Bienes inmuebles por incorporación. ...
        //Bienes inmuebles por destino. ...
        //Bienes inmuebles por analogía
        //al elegir uno qque le de dos opciones una respuesta de si y no
        //si dice que no que lo retorne al menu 
        // si dice que si que muestre lo siguiente
        // que muestre el empleado y cliente que compro el inmueble asi como 

    }
}
