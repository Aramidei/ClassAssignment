using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Department
    {

        public Guid DeptId { get; set; }
        public string DepartmentName { get; set; }

        public Faculty Faculty { get; set; }
    }
}
