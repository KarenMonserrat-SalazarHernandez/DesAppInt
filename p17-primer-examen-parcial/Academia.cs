public class Academia{
    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}  
    public List<Categoria> Categorias {get; set;}  

    public int TotalHombres => CalcularPorSexo('H');

    public int TotalMujeres => CalcularPorSexo('M');

    public Academia() => Categorias = new List<Categoria>();
    public Academia(string nombre, string propietario, string domicilio) : this() => (Nombre, Propietario, Domicilio) = (nombre, propietario, domicilio);
    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);
    public override string ToString() => $"Nombre de la Academia: {Nombre}\nPropietario de la Academia: {Propietario}\nDomicilio de la Academia: {Domicilio}\n";
    
    private int CalcularPorSexo(char sexo)
    {
        int total = 0;
        foreach (Categoria categoria in Categorias)
        {
            total += categoria.TotalPorSexo(sexo);
        }
        return total;
    }

    public double Total(){
        double total=0;
        foreach(Categoria categoria in Categorias)
            total = total + categoria.SubTotal();
        return total;
    }
    
}

