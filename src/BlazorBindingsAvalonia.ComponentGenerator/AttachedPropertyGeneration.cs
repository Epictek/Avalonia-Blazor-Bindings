using System;

namespace BlazorBindingsAvalonia.ComponentGenerator;

[Flags]
public enum AttachedPropertyGeneration
{
    ExtensionMethods = 1,
    Elements = 2
}
