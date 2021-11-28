using System.Collections;
using System.Collections.Generic;
using E_Migrant.App.Dominio.Entidades;

namespace E_Migrant.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        Persona AddPersona(Persona persona);
        IEnumerable<Persona> GetAllPersonas();
        Persona GetPersona(int idPersona);
        Persona UpdatePersona(Persona persona);
    }
}