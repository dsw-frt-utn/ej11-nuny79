using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista

public class CasoList
{
    //Crear un campo que represente una lista de alumnos (List<>)
    // Campo: la lista de alumnos
    private List<Alumno> _alumnos = new List<Alumno>();

    // Incluir un método para Agregar alumnos a la lista
    public void Agregar(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    // Incluir un método para retornar la lista
    public List<Alumno> GetLista()
    {
        return _alumnos;
    }

    // Incluir un método para Buscar un alumno Por Nombre
    public Alumno BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);//FirstOrDefault: devuelve el primer elemento que cumple la condición o null si no se encuentra
    }

    // Incluir un método para Eliminar un alumno (recibe el objeto alumno)
    public void Eliminar(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    // Incluir un método para Eliminar un alumno en una determinada posición de la lista
    public void EliminarEnPosicion(int posicion)
    {
        _alumnos.RemoveAt(posicion);
    }
}