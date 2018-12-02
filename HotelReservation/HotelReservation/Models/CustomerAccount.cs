using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Models
{
    [Table("Customer")]
    public class CustomerAccount
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required!")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required!")]
        public String LastName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is Required!")]
        public String addrses1 { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is Required!")]
        public String City { get; set; }
        [Display(Name = "Province")]
        [Required(ErrorMessage = "Province is Required!")]
        public String Province { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is Required!")]
        public String Country { get; set; }

        [Display(Name = "Postal")]
        [Required(ErrorMessage = "Postal is Required!")]
        public String Postal { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone Name is Required!")]
        public String Phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required!")]
        //[RegularExpression("@" ^[a - z][a - z | 0 - 9 |] * ([_][a - z | 0 - 9] +) * ([.][a - z | 0 - 9] + ([_][a - z | 0 - 9] +) *) ?@[a-z] [a-z|0-9|]*\.([a - z][a - z | 0 - 9]* (\.[a-z] [a-z|0-9]*)?)$";")]
        public String Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is Required!")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        
        /*[Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match!")]
        [DataType(DataType.Password)]
        public String ComparedPassword { get; set; }*/
    }
}
