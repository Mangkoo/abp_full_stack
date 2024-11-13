using Mangkoo.FullStack.Web.Payments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mangkoo.FullStack.Web.Pages.Merch;

public class IndexModel : FullStackPageModel
{
    [BindProperty]
    public double PaymentAmount { get; set; } = 0;

    [BindProperty]
    public PaymentMethod PaymentMethod { get; set; }
    public bool PaymentMade { get; set; }

    public void OnGet()
    {
        PaymentMade = false;
    }

    public IActionResult OnPost()
    {
        PaymentMade = true;

        //IPayment payment = PaymentFactory.create(PaymentMethod.Paypal);
        IPayment payment = PaymentFactory.create(PaymentMethod);
        payment.Pay(PaymentAmount);

        Logger.LogDebug($"\n\n\n\n Client: Paid ${PaymentAmount} using {PaymentMethod}! \n\n\n\n");
        return Page();
    }
}
