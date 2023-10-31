public class Inscripcion {
    public int InscripcionId {get; set;}
    public int CursoId {get; set;} // llave secundaria relacion muchos a 1, tabla Curso
    public int EstudianteId {get; set;} // llave secundaria relacion muchos a 1, tabla Estudiante
    public float? Promedio {get; set;} 
    public Curso Curso {get; set;} // detalle de la relación muchos a 1
    public Estudiante Estudiante {get; set;} // detalle de la relación muchos a 1
}