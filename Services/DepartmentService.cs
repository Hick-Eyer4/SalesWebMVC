using SALES_MVC.Data;
using SALES_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SALES_MVC.Services
{
    public class DepartmentService
    {
        private readonly SALES_MVCContext _context;

        public DepartmentService(SALES_MVCContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public Department FindById(int id)
        {
            return _context.Department.FirstOrDefault(obj => obj.Id == id);
        }
    }
}
