// Programa que:
// Un alumno curso el semestre en la Universidad, y obtuvo un promedio, hay que emitir una calificación con letra y un
// mensaje de acuerdo al promedio, según la siguiente tabla:
// Promedio  Letra  Mensaje
// 0 y 5.9    D    Andas mal
// 6 a 7.5    C    Mucho mejor
// 7.6 a 8.5  B    Muy bien
// 8.6 a 10   A    Excelente
// Dado el nombre del estudiante y su promedio:
// • Validar que este entre 0 y 10
// • Emitir la calificación con letra y el mensaje respectivo

string nombre, letra, mensaje;
double promedio;

Console.WriteLine("Ingrese el nombre del estudiante: ");
nombre = Console.ReadLine();

Console.WriteLine("Ingrese el promedio del estudiante (entre 0 y 10) con punto decimal ");
Console.Write("Promedio : ");
promedio = Convert.ToDouble(Console.ReadLine());

// Validar que el promedio esté dentro del rango (0 y 10)
if (promedio >= 0 && promedio <= 10)
{
    letra = "";
    mensaje = "";

    // Asignación de letra y mensaje 
    if (promedio <= 5.9)
    {
        letra = "D";
        mensaje = "Andas mal";
    }
    else if (promedio <= 7.5)
    {
        letra = "C";
        mensaje = "Mucho mejor";
    }
    else if (promedio <= 8.5)
    {
        letra = "B";
        mensaje = "Muy bien";
    }
    else
    {
        letra = "A";
        mensaje = "Excelente";
    }

        Console.WriteLine("Nombre\tPromedio\tLetra\tMensaje");
        Console.WriteLine(new string ('-',41));
        Console.WriteLine($"{nombre}\t{promedio}\t\t{letra}\t{mensaje}");
}
else
{
    Console.WriteLine("El promedio ingresado está fuera del rango permitido (debe estar entre 0 y 10).");
}






