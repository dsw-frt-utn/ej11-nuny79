using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var lista = new CasoList();

        // Agregar 3 alumnos a la lista
        var a1 = new Alumno(1, "Natalia Peralta", 8.5);
        var a2 = new Alumno(2, "Carlos Gonzalez", 7.0);
        var a3 = new Alumno(3, "Juan Miranda", 9.2);

        lista.Agregar(a1);
        lista.Agregar(a2);
        lista.Agregar(a3);

        // Listar por consola los alumnos
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var alumno in lista.GetLista())
            Console.WriteLine(alumno);

        // Buscar por nombre un alumno que exista y mostrar por consola
        var encontrado = lista.BuscarPorNombre("Carlos Gonzalez");
        Console.WriteLine($"\nBúsqueda exitosa: {encontrado}");

        // Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        var noEncontrado = lista.BuscarPorNombre("Juan Sin Nombre");
        Console.WriteLine($"Búsqueda fallida: {(noEncontrado == null ? "No existe" : noEncontrado.ToString())}");

        // Eliminar un alumno y listar por consola los alumnos
        lista.Eliminar(a2);
        Console.WriteLine("\n=== Lista tras eliminar a Carlos ===");
        foreach (var alumno in lista.GetLista())
            Console.WriteLine(alumno);

        // Eliminar el primero (posición 0) y listar por consola los alumnos
        lista.EliminarEnPosicion(0);
        Console.WriteLine("\n=== Lista tras eliminar el primero ===");
        foreach (var alumno in lista.GetLista())
            Console.WriteLine(alumno);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var dic = new CasoDictionary();

        // Agregar 3 alumnos al diccionario(clave = legajo)
        dic.Agregar(101, new Alumno(1, "Natalia Peralta", 8.5));
        dic.Agregar(102, new Alumno(2, "Carlos Gonzalez", 7.0));
        dic.Agregar(103, new Alumno(3, "Juan Miranda", 9.2));

        // Listar por consola los alumnos
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in dic.GetDiccionario())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");

        // Buscar un alumno por clave y mostrar por consola
        var encontrado = dic.Buscar(102);
        Console.WriteLine($"\nBúsqueda exitosa: {encontrado}");

        // Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        var noEncontrado = dic.Buscar(999);
        Console.WriteLine($"Búsqueda fallida: {(noEncontrado == null ? "No existe" : noEncontrado.ToString())}");

        // Eliminar un alumno por clave y listar por consola los alumnos
        dic.Eliminar(101);
        Console.WriteLine("\n=== Diccionario tras eliminar legajo 101 ===");
        foreach (var par in dic.GetDiccionario())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var linq = new CasoLinq();

        Console.WriteLine($"Primero: {linq.GetPrimero()}");
        Console.WriteLine($"Último: {linq.GetUltimo()}");
        Console.WriteLine($"Total precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio precios: {linq.GetPromedioPreccios():C}");

        Console.WriteLine("\n=== Libros con Id > 15 ===");
        foreach (var libro in linq.GetListById())
            Console.WriteLine($"  {libro.Id} - {libro.Titulo}");

        Console.WriteLine("\n=== Títulos y precios ===");
        foreach (var texto in linq.GetLibros())
            Console.WriteLine($"  {texto}");

        Console.WriteLine($"\nMayor precio: {linq.GetMayorPrecio()}");
        Console.WriteLine($"Menor precio: {linq.GetMenorPrecio()}");

        Console.WriteLine("\n=== Libros sobre el promedio ===");
        foreach (var libro in linq.GetMayorPromedio())
            Console.WriteLine($"  {libro.Titulo} - {libro.Precio:C}");

        Console.WriteLine("\n=== Libros ordenados por título (desc) ===");
        foreach (var libro in linq.GetOrdenadosPorTituloDesc())
            Console.WriteLine($"  {libro.Titulo}");
    }
}