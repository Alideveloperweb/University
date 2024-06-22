
using University_Common.Application;
using University_Domain.PersonEntities;
using University_Domain.PersonEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.PersonRepository
{
    public class PersonRepositorys : RepositoryBase<int, Person>, IPersonRepository
    {
        private readonly ApplicationContext _ApplicationContext;
        public PersonRepositorys(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
                 _ApplicationContext = ApplicationContext;    
        }
/    }
}
