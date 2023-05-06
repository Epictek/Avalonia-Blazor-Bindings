// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using CM = CommunityToolkit.Maui;
using CMV = CommunityToolkit.Maui.Views;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui.Graphics;
using MMP = Microsoft.Maui.Primitives;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.CommunityToolkit
{
    /// <summary>
    /// Represents a small View that pops up at front the Page. Implements <see cref="T:CommunityToolkit.Maui.Core.IPopup" />.
    /// </summary>
    public partial class Popup : BlazorBindings.Maui.Elements.Element
    {
        static Popup()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the popup can be dismissed by tapping outside of the Popup.
        /// </summary>
        [Parameter] public bool? CanBeDismissedByTappingOutsideOfPopup { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="P:CommunityToolkit.Maui.Views.Popup.Color" /> of the Popup.
        /// </summary>
        [Parameter] public Color Color { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.Maui.Controls.LayoutOptions" /> for positioning the <see cref="T:CommunityToolkit.Maui.Views.Popup" /> horizontally on the screen.
        /// </summary>
        [Parameter] public MMP.LayoutAlignment? HorizontalOptions { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="P:CommunityToolkit.Maui.Views.Popup.Size" /> of the Popup Display.
        /// </summary>
        [Parameter] public Size? Size { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.Maui.Controls.LayoutOptions" /> for positioning the <see cref="T:CommunityToolkit.Maui.Views.Popup" /> vertically on the screen.
        /// </summary>
        [Parameter] public MMP.LayoutAlignment? VerticalOptions { get; set; }
        /// <summary>
        /// Property that represents the Window that's showing the Popup.
        /// </summary>
        [Parameter] public MC.Window Window { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.Maui.Controls.View" /> content to render in the Popup.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public EventCallback<CM.Core.PopupClosedEventArgs> OnClosed { get; set; }
        [Parameter] public EventCallback<CM.Core.PopupOpenedEventArgs> OnOpened { get; set; }

        public new CMV.Popup NativeControl => (CMV.Popup)((BindableObject)this).NativeControl;

        protected override CMV.Popup CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(CanBeDismissedByTappingOutsideOfPopup):
                    if (!Equals(CanBeDismissedByTappingOutsideOfPopup, value))
                    {
                        CanBeDismissedByTappingOutsideOfPopup = (bool?)value;
                        NativeControl.CanBeDismissedByTappingOutsideOfPopup = CanBeDismissedByTappingOutsideOfPopup ?? (bool)CMV.Popup.CanBeDismissedByTappingOutsideOfPopupProperty.DefaultValue;
                    }
                    break;
                case nameof(Color):
                    if (!Equals(Color, value))
                    {
                        Color = (Color)value;
                        NativeControl.Color = Color;
                    }
                    break;
                case nameof(HorizontalOptions):
                    if (!Equals(HorizontalOptions, value))
                    {
                        HorizontalOptions = (MMP.LayoutAlignment?)value;
                        NativeControl.HorizontalOptions = HorizontalOptions ?? (MMP.LayoutAlignment)CMV.Popup.HorizontalOptionsProperty.DefaultValue;
                    }
                    break;
                case nameof(Size):
                    if (!Equals(Size, value))
                    {
                        Size = (Size?)value;
                        NativeControl.Size = Size ?? (Size)CMV.Popup.SizeProperty.DefaultValue;
                    }
                    break;
                case nameof(VerticalOptions):
                    if (!Equals(VerticalOptions, value))
                    {
                        VerticalOptions = (MMP.LayoutAlignment?)value;
                        NativeControl.VerticalOptions = VerticalOptions ?? (MMP.LayoutAlignment)CMV.Popup.VerticalOptionsProperty.DefaultValue;
                    }
                    break;
                case nameof(Window):
                    if (!Equals(Window, value))
                    {
                        Window = (MC.Window)value;
                        NativeControl.Window = Window;
                    }
                    break;
                case nameof(ChildContent):
                    ChildContent = (RenderFragment)value;
                    break;
                case nameof(OnClosed):
                    if (!Equals(OnClosed, value))
                    {
                        void NativeControlClosed(object sender, CM.Core.PopupClosedEventArgs e) => InvokeEventCallback(OnClosed, e);

                        OnClosed = (EventCallback<CM.Core.PopupClosedEventArgs>)value;
                        NativeControl.Closed -= NativeControlClosed;
                        NativeControl.Closed += NativeControlClosed;
                    }
                    break;
                case nameof(OnOpened):
                    if (!Equals(OnOpened, value))
                    {
                        void NativeControlOpened(object sender, CM.Core.PopupOpenedEventArgs e) => InvokeEventCallback(OnOpened, e);

                        OnOpened = (EventCallback<CM.Core.PopupOpenedEventArgs>)value;
                        NativeControl.Opened -= NativeControlOpened;
                        NativeControl.Opened += NativeControlOpened;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty<CMV.Popup>(builder, sequence++, ChildContent, (x, value) => x.Content = (MC.View)value);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
