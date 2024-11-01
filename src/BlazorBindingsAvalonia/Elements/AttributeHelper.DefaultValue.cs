//Copyright(c) Microsoft Corporation.
// Licensed under the MIT license.

namespace BlazorBindingsAvalonia.Elements;

public static partial class AttributeHelper
{
    public static object? GetDefaultValue<TValue>(this DirectPropertyBase<TValue> directProperty, Type ownerType)
    {
        var unset = directProperty.GetUnsetValue(ownerType);
        return unset;
    }
}
