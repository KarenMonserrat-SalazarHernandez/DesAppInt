// Control Ventas V2

Tienda mitienda = new Tienda{Nombre="Dulceria Coloritos", Propietario="Karen Salazar", Domicilio="La Pasadita 201"};

//Agregar cliente a la tienda
mitienda.AgregarCliente(new Cliente {Nombre="Pepe Perez",RFC="PEPP800315H3",Domicilio="La Florida #106",Correo="pepep@gmail.com"});
mitienda.AgregarCliente(new Cliente {Nombre="Angel Santos",RFC="SASA921219M1",Domicilio="Av. México #198",Correo="sangel@gmail.com"});
mitienda.AgregarCliente(new Cliente {Nombre="Lulu Valle",RFC="VAVL000811H6",Domicilio="CNOP #13",Correo="luluvalle@gmail.com"});
mitienda.AgregarCliente(new Cliente {Nombre="El chavo",RFC="ELCH860911X7",Domicilio="La vecindad #1",Correo="elchavo@gmail.com"});

// Agregar ventas a los Clientes 
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="Chocolate Carlos V 16pz", Cantidad=8, Precio=157.36});
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="Bocadin 100pz", Cantidad=6, Precio=249});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="Canels 60pz", Cantidad=7, Precio=131});
mitienda.Clientes[2].AgregarVenta(new Venta {Articulo="Aciduladito 100pz", Cantidad=13, Precio=78.85});
mitienda.Clientes[3].AgregarVenta(new Venta {Articulo="Paleta Payaso 24pz", Cantidad=10, Precio=399});
mitienda.Clientes[3].AgregarVenta(new Venta {Articulo="Bubulubu 24pz", Cantidad=9, Precio=289});

// Reporte
Console.Clear();
Console.WriteLine("Reporte de Ventas de la Tienda\n");
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"Total de Clietes: {mitienda.Clientes.Count()}");
Console.WriteLine($"Total de Ventas : {mitienda.TotalVentas()}");

Console.WriteLine("\n>> Datos generales de los Clientes: \n");
foreach (Cliente cliente in mitienda.Clientes){
    Console.WriteLine(cliente.ToString());
}

Console.WriteLine("\n>> Ventas de los clientes: \n");
foreach (Cliente cliente in mitienda.Clientes){
    Console.WriteLine($"\n> {cliente.Nombre} - {cliente.RFC} - ({cliente.Ventas.Count()})\n");
    foreach (Venta venta in cliente.Ventas)
        Console.WriteLine(venta.ToString());
    Console.WriteLine($"\n- Subtotal : {cliente.SubTotal(),46:c2}\n");
}
Console.WriteLine($"\n\n- Total : {mitienda.Total(), 51:c2}\n");