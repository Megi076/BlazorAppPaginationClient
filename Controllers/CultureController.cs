using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

[Route("culture")]
public class CultureController : Controller
{
    [HttpGet("setculture")]
    public IActionResult SetCulture(string culture, string redirectUri)
    {
        if (!string.IsNullOrEmpty(culture))
        {
            // Поставување на културата во колачињата
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
        }

        // Пренасочување назад на страницата
        return LocalRedirect(redirectUri ?? "/");
    }
}


