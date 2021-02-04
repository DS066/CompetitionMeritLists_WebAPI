using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionMeritLists_WebAPI.Models
{
    public class Students
    {

        public int Id { get; set; }

        [Required]
        public string Student_Name { get; set; }
        [Required]

        public int Student_age { get; set; }

        
        public string School_Name { get; set; }
        [Required]
        public string Subject_Name { get; set; }
        [Required]
        
        public string Subject_Code { get; set; }

        [Required]
        public string Marks_Obtained { get; set; }

    }
}
