// Programa que:
// El usuario introduce n articulos que desea vender, para cada artículo se solicita la cantidad y el precio del mismo.
// • Calcular el subtotal de la venta (cantidad*precio) si excede $1200 no paga IVA. ( iva 16% ).
// • Al final de la venta, mostrar: Total de Ventas, Total de IVA Cobrado
// Nota: El proceso se repite hasta que el usuario lo decida.

//int CantArt;
double CantArt, precio, subtotal, IVA=0, totalVenta, totalIVACobrado=0, totalVentas=0;
char resp;

do{
    Console.Write("Ingrese la cantidad de artículos que desea vender ");
    Console.Write("Cantidad: ");
    CantArt = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el precio del artículo: ");
    Console.Write("$ ");
    precio = Convert.ToDouble(Console.ReadLine());

    subtotal = CantArt * precio;

    if (subtotal < 1200)
    {
        IVA = subtotal * 0.16; // Calcula el IVA si el subtotal es menor a  $1200
    }

    totalVenta = subtotal + IVA;
    totalVentas += totalVenta;
    totalIVACobrado += IVA;


    Console.WriteLine(new string ('-',41));
    Console.WriteLine($"Subtotal: ${subtotal}");
    Console.WriteLine($"IVA: ${IVA}");
    Console.WriteLine($"Total de la venta: ${totalVenta}");
    

    Console.WriteLine("\nDeseas capturar las calificaciones de otro estudiante (S/N) ?");
    resp = char.ToUpper(Console.ReadLine() [0]);

}while(resp!='N');

Console.WriteLine(new string ('-',41));
Console.WriteLine($"Total de la Ventas: ${totalVentas}");
Console.WriteLine($"Total de IVA Cobrado: ${totalIVACobrado}");
