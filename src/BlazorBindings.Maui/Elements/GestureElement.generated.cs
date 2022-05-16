// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class GestureElement : Element
    {
        static GestureElement()
        {
            ElementHandlerRegistry.RegisterElementHandler<GestureElement>(
                renderer => new GestureElementHandler(renderer, new MC.GestureElement()));

            RegisterAdditionalHandlers();
        }

        public new MC.GestureElement NativeControl => (ElementHandler as GestureElementHandler)?.GestureElementControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);


            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);

        static partial void RegisterAdditionalHandlers();
    }
}
