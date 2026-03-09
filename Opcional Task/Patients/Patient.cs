using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opcional_Task.Patients
{
  public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdCart { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public  string Address { get; set; }
        public string Telephone { get; set; }
        public DateTime BornDay { get; set; }
        public string Condition { get; set; }
        
        public string Email { get; set; }
    }
}
