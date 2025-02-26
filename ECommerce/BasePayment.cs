using System.Runtime;

namespace ECommerce;

public abstract class BasePayment
{
    public double Amount { get; set; }

    public abstract void Pay();
}
