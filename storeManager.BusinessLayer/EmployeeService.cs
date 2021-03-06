﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BusinessLayer.Interfaces;
using storeManager.Entities;
using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;

namespace BusinessLayer
{
    public class EmployeeService : ServiceBase<Employee, int>, IEmployeeService
    {

        public EmployeeService()
            : base(new EmployeeRepository())
        {

        }
    }
}
