using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave

public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    // diccionario[clave:valor]: clave = legajo (int), valor = alumno
    private Dictionary<int, Alumno> _diccionario = new Dictionary<int, Alumno>();

    //Incluir un método para Agregar un alumno al diccionario
    public void Agregar(int legajo, Alumno alumno)
    {
        _diccionario.Add(legajo, alumno);
    }

    // Incluir un método para Buscar un alumno utilizando la clave (legajo)
    public Alumno Buscar(int legajo)
    {
        return _diccionario.ContainsKey(legajo) ? _diccionario[legajo] : null;
    }

    // Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> GetDiccionario()
    {
        return _diccionario;
    }

    // Incluir un método para Eliminar un alumno utilizando la clave (legajo)
    public void Eliminar(int legajo)
    {
        _diccionario.Remove(legajo);
    }
}