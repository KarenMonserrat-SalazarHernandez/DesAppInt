// Codigo clase

public class Empleado{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public char Sexo { get; set; }
    public bool EstadoCivil { get; set; }

    public Empleado() {}
    public Empleado(string nombre) => Nombre = nombre;
    public Empleado(string nombre, int edad, char sexo, bool estadocivil) => (Nombre, Edad, Sexo, EstadoCivil) = (nombre, edad, sexo, estadocivil);

    public void ImprimirDatos(){
        Console.WriteLine($"Nombre      : {Nombre}");
        Console.WriteLine($"Edad        : {Edad}");
        Console.WriteLine($"Sexo        : {(Sexo=='M'?"Mujer":"Hombre")}");
        Console.WriteLine($"Estdo Civil : {(EstadoCivil?"Casado":"No Casado")}\n");
    }
}