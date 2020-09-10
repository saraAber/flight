using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class FlightInforDto
    {

        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public string UserName { get; set; }
        public int From { get; set; }
        public int ToPlice { get; set; }
        public string TZUser { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime BackDate { get; set; }
        public int Dates { get; set; }
    }
}
