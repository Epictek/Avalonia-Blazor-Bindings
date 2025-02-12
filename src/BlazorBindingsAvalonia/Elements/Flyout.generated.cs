// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements
{
    public partial class Flyout : BlazorBindingsAvalonia.Elements.Primitives.PopupFlyoutBase
    {
        static Flyout()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the content to display in this flyout
        /// </summary>
        [Parameter] public object Content { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Styling.ControlTheme" /> that is applied to the container element generated for the flyout presenter.
        /// </summary>
        [Parameter] public global::Avalonia.Styling.ControlTheme FlyoutPresenterTheme { get; set; }

        public new AC.Flyout NativeControl => (AC.Flyout)((AvaloniaObject)this).NativeControl;

        protected override AC.Flyout CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Content):
                    if (!Equals(Content, value))
                    {
                        Content = (object)value;
                        NativeControl.Content = Content;
                    }
                    break;
                case nameof(FlyoutPresenterTheme):
                    if (!Equals(FlyoutPresenterTheme, value))
                    {
                        FlyoutPresenterTheme = (global::Avalonia.Styling.ControlTheme)value;
                        NativeControl.FlyoutPresenterTheme = FlyoutPresenterTheme;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
