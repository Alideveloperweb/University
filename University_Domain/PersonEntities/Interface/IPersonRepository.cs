using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_Common.Domain;

namespace University_Domain.PersonEntities.Interface
{
    public interface IPersonRepository:IRepositoryBase<int, Person>
    {
    }
}
