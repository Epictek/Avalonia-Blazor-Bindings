using BlazorBindingsAvalonia.Navigation;

namespace BlazorBindingsAvalonia;

public interface IAvaloniaBlazorApplication
{
    IServiceProvider ServiceProvider { get; }

    void Initialize(IServiceProvider serviceProvider);

    AvaloniaNavigation Navigation { get; }
}
