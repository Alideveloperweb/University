
using University_Common.Application;
using University_Domain.PersonEntities;
using University_Domain.PersonEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.PersonRepository
{
    public class PersonRepository : RepositoryBase<int, Person>, IPersonRepository
    {
        private readonly ApplicationContext _ApplicationContext;
        public PersonRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
                 _ApplicationContext = ApplicationContext;    
        }
    }
}
