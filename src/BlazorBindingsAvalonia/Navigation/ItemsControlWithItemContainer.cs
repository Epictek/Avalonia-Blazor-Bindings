using Avalonia.Controls;

namespace BlazorBindingsAvalonia.Navigation;

public class ItemsControlWithItemContainer : ItemsControl
{
    protected override bool NeedsContainerOverride(object item, int index, out object recycleKey)
    {
        recycleKey = DefaultRecycleKey;
        return true;
    }
}