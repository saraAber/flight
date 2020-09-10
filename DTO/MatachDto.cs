using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class MatachDto
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Uro { get; set; }
        public Nullable<double> Usa { get; set; }
        public Nullable<double> Shach { get; set; }
    }
}
