using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace NewProjectCAS.Models
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }
        public string Address { get; set; }
        public string MemberId { get; set; }

        public List<PatientViewModel> lstPatient { get; set; }
    }
}