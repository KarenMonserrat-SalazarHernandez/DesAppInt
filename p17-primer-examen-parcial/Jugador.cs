public class Jugador{
    public string Nombre {get; set;}
    public int AñoNac {get; set;}
    public char Sexo {get; set;}   
    public bool Becado {get; set;}   
    public Jugador(string nombre, int añoNac, char sexo, bool becado)  => (Nombre, AñoNac, Sexo, Becado) = (nombre, añoNac, sexo, becado);
    public override string ToString() => $"Nombre: {Nombre, -15} AñoNac: {AñoNac, -15} Sexo: {Sexo, -18} Becado: {Becado}";
}