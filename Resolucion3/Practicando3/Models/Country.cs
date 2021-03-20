using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practicando3.Models
{
    public class Country
    {
        [Key]
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<double> Latlng { get; set; }
        public List<string> Timezones { get; set; }
        public string Flag { get; set; }

    }
}