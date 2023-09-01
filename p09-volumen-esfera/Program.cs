// Programa que:
// Dado el radio de un círculo, calcula el volumen de la esfera, considera la siguiente formula:
// volumen = (4/3)*pi*radio^3 

double r, vol, pi=3.1416;

Console.WriteLine("Ingrese el valor del radio del circulo ");
Console.Write("r: ");
r = Convert.ToDouble(Console.ReadLine());

vol = ((4.0 / 3.0) * (pi) * (r*r*r));
Console.WriteLine($"El volumen es = {vol}");