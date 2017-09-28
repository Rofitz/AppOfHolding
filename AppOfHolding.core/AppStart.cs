using MvvmCross.Core.ViewModels;

namespace AppOfHolding.core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<InventoryViewModel>();
        }
    }
}
