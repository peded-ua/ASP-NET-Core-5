using Microsoft.AspNetCore.Mvc.RazorPages;

public class CheckCookieModel : PageModel
{
	public string StoredValue { get; private set; }

	public void OnGet()
	{
		StoredValue = Request.Cookies["StoredValue"] ?? "Значення не встановлено.";
	}
}
