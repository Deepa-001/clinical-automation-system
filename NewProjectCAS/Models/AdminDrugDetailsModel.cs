using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewProjectCAS.Models
{
    public class AdminDrugDetailsModel
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? ManufactureDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? ExpiredDate { get; set; }
        public string UsedFor { get; set; }
        public string SideEffects { get; set; }
        public int TotalQuantityAvailable { get; set; }
        public bool IsDeleted { get; set; }

        public List<AdminDrugDetailsModel> lstdrugdetail { get; set; }
    }
}