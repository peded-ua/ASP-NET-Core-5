using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Value { get; set; }

    [BindProperty]
    public DateTime ExpiryDate { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // «бер≥гаЇмо значенн€ у Cookies
        CookieOptions options = new CookieOptions
        {
            Expires = ExpiryDate
        };
        Response.Cookies.Append("StoredValue", Value, options);

        return RedirectToPage("/CheckCookie");
    }
}
