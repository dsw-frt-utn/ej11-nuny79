using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) 
  (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    // La lista de libros viene del método estático de Libro
    private List<Libro> _libros = Libro.CrearLista();

    // 1. Primer libro
    public Libro GetPrimero() => _libros.First();//first=>retorna el primer elemento de la colección, si no hay elementos lanza una excepción

    // 2. Último libro
    public Libro GetUltimo() => _libros.Last();//last=>retorna el último elemento de la colección, si no hay elementos lanza una excepción

    // 3. Suma de precios
    public decimal GetTotalPrecios() => _libros.Sum(l => l.Precio);//suma el valor de la propiedad Precio de cada libro en la lista

    // 4. Promedio de precios
    public decimal GetPromedioPreccios() => _libros.Average(l => l.Precio);//promedia el valor de la propiedad Precio de cada libro en la lista

    // 5. Libros con Id mayor a 15
    public List<Libro> GetListById() =>
        _libros.Where(l => l.Id > 15).ToList();//where=>filtra los libros que cumplen la condición Id > 15 y retorna una nueva lista con esos libros

    // 6. Título y precio en formato moneda (retorna lista de string)
    public List<string> GetLibros() =>
        _libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();//select=>proyecta cada libro a un string con su título y precio formateado como moneda, y retorna una lista de esos strings

    // 7. Libro con precio más alto
    public Libro GetMayorPrecio() =>
        _libros.OrderByDescending(l => l.Precio).First();//orderByDescending=>ordena los libros de mayor a menor según el precio, y retorna el primero (el de mayor precio)
    // 8. Libro con precio más bajo
    public Libro GetMenorPrecio() =>
        _libros.OrderBy(l => l.Precio).First();//orderBy=>ordena los libros de menor a mayor según el precio, y retorna el primero (el de menor precio)

    // 9. Libros cuyo precio sea mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        var promedio = _libros.Average(l => l.Precio);//average=>calcula el promedio de precios para usarlo como referencia en el filtro
        return _libros.Where(l => l.Precio > promedio).ToList();//where=>filtra los libros que cumplen la condición Precio > promedio y retorna una nueva lista con esos libros
    }

    // 10. Libros ordenados por título descendente
    public List<Libro> GetOrdenadosPorTituloDesc() =>
        _libros.OrderByDescending(l => l.Titulo).ToList();//orderByDescending=>ordena los libros de Z a A según el título, y retorna una lista con esos libros ordenados
}
