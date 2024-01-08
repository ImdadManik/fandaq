using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace fandaq.ProductService.Controllers;

public class HomeController : AbpController
{
    public ActionResult Index()
    {
        return Redirect("/swagger");
    }
}
