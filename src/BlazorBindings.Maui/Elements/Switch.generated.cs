// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class Switch : View
    {
        static Switch()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public bool? IsToggled { get; set; }
        [Parameter] public Color OnColor { get; set; }
        [Parameter] public Color ThumbColor { get; set; }
        [Parameter] public EventCallback<bool> IsToggledChanged { get; set; }

        public new MC.Switch NativeControl => (MC.Switch)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.Switch();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(IsToggled):
                    if (!Equals(IsToggled, value))
                    {
                        IsToggled = (bool?)value;
                        NativeControl.IsToggled = IsToggled ?? (bool)MC.Switch.IsToggledProperty.DefaultValue;
                    }
                    break;
                case nameof(OnColor):
                    if (!Equals(OnColor, value))
                    {
                        OnColor = (Color)value;
                        NativeControl.OnColor = OnColor;
                    }
                    break;
                case nameof(ThumbColor):
                    if (!Equals(ThumbColor, value))
                    {
                        ThumbColor = (Color)value;
                        NativeControl.ThumbColor = ThumbColor;
                    }
                    break;
                case nameof(IsToggledChanged):
                    if (!Equals(IsToggledChanged, value))
                    {
                        void NativeControlToggled(object sender, MC.ToggledEventArgs e)
                        {
                            var value = NativeControl.IsToggled;
                            IsToggled = value;
                            IsToggledChanged.InvokeAsync(value);
                        }

                        IsToggledChanged = (EventCallback<bool>)value;
                        NativeControl.Toggled -= NativeControlToggled;
                        NativeControl.Toggled += NativeControlToggled;
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
