
namespace Binance.Spot.Models
{
    public struct PositionSide
    {
        private PositionSide(string value)
        {
            this.Value = value;
        }

        public static PositionSide LONG { get => new PositionSide("LONG"); }
        public static PositionSide SHORT { get => new PositionSide("SHORT"); }
        public static PositionSide BOTH { get => new PositionSide("BOTH"); }

        public string Value { get; private set; }

        public static implicit operator string(PositionSide enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}
