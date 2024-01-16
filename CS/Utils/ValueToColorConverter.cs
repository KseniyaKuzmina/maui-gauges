using System.Globalization;
namespace maui_gauges {
    public class ValueToColorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is not double chargeLevel) {
                throw new NotImplementedException();
            }

            double hue = chargeLevel * 120d / 360d;
            double saturation = 0.79d - 0.45d * chargeLevel * chargeLevel;
            double luminosity = 0.59d;

            return Color.FromHsla(hue, saturation, luminosity);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
