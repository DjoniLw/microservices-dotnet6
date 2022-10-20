using RestWithASPNET_Calculadora.Models;

namespace RestWithASPNET_Calculadora.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
