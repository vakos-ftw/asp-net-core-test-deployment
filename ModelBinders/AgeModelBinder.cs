using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace WorkingWithData.ModelBinders
{
    public class AgeModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            return Task.CompletedTask;
        }
    }
}
