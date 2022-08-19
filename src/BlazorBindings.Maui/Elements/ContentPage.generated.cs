// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class ContentPage : TemplatedPage
    {
        static ContentPage()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<ContentPage>(nameof(ChildContent),
                _ => new ContentPropertyHandler<MC.ContentPage>((x, value) => x.Content = (MC.View)value));
            RegisterAdditionalHandlers();
        }

        [Parameter] public RenderFragment ChildContent { get; set; }

        public new MC.ContentPage NativeControl => (MC.ContentPage)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.ContentPage();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(ChildContent):
                    ChildContent = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(ContentPage), ChildContent);;
        }

        static partial void RegisterAdditionalHandlers();
    }
}
