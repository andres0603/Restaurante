Console.WriteLine("Estudiantes");
var lista_grupos= new List<grupos>();
lista_grupos.Add(new grupos() {id=1, nombre="LGTB", descuento=0.0m,activo=true  });
lista_grupos.Add(new grupos() {id=2, nombre="Indigena", descuento= 5.0m, activo=true });
lista_grupos.Add(new grupos() {id=3, nombre="Therian", descuento=0.0m, activo=true });

var lista_materia = new List<materias>();
lista_materia.Add(new materias() {id=1,codigo="M1", nombre="Bases de datos", activo=true });
lista_materia.Add(new materias() { id = 2, codigo = "M2", nombre = "Logica de programacion", activo = true });
lista_materia.Add(new materias() { id = 3, codigo = "M3", nombre = "Calculo", activo = true });

var lista_estudiantes= new List<estudiantes>();
lista_estudiantes.Add(new estudiantes() {id=1, cedula="1013337043", nombre="Andres", edad=21, activo=true });
lista_estudiantes.Add(new estudiantes() { id = 2, cedula = "1041147340", nombre = "Dahiana", edad = 21, activo = false });
lista_estudiantes.Add(new estudiantes() { id = 3, cedula = "1017231404", nombre = "Robert", edad = 30, activo = false });

var lista_notas=new List<notas>();
var nuevaNota = new notas()
{
    id = 1,
    estudiante = 1,
    materia = 2,
    nota1 = 3.5m,
    nota2 = 2.0m,
    nota3 = 3.6m,
    nota4 = 4.0m,
    nota5 = 5.0m
};
nuevaNota.notaF = calculos.promedio(nuevaNota);
lista_notas.Add(nuevaNota);

foreach(var n in lista_notas)
{
    Console.WriteLine("Id: " + n.id + "|");
    Console.WriteLine("Estudiante: " + n.estudiante + "|");
    Console.WriteLine("Materia: " + n.materia + "|");
    Console.WriteLine("Nota1: " + n.nota1 + "|");
    Console.WriteLine("Nota2: " + n.nota2 + "|");
    Console.WriteLine("Nota3: " + n.nota3 + "|");
    Console.WriteLine("Nota4: " + n.nota4 + "|");
    Console.WriteLine("Nota4: " + n.nota4 + "|");
    Console.WriteLine("Nota5: " + n.nota5 + "|");
    Console.WriteLine("NotaFinal: " + n.notaF + "|");
}


var estudiantes_activos = lista_estudiantes.Count(x => x.activo);
Console.WriteLine("La cantidad de estudiantes activos es:" + estudiantes_activos);


public class calculos
{
    public static decimal promedio(notas n)
    {
        decimal NotaFinal= (n.nota1+n.nota2+n.nota3+n.nota4+n.nota5)/5;
        return NotaFinal;
    }
}
public class grupos
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public decimal descuento { get; set; }
    public bool activo { get; set; }
    public List<estudiantes>? estudiantes { get; set; }
}

public class materias
{
    public int id { get; set; }
    public string? codigo { get; set; }
    public string? nombre { get; set; }
    public bool activo { get; set; }
    public List<notas>? notas { get; set; }

}

public class estudiantes
{
    public int id { get; set; }
    public string? cedula { get; set; }
    public string? nombre { get; set; }
    public bool activo { get; set; }
    public int edad { get; set; }
    public int grupo { get; set; }
    public grupos? _grupo { get; set; }

    public List<notas>? notas { get; set; }
}

public class notas
{
    public int id { get; set; }
    public int materia { get; set; }
    public int estudiante { get; set; }
    public decimal nota1 { get; set; }
    public decimal nota2 { get; set; }
    public decimal nota3 { get; set; }
    public decimal nota4 { get; set; }
    public decimal nota5 { get; set; }
    public decimal notaF { get; set; }
    public estudiantes? _estudiante { get; set; }
    public materias? _materia { get; set; }
}