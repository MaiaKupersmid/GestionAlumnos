public class Alumno
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Legajo { get; set; }
    public string Curso { get; set; }

    public Alumno(string nombre, string apellido, string legajo, string curso)
    {
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
        Curso = curso;
    }

    public Alumno() {}
}
