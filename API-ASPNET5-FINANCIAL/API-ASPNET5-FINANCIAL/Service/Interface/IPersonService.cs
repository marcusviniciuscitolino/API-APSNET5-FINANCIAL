using API_ASPNET5_FINANCIAL.Controllers.Model;
using System.Collections.Generic;

namespace API_ASPNET5_FINANCIAL.Service.Interface
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        IList<Person> FindALL();
        Person Update(Person person);
        void Delete(long id); 
    }
}
