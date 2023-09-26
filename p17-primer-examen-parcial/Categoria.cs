public class Categoria{
    public string Nombre {get; set;}
    public string Rango {get; set;}
    public double Costo {get; set;}   
    public List<Jugador> Jugadores {get; set;}  

    public int TotalJugadores => Jugadores.Count;

    public Categoria() => Jugadores = new List<Jugador>();
    public Categoria(string nombre, string rango, double costo) : this() => (Nombre, Rango, Costo) = (nombre, rango, costo);
    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);
    public override string ToString() => $"Nombre: {Nombre, -15}Rango: {Rango, -20}Costo: {Costo:c2}";

    public int TotalPorSexo(char sexo)
    {
        return Jugadores.Count(jugador => jugador.Sexo == sexo);
    }
    public double SubTotal(){
        double total=0;
        foreach(Jugador jugador in Jugadores)
            total = total + jugador.Total;
        return total;
    }

}