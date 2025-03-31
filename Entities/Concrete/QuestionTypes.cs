using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class QuestionTypes : BaseEntity
    {
        public string QuestionTypeName { get; set; }
        public string QuestionTypeDescription { get; set; }

        #region Navigation Property
        public List<SurveyQuestions> SurveyQuestions { get; set; }
        #endregion
    }
}
