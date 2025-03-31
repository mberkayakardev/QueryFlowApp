using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.EntityConfigurations
{
    public class QuestionAnswersConfiguration : IEntityTypeConfiguration<QuestionAnswers>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswers> builder)
        {

            builder.HasOne(x=> x.SurveyQuestions).WithMany(x=> x.QuestionAnswers).HasForeignKey(x=> x.SurveyQuestionsId).OnDelete(DeleteBehavior.NoAction);  
        }
    }
}
