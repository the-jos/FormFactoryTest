using System.Collections.Generic;
using FormFactory.Attributes;

namespace FormFactoryTest.Models.Create
{
    public class CreateSurveyViewModel
    {
        
        [Required, Display(Name = "Survey Name", Prompt = "Give a name to your Survey")]
        public string Name { get; set; }
        [Required, Display(Name = "Description", Prompt = "Describe the purpose of the Survey"),MultilineText,StringLength(500),]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Add Questions:")]
        public ICollection<CreateQuestionViewModel> CreateQuestionTypeViewModel { get; set; }

        
    }
}