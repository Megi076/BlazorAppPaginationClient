using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

[Route("culture")]
public class CultureController : Controller
{
    [HttpGet("setculture")]
    public IActionResult SetCulture(string culture = "en-US", string redirectUri = "/")
    {
        Console.WriteLine($"➡️ Се повикува CultureController.SetCulture со culture: {culture}");

        if (!string.IsNullOrEmpty(culture))
        {
            // Поставување на кука за култура
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    IsEssential = true,
                    Secure = false, // Стави true ако користиш HTTPS
                    SameSite = SameSiteMode.Lax,
                    Path = "/"
                }
            );
        }

        // Пренасочување по поставување на културата
        Uri redirectUriParsed;
        if (Uri.TryCreate(redirectUri, UriKind.RelativeOrAbsolute, out redirectUriParsed))
        {
            if (redirectUriParsed.IsAbsoluteUri)
            {
                return Redirect(redirectUri); // Пренасочување ако е комплетен URL
            }
            else
            {
                return LocalRedirect(redirectUri); // Пренасочување ако е само патека
            }
        }

        // Ако не е валиден URL, пренасочување на домашна страница
        return LocalRedirect("/");
    }
}
