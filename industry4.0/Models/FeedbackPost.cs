using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace industry4._0.Models
{
    public class FeedbackPost
    {

        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Username { get; set; }
        [Required]
        public string HEading { get; set; }
        [Range(0, 5)]
        public int StarRating { get; set; }
        [Required]
        public string Feedback { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }
        [Required]
        public string CompanyOrganisationName { get; set; }
        public bool canIncreaseAgree { get; set; }
        public bool canIncreaseDisagree { get; set; }
    }
}
