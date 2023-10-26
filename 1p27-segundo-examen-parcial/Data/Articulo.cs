using System.ComponentModel.DataAnnotations;
public class Articulo{
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3, ErrorMessage="Longitud debe ser 3 a 30 caracteres")]
    [MaxLength(25,ErrorMessage="Longitud debe ser 3 a 30 caracteres")]
    public string Descripcion {get; set;}
    [Range(typeof(DateTime),"01/01/2023", "31/12/2024", ErrorMessage="Fecha fuera de rango")]
    public DateTime FechaAlta {get; set;}
    [Range(1,100,ErrorMessage="Cantidades disponibles del 1 al 100")]
    public int Cantidad {get; set;}
    [Range(1,2500,ErrorMessage="Excede el Precio")]
    public double Precio {get; set;}
    public string UdeMedida {get; set;}
    
}