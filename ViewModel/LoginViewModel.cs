using System.ComponentModel.DataAnnotations;

namespace SQ20.Net_Wee7_8_Task.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Adress is required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
       
       
    }
}
