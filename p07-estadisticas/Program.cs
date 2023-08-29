// Programa que calcula las estadisticas basicas de un arreglo de calificaciones

const int MAX=100;
int n=0;
double[] califs = null; //double[] califs = {10, 9.5, 8.0, 7.5, 6.5, 9.0, 10.0, 5.5, 5.0, 9.0};

double may=0, men=0, prom=0, var=0, desv=0;

Console.Clear();
Console.Write("Cuantos elementos : ");
n = int.Parse(Console.ReadLine());

if(n>MAX){
    Console.WriteLine("El maximo de elementos es {0}", MAX);
    return 1;
}

califs = new double[n];
for(int i=0; i<califs.Length; i++){
    Console.Write($"calif[{i}] = ");
    califs[i] = double.Parse(Console.ReadLine());
}

Console.Write($"Los elementos del arreglo son : {est.imprime(califs)} ");

//est.imprime(califs);
may = est.Mayor(califs);
men = est.Menor(califs);
prom = est.Promedio(califs);
var = est.Varianza(califs, prom);
desv = Math.Sqrt(var);

Console.WriteLine("\n--Resumen de estadisticas--");

Console.WriteLine($"Cantidad de Cal  : {califs.Length}");
Console.WriteLine($"El mayor es      : {may:f2}");
Console.WriteLine($"El menor es      : {men:f2}");
Console.WriteLine($"El promedio es   : {prom:f2}");
Console.WriteLine($"La varianza es   : {var:f2}");
Console.WriteLine($"La desviación es : {desv:f2}");

return 0;


