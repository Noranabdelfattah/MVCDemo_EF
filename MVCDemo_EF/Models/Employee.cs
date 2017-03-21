using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo_EF.Models
{
   [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
    }

    public class EmployeeMetaData {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int DepartmentId { get; set; }

    }
}