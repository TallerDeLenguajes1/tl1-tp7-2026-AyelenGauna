using EspacioCalculadora;
Calculadora calculadoraSimple = new Calculadora();

int operacion;
double termino;
//char continuar = '0';
string opcion;

Console.WriteLine("Que operacion desea realizar?");

do
{
    Console.WriteLine("Suma = 1; Resta = 2; Multiplicacion = 3; Division = 4");
    opcion = Console.ReadLine();

    if (!int.TryParse(opcion,out operacion))
    {
        Console.WriteLine("Valor ingresado no valido. Por favor ingrese cualquiera de las opciones que se muestran en pantalla");

    } else
    {
        switch (operacion)
        {
            case 1:
                    termino = double.Parse(Console.ReadLine());
                    calculadoraSimple.Sumar(termino);
                    Console.WriteLine(calculadoraSimple.Resultado);

                    break;
            case 2: 
                    termino = double.Parse(Console.ReadLine());
                    calculadoraSimple.Restar(termino);
                    Console.WriteLine(calculadoraSimple.Resultado);

                    break;
            case 3:
                    termino = double.Parse(Console.ReadLine());
                    calculadoraSimple.Multiplicar(termino);
                    Console.WriteLine(calculadoraSimple.Resultado);

                    break;
            case 4: 
                    do
                    {
                        termino = double.Parse(Console.ReadLine());
                        calculadoraSimple.Dividir(termino);

                    } while (termino != 0);

                    Console.WriteLine(calculadoraSimple.Resultado);

                    break;
            default:
                    Console.WriteLine("El numero ingresado no se encuentra entre las opciones disponibles");
                    break;
    
        }
    }

} while (operacion > 4 || operacion < 1 || !int.TryParse(opcion,out operacion ));