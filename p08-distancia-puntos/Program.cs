// Programa que Calcula la distancia entre dos puntos, 
// dadas las coordenadas del punto A y el punto B, 
// en base a la siguiente fórmula: d=√((ax-bx)²+(ay-by)²) 
//                                 d=√((x2-x1)²+(y2-y1)²) 

double ax, bx, ay, by, d;

Console.WriteLine("Ingrese las coordenadas del punto A:");
Console.Write("ax: ");
ax = Convert.ToDouble(Console.ReadLine());

Console.Write("bx: ");
bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese las coordenadas del punto B:");
Console.Write("ay: ");
ay = Convert.ToDouble(Console.ReadLine());

Console.Write("by: ");
by = Convert.ToDouble(Console.ReadLine());

//                             ((ax-bx)²      +         (ay-by)²) 
d = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
Console.WriteLine($"La distancia = {d}");
