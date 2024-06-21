using University_Common.Application;
using University_Common.Domain;
using University_Domain.PersonEntities;
using University_Domain.PersonEntities.Interface;

namespace University_EfCore.Repository.PersonRepository
{
    public class PersonRepository : RepositoryBase<int, Person>, IPersonRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonRepository(IUnitOfWork unitOfWork) : base(unitOfWork.DbContext)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
