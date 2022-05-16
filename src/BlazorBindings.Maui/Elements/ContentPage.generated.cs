// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class ContentPage : TemplatedPage
    {
        static ContentPage()
        {
            ElementHandlerRegistry.RegisterElementHandler<ContentPage>(
                renderer => new ContentPageHandler(renderer, new MC.ContentPage()));

            RegisterAdditionalHandlers();
        }

        public new MC.ContentPage NativeControl => (ElementHandler as ContentPageHandler)?.ContentPageControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);


            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);

        static partial void RegisterAdditionalHandlers();
    }
}
