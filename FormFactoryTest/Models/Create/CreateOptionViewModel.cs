using FormFactory.Attributes;

namespace FormFactoryTest.Models.Create
{
    public class CreateOptionViewModel
    {
        [Required]
        [Display(Name = "Choice Option", Prompt = "Possible answer")]
        public string OptionText { get; set; }
    }
}