﻿using University_Common.Domain;
using University_Contract.EmployeeViewModel;

namespace University_Domain.EmployeeEntities.Interface
{
    public interface IEmployeeRepository: IRepositoryBase<int,Employee>
    {
        List<GetAllEmployeeItem> GetAllEmployee(bool isRemove);
    }
}
