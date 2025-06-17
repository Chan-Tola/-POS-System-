using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.staffAccess
{
    public class staff
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int stopwork { get; set; } = 0;
        public byte[] Photo { get; set; }
    }
}
