namespace ConsoleApplication15
{
    class Calculadora //Nombre de nuestra clase.
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora"; //Sirve para agregarle un titulo a la ventana
            string? resp = "";
            do
            {
                int valor1 = 0; //Aqui se almacenara el primer valor ingresado.
                int valor2 = 0; //Aqui se almacenara el segundo valor ingresado.
                int R = 0; //Aqui se almacenara el resultado de la operacion.

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el simbolo para realizar la operacion:\n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("\n Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string? eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("\nIngrese sus dos numeros\n");
                Console.Write("Valor1: ");
                valor1 = int.Parse(Console.ReadLine()!);
                
                Console.Write("Valor2: ");
                valor2 = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                try
                {
                    switch (eleccion)
                    {
                        case "+":
                            Console.WriteLine("El resultado de la suma es:");
                            R = valor1 + valor2;
                            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                            break;
                        case "-":
                            Console.WriteLine("El resultado de la resta es:");
                            R = valor1 - valor2;
                            Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                            break;
                        case "*":
                            Console.WriteLine("El resultado de la multiplicacion es:");
                            R = valor1 * valor2;
                            Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                            break;
                        case "/":
                            Console.WriteLine("El resultado de la division es:");
                            R = valor1 / valor2;
                            Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Ocurrió un error al realizar la operación.");
                }
                
                Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s");
        }
    }
}
