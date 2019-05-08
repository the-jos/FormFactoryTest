using System.Collections.Generic;
using FormFactory;
using FormFactory.Attributes;

namespace FormFactoryTest.Models.Create
{
    public class CreateQuestionViewModel
    {

        [Required, Display(Name = "Question Type")]
        public CreateQuestionViewModelType CreateQuestionViewModelType { get; set; }

        public IEnumerable<CreateQuestionViewModelType> CreateQuestionViewModelType_choices()
        {
            yield return CreateQuestionViewModelType is CreateMultipleQuestionViewModelType
                ? CreateQuestionViewModelType.Selected()
                : new CreateMultipleQuestionViewModelType();
            yield return CreateQuestionViewModelType is CreateOpenQuestionViewModelType
                ? CreateQuestionViewModelType.Selected()
                : new CreateOpenQuestionViewModelType();
            yield return CreateQuestionViewModelType is CreateSingleQuestionViewModelType
                ? CreateQuestionViewModelType.Selected()
                : new CreateSingleQuestionViewModelType();
        }


        public class CreateOpenQuestionViewModelType : CreateQuestionViewModelType
        {
            [Required, Display(Name = "Question", Prompt = "Fill in the question")]
            public string QuestionText { get; set; }

            [Display(Name = "Required"), LabelOnRight]
            public bool IsRequired { get; set; }

            [Display(Name = "Hidden"), LabelOnRight]
            public bool Hidden { get; set; }
        }

        public class CreateSingleQuestionViewModelType : CreateQuestionViewModelType
        {        [Required, Display(Name = "Question", Prompt = "Fill in the question")]
            public string QuestionText { get; set; }

            [Display(Name = "Required"), LabelOnRight]
            public bool IsRequired { get; set; }

            [Display(Name = "Hidden"), LabelOnRight]
            public bool Hidden { get; set; }
            [Required, Display(Name = "Choices:")]
            public ICollection<CreateOptionViewModel> Options { get; set; }
        }

        public class CreateMultipleQuestionViewModelType : CreateQuestionViewModelType
        {        [Required, Display(Name = "Question", Prompt = "Fill in the question")]
            public string QuestionText { get; set; }

            [Display(Name = "Required"), LabelOnRight]
            public bool IsRequired { get; set; }

            [Display(Name = "Hidden"), LabelOnRight]
            public bool Hidden { get; set; }
            [Required, Display(Name = "Choices:")]
            public ICollection<CreateOptionViewModel> Options { get; set; }
        }
    }


    public abstract class CreateQuestionViewModelType
    {

    }
}