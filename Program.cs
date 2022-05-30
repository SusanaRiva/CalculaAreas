using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalculaAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu(); 
        }
        // metodo para seleccionar las opciones
        static void menu()
        {
            int op = 0;    
            do
            {
                Console.Clear();
                Console.WriteLine("**Menu de opciones para calcular areas **");
                Console.WriteLine("\n" +
                    "\n 1. Rectangulo" +
                    "\n 2. Cuadrado" +
                    "\n 3. Circulo" +
                    "\n 4. Triangulo" +
                    "\n 5. Salir \n"
                     );
                Console.WriteLine("Digite una opcion: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        AreaRectangulo();

                        break;
                    case 2:
                        AreaCuadrado(); 
                        break;
                    case 3:
                        AreaCirculo();
                        break;
                    case 4:
                        AreaTriangulo();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por su preferencia, vuelva pronto ");
                        break;
                    default:
                        Console.WriteLine("¡Digite un opcion valida!");
                        break;
                }
                Console.ReadKey();
            } while (op != 5);


        }
        //metodo para calcular el area de un rectangulo
        public static void AreaRectangulo()
        {
           double  bases = 0;
           double altura = 0;
           double resultado = 0; 
            Console.WriteLine("Calcular el area del rectangulo ");
            Console.WriteLine("-------------------------------------  ");
            Console.WriteLine("Ingrese la medida de la base del rectangulo: ");
            bases = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la altura del rectangulo: ");
            altura = int.Parse(Console.ReadLine());
            resultado = bases * altura;
            Console.WriteLine("El area del rectangulo es: " + resultado);
            CrearArchivo(resultado);


        }
        //metodo para calcular el area de un cuadrado
        public static void AreaCuadrado()
        {
            double lado = 0;
            double resultado = 0;
            Console.WriteLine("Calcular el area del cuadrado []");
            Console.WriteLine("-------------------------------------  ");
            Console.WriteLine("Recordatorio: Los cuadrados tienen sus lados iguales" +
                "  por lo que se solicita solo una medida  ");
            Console.WriteLine("Ingrese la medida del lado de cuadrado: ");
            lado = int.Parse(Console.ReadLine());
            resultado = lado * lado;
            Console.WriteLine("El area del cuadrado es: " + resultado);
            CrearArchivo(resultado);

        }
        //metodo para calcular el area de un circulo
        public static void AreaCirculo()
        {
            double radio = 0;
            double resultado = 0;
            Console.WriteLine("Calcular el area del circulo");
            Console.WriteLine("-------------------------------------  ");
            Console.WriteLine("Ingrese la medida del radio del circulo: ");
            radio = int.Parse(Console.ReadLine());
            resultado = Math.Pow(radio, 2) *(3.14);
            Console.WriteLine("El area del circulo es: " + resultado);
            CrearArchivo(resultado);

        }
        //metodo para calcular el area de un triangulo
        public static void AreaTriangulo()
        {
            double bases = 0;
            double altura = 0;
            double resultado = 0;
            Console.WriteLine("Calcular el area del triangulo");
            Console.WriteLine("-------------------------------------  ");
            Console.WriteLine("Ingrese la medida de la base del triangulo: ");
            bases = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la altura del triangulo: ");
            altura = int.Parse(Console.ReadLine());
            resultado = bases * altura / 2;
            Console.WriteLine("El area del triangulo es: " + resultado);
            CrearArchivo(resultado);
        }
        //metodo para crear y escribir en un archivo de texto
        static void CrearArchivo(double arch)
        {
            StreamWriter writer = File.CreateText("C:\\calculadora\\calculadora.txt");
            writer.WriteLine(arch);
            writer.Close();

        }

    }

}
    


      
    
   



