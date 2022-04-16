using E_Commerce.Northwind.Entities.Concrete;

namespace E_Commerce.WebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
