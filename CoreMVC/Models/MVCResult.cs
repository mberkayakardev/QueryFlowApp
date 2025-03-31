using Core.Utilities.Results.MVC.ComplexTypes;
using TrendMusic.ECommerce.Core.Extentions.ComplexTypes;

namespace CoreMVC.Models
{
    public class MVCResult
    {
        public string Messages { get; set; }
        public ApiResultStatus Status { get; set; }
        public IEnumerable<ErrorModel> ValidationErrors { get; set; }

    }
    public class MVCDataResult<T> : MVCResult
    {
        public T Data { get; set; }
    }

}
