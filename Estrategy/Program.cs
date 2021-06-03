using System;

namespace Estrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            string dato;
            IOperacion miOperacion = new CSuma();

            while(opcion != "5")
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multi, 4-Div, 5-Salir");
                opcion = Console.ReadLine();
                if (opcion == "5") break;

                Console.WriteLine("Dame el valor de a: ");
                dato = Console.ReadLine();
                double x = Convert.ToDouble(dato);

                Console.WriteLine("Dame el valor de b: ");
                dato = Console.ReadLine();
                double y = Convert.ToDouble(dato);

                if (opcion == "1") miOperacion = new CSuma();
                if (opcion == "2") miOperacion = new CResta();
                if (opcion == "3") miOperacion = new CMulti();
                if (opcion == "4") miOperacion = new CDiv();

                Console.WriteLine($"El resultado es : {miOperacion.Operacion(x, y)}");
            }

            
        }
    }
}
