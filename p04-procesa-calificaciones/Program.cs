﻿// Programa que procesa n calificaciones introducidas pir el usuario, calcula suma y procesa

int n=0, ne=0;
float cal=0, suma=0, promedio=0, promgral=0;
string status="";
char resp;

do{
    Console.Clear();
    promedio=suma=n=0;
    Console.WriteLine("Procesa calificaciones del semestre agosto-diciembre 2023, 666 para terminar\n");
    do {
        Console.WriteLine("Calificación :"); cal = float.Parse(Console.ReadLine());
        if (cal!=666){
            suma+=cal;
            n++;
        }
    } while(cal!=666);
    promedio = suma / n;
    status = promedio>=6 ? "Aprobado" : "No Aprobado"; // if
    Console.WriteLine($"Capturaste                       : {n} calificaciones");
    Console.WriteLine($"La suma de las calificaciones es : {suma:f2}");
    Console.WriteLine($"El promedio es                   : {promedio:f2}");
    Console.WriteLine($"Tu estatus es                    : {status}");
    ne++;
    promgral+=promedio;
    Console.WriteLine("\nDeseas capturar las calificaciones de otro estudiante (S/N) ?");
    resp = char.ToUpper(Console.ReadLine() [0]);
} while(resp!='N');
promgral/=ne;
Console.WriteLine($"Se procesaron las calificaciones de  : {ne} estudiantes");
Console.WriteLine($"Promedio general de la clase es      : {promgral}");

