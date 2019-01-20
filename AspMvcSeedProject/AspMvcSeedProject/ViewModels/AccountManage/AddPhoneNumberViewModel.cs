using System.ComponentModel.DataAnnotations;

namespace AspMvcSeedProject.ViewModels.AccountManage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}