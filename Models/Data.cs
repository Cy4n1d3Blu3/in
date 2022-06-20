using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FizzBuzzWeb.Models
{
    public class Data
    {

        public int Id { get; set; }
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Year must be a number")]
        [Required(ErrorMessage = "No data!")]
        [Range(1899, 2022, ErrorMessage = "Expected value {0} in range {1} - {2}")]
        public int Year { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Can't use special chars!")]
        [Required(ErrorMessage = "No data!")]
        [StringLength(100, ErrorMessage = "Name can't exceed {1} chars")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set;}
        public string Leap { get; set; }
        public string isleapyer()
        {
            if(Year % 4 == 0)
            {
                if(Year % 100 == 0)
                {
                    if(Year % 400 == 0) return "a leap";
                    else return "not a leap";
                }
                else return "a leap";
            }
            else return "not a leap";
        }
    }
}
