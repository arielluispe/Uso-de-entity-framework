
using System; /* System es para utilizar las etiquetas predefinidas ejemplo: Console.WriteLine(); 
                 Tambien se puede utilizar de esta forma system.console.WriteLine(); */
               
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;


namespace App1 //Espacio de nombres funciona para no tener problemas con los nombres de las variables y las clases.
{
    internal class Program //Program es un identificador porque está identificando a class.
    {
        //Los identificadodes son para:
        //Los namespaces.
        //Las clases.
        //Los Métodos.
        //Las Variables.
        //Las constantes.

        //Todas las palabas en azul son palabras recervadas y NO se pueden utilizar para los identificadores


        static void Main(string[] args) 
        {
            //Para imprimir en pantalla
            //Console.WriteLine("Hola mundo"); 

            //_____________________________________________________________________________________________________________________

            //Leer con el teclado
            //Console.ReadLine();

            //_____________________________________________________________________________________________________________________

            //Utilizando int y string en una concatenacion

            //string a;
            //Console.WriteLine("Digite su nombre: ");
            //a = Console.ReadLine();
            //Console.WriteLine("Bienvenido " + a);




            //int edad;
            //Console.WriteLine("Cuál es tu edad? ");
            //edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Tienes una edad de : " + edad+ " años");

            //_____________________________________________________________________________________________________________________

            //int edad = 20;

            //Para imcrementar y descincrementar
            // edad ++;
            // edad --;
            // edad -=5;
            // edad +=5;

            //Console.WriteLine("Tienes una edad de "+ /* ++ o -- */ edad /* ++ o -- */ + " años");


            //Imterpolacion de strings

            //Console.WriteLine($"Tienes una edad de {edad} años");

            //_____________________________________________________________________________________________________________________

            //Operadores

            //Console.WriteLine(7 * 5);
            //Console.WriteLine(7 + 5);
            //Console.WriteLine(7 - 5);
            //Console.WriteLine(7.0 / 5.0); //Lo detecta como double a menos que pongas uno de ellos decimal.
            //Tambien si ponemos uno decimal y el otro entero el decimal predominara y la operacion será decimal.

            //Console.WriteLine(9 % 4); // Es como una divicion pero te devuelve el reciduo.

        }
    }
}
