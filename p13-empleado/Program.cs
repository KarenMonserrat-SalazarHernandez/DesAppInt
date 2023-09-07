// Control Empleados

// Instanciar y reservar espacio en memoria para un objeto de una clase determinada
Empleado empleado01 = new Empleado();
empleado01.Nombre = "Juan Carlos";
empleado01.Edad = 22;
empleado01.Sexo = 'H';
empleado01.EstadoCivil = false;
empleado01.ImprimirDatos();

// Instanciar, luego reservar espacio en memoria para un objeto de una clase determinada
Empleado empleado02;
empleado02 = new Empleado();
empleado02.Nombre = "María de Jesús";
empleado02.Edad = 41;
empleado02.Sexo = 'M';
empleado02.EstadoCivil = true;
empleado02.ImprimirDatos();

Empleado empleado03 = new Empleado("Claudia S", 35, 'M', false);
empleado03.ImprimirDatos();

Empleado empleado04 = new Empleado{Nombre = "Pollito", Edad = 75, Sexo = 'H', EstadoCivil = true};
empleado04.ImprimirDatos();