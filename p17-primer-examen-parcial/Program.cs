// Primer Examen Parcial

Academia miacademia = new Academia{Nombre="Academia Futbolito", Propietario="Karen Salazar", Domicilio="La Pasadita 201"};

// Agregar la Categoria a la Academia
miacademia.AgregarCategoria(new Categoria {Nombre="Junior A",Rango="2006/2007/2008",Costo=1250});
miacademia.AgregarCategoria(new Categoria {Nombre="Junior B",Rango="2009/2010/2011",Costo=850});
miacademia.AgregarCategoria(new Categoria {Nombre="Pony   A",Rango="2012/2013/2014",Costo=700});

// Agregar Jugadores a las Categorias
miacademia.Categorias[0].AgregarJugador(new Jugador("Alexander Lopez    ",2006,'H',false));
miacademia.Categorias[0].AgregarJugador(new Jugador ("Raul Puga         ",2007,'H',true));
miacademia.Categorias[0].AgregarJugador(new Jugador ("Alejandra Escalona",2008,'M',false));
miacademia.Categorias[1].AgregarJugador(new Jugador ("Armando Santana   ",2009,'H',false));
miacademia.Categorias[1].AgregarJugador(new Jugador("Daniel Mijares     ",2010,'H',false));
miacademia.Categorias[1].AgregarJugador(new Jugador("Antonio Hernandez  ",2011,'M',true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Andrea Solis       ",2012,'M',true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Marissa Hernandez  ",2013,'M',true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Diana Soto         ",2014,'M',false));

// Reporte
Console.Clear();
Console.WriteLine("**** REPORTE DEL CLUB DEPORTIVO ****\n");
Console.WriteLine(miacademia.ToString());
Console.WriteLine($"Total de Categorias : {miacademia.Categorias.Count()}");
Console.WriteLine($"Total de Hombres    : {miacademia.TotalHombres()}");
Console.WriteLine($"Total de Mujeres    : {miacademia.TotalMujeres()}");

Console.WriteLine("\n>> DATOS GENERALES DE LAS CATEGORIAS: \n");
foreach (Categoria categoria in miacademia.Categorias){
    Console.WriteLine(categoria.ToString());
}

Console.WriteLine("\n>> JUGADORES POR CATEGORIA: \n");;
foreach (Jugador jugador in miacademia.Jugadores){
    Console.WriteLine($"\n> {jugador.Nombre} - {jugador.AñoNac} - {jugador.Sexo} - {jugador.Becado} - ({jugador.Jugadores.Count()})\n");
    foreach (Jugador jugador in jugador.Jugadores)
        Console.WriteLine(jugador.ToString());
    Console.WriteLine($"\n- Subtotal : {categoria.SubTotal(),46:c2}\n");
}
Console.WriteLine($"\n\n- Total : {miacademia.Total(), 51:c2}\n");
