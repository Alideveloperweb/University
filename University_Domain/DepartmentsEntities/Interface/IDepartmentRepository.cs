using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_Common.Domain;

namespace University_Domain.DepartmentsEntities.Interface
{
    public interface IDepartmentRepository:IRepositoryBase<int, Department>
    {
    }
}
