using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindingsAvalonia.UriNavigation;

internal class BlazorNavigationInterception : INavigationInterception
{
    public Task EnableNavigationInterceptionAsync() => Task.CompletedTask;
}
