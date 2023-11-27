<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/724076342/23.2.3%2B)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DevExpress Radial Gauge for .NET MAUI

This example shows how to use the [Radial Gauge](https://docs.devexpress.com/MAUI/404674/radial-gauge?v=23.2) control to create a dashboard panel in a .NET MAUI app.

![DevExpress Gauges for .NET MAUI - Smart home dashboard](/Images/resulting-dashboard.png)

## Implementation Details

1. To add circular gauges to the dashboard page, use the [RadialGauge](https://docs.devexpress.com/MAUI/DevExpress.Maui.Gauges.RadialGauge?v=23.2) component. Add different visual indicators ([MarkerIndicator](https://docs.devexpress.com/MAUI/DevExpress.Maui.Gauges.MarkerIndicator?v=23.2), [NeedleIndicator](https://docs.devexpress.com/MAUI/DevExpress.Maui.Gauges.NeedleIndicator?v=23.2), and [RangeIndicator](https://docs.devexpress.com/MAUI/DevExpress.Maui.Gauges.RangeIndicator?v=23.2)) to track sensor value changes. 

2. Use [DXStackLayout](https://docs.devexpress.com/MAUI/404688/layouts/stack-layout?v=23.2) and [DXDockLayout](https://docs.devexpress.com/MAUI/404689/layouts/dock-layout?v=23.2) component to align gauges on the page.

3. This example uses the [DXBorder](https://docs.devexpress.com/MAUI/403983/utility-controls/index?v=23.2#border) control to implement a card styled background for gauges.

4. To create a legend that lists rooms, this example utilizes the [DXCollectionView](https://docs.devexpress.com/MAUI/403324/collection-view/index?v=23.2) component and specifies its [ItemTemplate](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView.ItemTemplate?v=23.2) property.

## Files to Review

- [MainPage.xaml](./CS/MainPage.xaml)

## Documentation

- [Radial Gauge](https://docs.devexpress.com/MAUI/404674/radial-gauge?v=23.2)
- [Layouts](https://docs.devexpress.com/MAUI/404602/layouts/layouts?v=23.2)
- [Color Themes](https://docs.devexpress.com/MAUI/404636/common-concepts/themes?v=23.2)

## More Examples

* [DevExpress .NET MAUI Demo Center](https://github.com/DevExpress-Examples/maui-demo-app)
* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Data Grid](https://github.com/DevExpress-Examples/maui-data-grid-get-started)
* [Data Form](https://github.com/DevExpress-Examples/maui-data-form-get-started)
* [Data Editors](https://github.com/DevExpress-Examples/maui-editors-get-started)
* [Charts](https://github.com/DevExpress-Examples/maui-charts)
* [Scheduler](https://github.com/DevExpress-Examples/maui-scheduler-get-started)
* [Tab Page](https://github.com/DevExpress-Examples/maui-tab-page-get-started)
* [Tab View](https://github.com/DevExpress-Examples/maui-tab-view-get-started)
* [Drawer Page](https://github.com/DevExpress-Examples/maui-drawer-page-get-started)
* [Drawer View](https://github.com/DevExpress-Examples/maui-drawer-view-get-started)
* [Collection View](https://github.com/DevExpress-Examples/maui-collection-view-get-started)
* [Popup](https://github.com/DevExpress-Examples/maui-popup-get-started)
