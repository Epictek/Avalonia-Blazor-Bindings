// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class RadioButton : TemplatedView
    {
        static RadioButton()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color BorderColor { get; set; }
        [Parameter] public double? BorderWidth { get; set; }
        [Parameter] public double? CharacterSpacing { get; set; }
        [Parameter] public int? CornerRadius { get; set; }
        [Parameter] public MC.FontAttributes? FontAttributes { get; set; }
        [Parameter] public bool? FontAutoScalingEnabled { get; set; }
        [Parameter] public string FontFamily { get; set; }
        [Parameter] public double? FontSize { get; set; }
        [Parameter] public string GroupName { get; set; }
        [Parameter] public bool? IsChecked { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public TextTransform? TextTransform { get; set; }
        [Parameter] public EventCallback<bool> IsCheckedChanged { get; set; }

        public new MC.RadioButton NativeControl => (MC.RadioButton)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.RadioButton();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(BorderColor):
                    if (!Equals(BorderColor, value))
                    {
                        BorderColor = (Color)value;
                        NativeControl.BorderColor = BorderColor;
                    }
                    break;
                case nameof(BorderWidth):
                    if (!Equals(BorderWidth, value))
                    {
                        BorderWidth = (double?)value;
                        NativeControl.BorderWidth = BorderWidth ?? (double)MC.RadioButton.BorderWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(CharacterSpacing):
                    if (!Equals(CharacterSpacing, value))
                    {
                        CharacterSpacing = (double?)value;
                        NativeControl.CharacterSpacing = CharacterSpacing ?? (double)MC.RadioButton.CharacterSpacingProperty.DefaultValue;
                    }
                    break;
                case nameof(CornerRadius):
                    if (!Equals(CornerRadius, value))
                    {
                        CornerRadius = (int?)value;
                        NativeControl.CornerRadius = CornerRadius ?? (int)MC.RadioButton.CornerRadiusProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAttributes):
                    if (!Equals(FontAttributes, value))
                    {
                        FontAttributes = (MC.FontAttributes?)value;
                        NativeControl.FontAttributes = FontAttributes ?? (MC.FontAttributes)MC.RadioButton.FontAttributesProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAutoScalingEnabled):
                    if (!Equals(FontAutoScalingEnabled, value))
                    {
                        FontAutoScalingEnabled = (bool?)value;
                        NativeControl.FontAutoScalingEnabled = FontAutoScalingEnabled ?? (bool)MC.RadioButton.FontAutoScalingEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)MC.RadioButton.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(GroupName):
                    if (!Equals(GroupName, value))
                    {
                        GroupName = (string)value;
                        NativeControl.GroupName = GroupName;
                    }
                    break;
                case nameof(IsChecked):
                    if (!Equals(IsChecked, value))
                    {
                        IsChecked = (bool?)value;
                        NativeControl.IsChecked = IsChecked ?? (bool)MC.RadioButton.IsCheckedProperty.DefaultValue;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(TextTransform):
                    if (!Equals(TextTransform, value))
                    {
                        TextTransform = (TextTransform?)value;
                        NativeControl.TextTransform = TextTransform ?? (TextTransform)MC.RadioButton.TextTransformProperty.DefaultValue;
                    }
                    break;
                case nameof(IsCheckedChanged):
                    if (!Equals(IsCheckedChanged, value))
                    {
                        void NativeControlCheckedChanged(object sender, MC.CheckedChangedEventArgs e)
                        {
                            var value = NativeControl.IsChecked;
                            IsChecked = value;
                            IsCheckedChanged.InvokeAsync(value);
                        }

                        IsCheckedChanged = (EventCallback<bool>)value;
                        NativeControl.CheckedChanged -= NativeControlCheckedChanged;
                        NativeControl.CheckedChanged += NativeControlCheckedChanged;
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
