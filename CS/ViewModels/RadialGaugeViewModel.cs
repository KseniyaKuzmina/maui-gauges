using System.Collections.ObjectModel;
namespace maui_gauges;

public class RadialGaugeViewModel : NotificationObject {
    public ObservableCollection<RoomInfo> Rooms { get; }

    public RadialGaugeViewModel() {
        this.livingRoomPowerLevelBrush = new(Color.FromArgb("#9BBB72"));
        this.bedroomPowerLevelBrush = new(Color.FromArgb("#6486C9"));
        this.kitchenPowerLevelBrush = new(Color.FromArgb("#B26C79"));

        Rooms = new ObservableCollection<RoomInfo> {
            new RoomInfo { Room = "Living Room", Color = this.livingRoomPowerLevelBrush.Color, Value = 0.79 },
            new RoomInfo { Room = "Bedroom", Color = this.bedroomPowerLevelBrush.Color, Value = 0.19 },
            new RoomInfo { Room = "Kitchen", Color = this.kitchenPowerLevelBrush.Color, Value = 0.49 },
        };
        this.livingRoomPowerLevel = Rooms[0].Value;
        this.bedroomPowerLevel = Rooms[1].Value;
        this.kitchenPowerLevel = Rooms[2].Value;
    }

    double livingRoomPowerLevel;
    public double LivingRoomPowerLevel {
        get => this.livingRoomPowerLevel;
        set => SetProperty(ref livingRoomPowerLevel, value);
    }

    double bedroomPowerLevel;
    public double BedroomPowerLevel {
        get => bedroomPowerLevel;
        set => SetProperty(ref bedroomPowerLevel, value);
    }

    double kitchenPowerLevel;
    public double KitchenPowerLevel {
        get => kitchenPowerLevel;
        set => SetProperty(ref kitchenPowerLevel, value);
    }

    SolidColorBrush livingRoomPowerLevelBrush;
    public SolidColorBrush LivingRoomPowerLevelBrush {
        get => livingRoomPowerLevelBrush;
        set => SetProperty(ref livingRoomPowerLevelBrush, value);
    }

    SolidColorBrush bedroomPowerLevelBrush;
    public SolidColorBrush BedroomPowerLevelBrush {
        get => bedroomPowerLevelBrush;
        set => SetProperty(ref bedroomPowerLevelBrush, value);
    }

    SolidColorBrush kitchenPowerLevelBrush;
    public SolidColorBrush KitchenPowerLevelBrush {
        get => kitchenPowerLevelBrush;
        set => SetProperty(ref kitchenPowerLevelBrush, value);
    }
}

public class RoomInfo : NotificationObject {
    Color color;
    public Color Color {
        get => this.color;
        set => SetProperty(ref this.color, value);
    }
    double value;
    public double Value {
        get => this.value;
        set => SetProperty(ref this.value, value);
    }

    public string Room { get; init; }
}