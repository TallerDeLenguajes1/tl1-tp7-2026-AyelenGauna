using EspacioCalculadora;
Calculadora calculadoraSimple = new Calculadora();

int operacion, continuar = 0;
double termino = 0, anterior = 0;
string opcion, seguir, dato;

Console.WriteLine("***  CALCULADORA SIMPLE  ***");
Console.WriteLine("(Esta calculadora realiza las operaciones sobre el resultado obtenido luego de realizar una)");

do
{

    Console.WriteLine("\n¿Que operacion desea realizar?");

    do
    {
        Console.WriteLine("\nSuma = 1; Resta = 2; Multiplicacion = 3; Division = 4");
        opcion = Console.ReadLine();

        if (!int.TryParse(opcion,out operacion))
        {
            Console.WriteLine("\nValor ingresado no valido. Por favor ingrese cualquiera de las opciones que se muestran en pantalla");

        } else
        {
            do
            {
                Console.WriteLine("\nIngrese un número:");
                dato = Console.ReadLine();

                if (double.TryParse(dato, out termino))
                {
                    
                    switch (operacion)
                    {
                        case 1:
                                
                                calculadoraSimple.Sumar(termino);
                                Console.WriteLine($"Suma: {anterior} + {termino} = {calculadoraSimple.Resultado}");

                                break;

                        case 2: 
                                
                                calculadoraSimple.Restar(termino);
                                Console.WriteLine($"Resta: {anterior} - {termino} = {calculadoraSimple.Resultado}");

                                break;

                        case 3:
                                
                                calculadoraSimple.Multiplicar(termino);
                                Console.WriteLine($"Multiplicación: {anterior} x {termino} = {calculadoraSimple.Resultado}");

                                break;

                        case 4: 

                                if (termino != 0)
                                {
                                    calculadoraSimple.Dividir(termino);
                                    Console.WriteLine($"División: {anterior} / {termino} = {calculadoraSimple.Resultado}");
                                }else
                                {
                                    Console.WriteLine("\nNo se puede dividir sobre cero.");
                                }                            

                                break;

                        case 5:

                                break;
                        default:

                                Console.WriteLine("\nEl numero ingresado no se encuentra entre las opciones disponibles");
                                break;
            
                    }

                    anterior = calculadoraSimple.Resultado;

                }else
                {
                    Console.WriteLine("\nEl dato ingresado no valido.");
                }
                
            }while (!double.TryParse(dato, out termino) || (termino == 0 && operacion == 4));

            

        }

    } while (operacion > 4 || operacion < 1 || !int.TryParse(opcion,out operacion ));

    if (operacion >= 1 && operacion <= 4)
    {
        do
        {
            Console.WriteLine("\n¿Desea seguir operando?\nSÍ = 1, NO = 0");
            seguir = Console.ReadLine();

            if (!int.TryParse(seguir, out continuar) || (continuar != 1 && continuar != 0))
            {
                Console.WriteLine("\nEl dato ingresado es inválido. Ingrese un dato que sea válido dentro de las opciones");
            }

        } while (!int.TryParse(seguir, out continuar) || (continuar != 1 && continuar != 0));
        
    }

} while (continuar == 1);