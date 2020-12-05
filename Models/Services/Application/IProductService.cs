using System.Collections.Generic;
using Contoso.Models.ViewModels;

namespace Contoso.Models.Services.Application
{
    public interface IProductService
    {
         List<ProductViewModel> GetProducts();
    }
}