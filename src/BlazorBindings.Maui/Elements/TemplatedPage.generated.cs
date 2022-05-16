// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class TemplatedPage : Page
    {
        static TemplatedPage()
        {
            ElementHandlerRegistry.RegisterElementHandler<TemplatedPage>(
                renderer => new TemplatedPageHandler(renderer, new MC.TemplatedPage()));

            RegisterAdditionalHandlers();
        }

        public new MC.TemplatedPage NativeControl => (ElementHandler as TemplatedPageHandler)?.TemplatedPageControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);


            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);

        static partial void RegisterAdditionalHandlers();
    }
}
