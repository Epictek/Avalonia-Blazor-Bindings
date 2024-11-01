using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindingsAvalonia.UriNavigation;

internal class BlazorScrollToLocationHash : IScrollToLocationHash
{
    public Task RefreshScrollPositionForHash(string locationAbsolute) => Task.CompletedTask;
}
