using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeManager.Mvc.Models
{
    //Represents the Employee Database inside Northwind
    [Table(name:"Employees")]
    public class Employee
    {
        [Column(name:"EmployeeID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Employee ID is required")]
        [Display(Name ="Employee ID")]
        public int EmployeeID { get; set; }

        [Column(name: "FirstName")]
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(10,ErrorMessage = "First Name must be less than 10 characters")]
        public string FirstName { get; set; }

        [Column(name: "LastName")]
        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Last Name must be less than 20 characters")]
        public string LastName { get; set; }

        [Column(name: "Title")]
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        [StringLength(30, ErrorMessage = "Title must be less than 30 characters")]
        public string Title { get; set; }

        [Column(name: "BirthDate")]
        [Required(ErrorMessage = "BirthDate is required")]
        [Display(Name = "Birth Date")]
        
        public DateTime BirthDate { get; set; }

        [Column(name: "HireDate")]
        [Required(ErrorMessage = "Hire Date is required")]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Column(name: "Country")]
        [Required(ErrorMessage = "Country is required")]
        [Display(Name = "Country")]
        [StringLength(15, ErrorMessage = "Country must be less than 15 characters")]
        public string Country { get; set; }

        [Column(name: "Notes")]
        [Display(Name = "Notes")]
        [StringLength(500, ErrorMessage = "Notes must be less than 500 characters")]
        public string Notes { get; set; }


    }
}
