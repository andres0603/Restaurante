Console.WriteLine("Estudiantes");

var lista_grupos = new List<Grupos>();
lista_grupos.Add(new Grupos() { Id = 1, Nombre = "LGTV", Descuento = 0.0m, Activo = true });
lista_grupos.Add(new Grupos() { Id = 2, Nombre = "Indigena", Descuento = 5.0m, Activo = true });
lista_grupos.Add(new Grupos() { Id = 3, Nombre = "Therian", Descuento = 0.0m, Activo = true });

var lista_materias = new List<Materias>();
lista_materias.Add(new Materias() { Id = 1, Codigo = "M1", Nombre = "Calculo", Activo = true });
lista_materias.Add(new Materias() { Id = 2, Codigo = "M2", Nombre = "Logica", Activo = true });
lista_materias.Add(new Materias() { Id = 3, Codigo = "M3", Nombre = "Redes", Activo = false });

var lista_estudiantes = new List<Estudiantes>();
lista_estudiantes.Add(new Estudiantes() { Id = 1, Cedula = "479", Nombre = "Carla", Activo = true, Edad = 20, Grupo = 3 });
lista_estudiantes.Add(new Estudiantes() { Id = 2, Cedula = "854", Nombre = "Andres", Activo = false, Edad = 15, Grupo = 2 });
lista_estudiantes.Add(new Estudiantes() { Id = 3, Cedula = "236", Nombre = "Pedro", Activo = true, Edad = 70, Grupo = 1 });

var lista_notas = new List<Notas>();
/*lista_notas.Add(new Notas() { Id = 1, Materia = 1, Estudiante = 2, Nota1 = 3.0m, Nota2 = 4.5m, Nota3 = 1.0m, Nota4 = 2.9m, Nota5 = 4.0m, NotaF = 3.1m });
lista_notas.Add(new Notas() { Id = 2, Materia = 3, Estudiante = 3, Nota1 = 2.0m, Nota2 = 3.0m, Nota3 = 4.0m, Nota4 = 2.0m, Nota5 = 0.0m, NotaF = 2.2m });
lista_notas.Add(new Notas() { Id = 3, Materia = 2, Estudiante = 2, Nota1 = 3.5m, Nota2 = 4.0m, Nota3 = 2.9m, Nota4 = 1.3m, Nota5 = 4.2m, NotaF = 3.2m });
*/
var estudiantes_activos = lista_estudiantes.Count(x => x.Activo);
Console.WriteLine("Estudiantes activos: " + estudiantes_activos);

var nota = new Notas() { Id = 4, Materia = 1, Estudiante = 1, Nota1 = 3.5m, Nota2 = 4.0m, Nota3 = 2.9m, Nota4 = 1.3m, Nota5 = 4.2m };
nota.NotaF = Calculos.Promedio(nota);
lista_notas.Add(nota);

foreach(var n in lista_notas)
{
    Console.WriteLine(n.Id);
    Console.WriteLine(n.Materia);
    Console.WriteLine(n.Estudiante);
    Console.WriteLine(n.Nota1);
    Console.WriteLine(n.Nota2);
    Console.WriteLine(n.Nota3);
    Console.WriteLine(n.Nota4);
    Console.WriteLine(n.Nota5);
    Console.WriteLine(n.NotaF);
}

public class Calculos
{
    public static decimal Promedio(Notas notas)
    {
        return (notas.Nota1 + notas.Nota2 + notas.Nota3 + notas.Nota4 + notas.Nota5) / 5;
    }
}

public class Grupos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Descuento { get; set; }
    public bool Activo { get; set; }

    public List<Estudiantes>? Estudiantes { get; set; }
}

public class Materias
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public bool Activo { get; set; }

    public List<Notas>? Notas { get; set; }
}

public class Estudiantes
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public bool Activo { get; set; }
    public int Grupo { get; set; }

    public Grupos? _Grupo { get; set; }
    public List<Notas>? Notas { get; set; }
}

public class Notas
{
    public int Id { get; set; }
    public int Materia { get; set; }
    public int Estudiante { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }
    public decimal Nota3 { get; set; }
    public decimal Nota4 { get; set; }
    public decimal Nota5 { get; set; }
    public decimal NotaF { get; set; }

    public Materias? _Materia { get; set; }
    public Estudiantes? _Estudiante { get; set; }
}
