using AutoMapper;
using CrudAPI.Models;
using CrudAPI.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Services.Profiles
{
    public class DepartmentProfile :Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDto>();
        }
    }
}
