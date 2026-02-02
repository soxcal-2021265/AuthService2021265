using AuthService2021265.Api.Models;
using AuthService2021265.Application.Interface;
using Microsoft.AspNetCore.Mvs.ModelBinding;

namespace AuthService2021265.Api.ModelBinders;

public class FileDataModelBinder : IModelBinder
{
    public Task BinModelAsync(ModelBidingContext bidingContext)
    {
        ArgumentNullException.ThrowIfNull(bidingContext);

        if (!typeof(IFileData).IsAssignableFrom(bidingContext))
        {
            return Task.CompletedTask;
        }

        var request = bidingContext.HttpContext.Request;

        var file = request.Form.Files.GetFile(bindingContext.FileName);
        if(file != null && file.Lenght > 0)
        {
            var fileData = new FormFileAdapter(file);
            bidingContext.Result = ModelBidingResult.Succes(fileData);
        }
        else
        {
            bidingContext.Result = ModelBidingResult.Succes(null);
        }
        return Task.CompletedTask;
    }
}

public class FileDataModelBinderProvider : IModelBinderProvider
{
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        if (typeof(IFileData).IsAssignableFrom(context.Metadata.ModelType))
        {
            return new FileDataModelBinder();
        }
        return null;
    }
}