using DevExpress.Maui.Core;
using DevExpress.Maui.Gauges;
using SkiaSharp.Views.Maui;

namespace maui_gauges {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void OnCustomizeTickmark(object sender, DevExpress.Maui.Gauges.CustomizeTickmarkEventArgs e) {
            RadialScale scale = (RadialScale)sender;
            if (e.Value != scale.StartValue && e.Value != scale.EndValue) {
                Color tickMarkColor = e.IsMajor ? ThemeManager.Theme.Scheme.OnSurfaceVariant : ThemeManager.Theme.Scheme.OutlineVariant;
                e.Paint = new SkiaSharp.SKPaint() {
                    Color = tickMarkColor.ToSKColor(),
                    IsAntialias = true,
                    IsStroke = true,
                    StrokeWidth = (float)((e.IsMajor ? scale.MajorTickmarkThickness : scale.MinorTickmarkThickness) * DeviceDisplay.MainDisplayInfo.Density),
                    StrokeCap = SkiaSharp.SKStrokeCap.Round,
                };
                e.Offset = e.IsMajor ? scale.MajorTickmarkOffset : scale.MinorTickmarkOffset;
                e.Length = e.IsMajor ? scale.MajorTickmarkLength : scale.MinorTickmarkLength;
                return;
            }

            Color color = e.Value == scale.StartValue ? Color.FromArgb("#9BBB72") : Color.FromArgb("#EF938D");

            e.Paint = new SkiaSharp.SKPaint() {
                Color = color.ToSKColor(),
                IsAntialias = true,
                IsStroke = true,
                StrokeWidth = (float)(scale.MajorTickmarkThickness * DeviceDisplay.MainDisplayInfo.Density),
                StrokeCap = SkiaSharp.SKStrokeCap.Round,
            };
            e.Length = ON.Idiom(14d, 20d);
            e.Offset = -scale.Thickness / 2d - e.Length / 2d;
        }
    }
}