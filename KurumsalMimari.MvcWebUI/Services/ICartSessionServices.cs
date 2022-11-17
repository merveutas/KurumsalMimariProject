using KurumsalMimari.Entities.Concrete;

namespace KurumsalMimari.MvcWebUI.Services
{
    public interface ICartSessionServices
    {
        Cart GetCart();
        void SetCard(Cart cart);
    }
}
