﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

#pragma warning disable CA1812 // Avoid uninstantiated internal classes. Class is used as generic parameter.
internal class DataTemplateItemsComponent<TControl, TItem> : NativeControlComponentBase, IContainerElementHandler, INonPhysicalChild
#pragma warning restore CA1812 // Avoid uninstantiated internal classes
{
    protected override RenderFragment GetChildContent() => builder =>
    {
        foreach (var itemRoot in _itemRoots)
        {
            builder.OpenComponent<InitializedContentView>(1);

            builder.AddAttribute(2, nameof(InitializedContentView.NativeControl), itemRoot);
            builder.AddAttribute(3, "ChildContent", (RenderFragment)(builder =>
            {
                builder.OpenComponent<DataTemplateItemComponent<TItem>>(4);
                builder.AddAttribute(5, nameof(DataTemplateItemComponent<TItem>.ContentView), itemRoot);
                builder.AddAttribute(6, nameof(DataTemplateItemComponent<TItem>.Template), Template);
                builder.CloseComponent();
            }));

            builder.CloseComponent();
        }
    };

    //[Parameter] public Action<TControl, Avalonia.Controls.Templates.ITemplate<object, Avalonia.Controls.Control>> SetDataTemplateAction { get; set; }
    [Parameter] public Action<TControl, Avalonia.Controls.Templates.IDataTemplate> SetDataTemplateAction { get; set; }
    [Parameter] public RenderFragment<TItem> Template { get; set; }

    private readonly List<AvaloniaContentView> _itemRoots = new();

    public Avalonia.Controls.ContentControl AddTemplateRoot()
    {
        var templateRoot = new AvaloniaContentView();
        _itemRoots.Add(templateRoot);
        StateHasChanged();
        return templateRoot;
    }

    void INonPhysicalChild.SetParent(object parentElement)
    {
        var parent = (TControl)parentElement;
        //var dataTemplate = new AvaloniaDataTemplate();
        var dataTemplate = new global::Avalonia.Controls.Templates.FuncDataTemplate(typeof(TItem), (item, namescope) => AddTemplateRoot());
        //dataTemplate.Content = AddTemplateRoot();
        SetDataTemplateAction(parent, dataTemplate);
    }

    void INonPhysicalChild.RemoveFromParent(object parentElement) { }
    object IElementHandler.TargetElement => null;
    void IContainerElementHandler.AddChild(object child, int physicalSiblingIndex) { }
    void IContainerElementHandler.RemoveChild(object child, int physicalSiblingIndex) { }
}
