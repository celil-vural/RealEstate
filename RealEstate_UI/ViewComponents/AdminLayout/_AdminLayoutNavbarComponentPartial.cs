using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.AdminLayout;

public class _AdminLayoutNavbarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}