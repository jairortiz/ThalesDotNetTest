using System.ComponentModel.DataAnnotations;

namespace ThalesDotNetTest.Models
{
    public class Employee
    {

        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string employee_name { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Salary")]
        public decimal employee_salary { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Anual Salary")]

        public decimal AnualSalary
        {
            get { return employee_salary * 12; }
        }

        [Display(Name = "Age")]
        public string employee_age { get; set; }

        [Display(Name = "Profile Image")]
        public string profile_image { get; set; }
    }
}
