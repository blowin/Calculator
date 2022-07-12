using System.Globalization;

namespace Calculator.Domain;

public interface IDigit
{
    decimal Value { get; }

    string ToString(string? format);
}

public abstract class DigitBase : IDigit
{
    public abstract decimal Value { get; }

    public override int GetHashCode() => Value.GetHashCode();

    public override bool Equals(object? obj) => obj is DigitBase db && db.Value == Value;

    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);

    public string ToString(string? format) => Value.ToString(format, CultureInfo.InvariantCulture);
}

public sealed class DecimalDigit : DigitBase
{
    public static DecimalDigit Zero => new DecimalDigit(0);

    public DecimalDigit(decimal value) => Value = value;

    public override decimal Value { get; }
}

public sealed class StringDigit : DigitBase
{
    private readonly string _value;

    public StringDigit(string value) => _value = value;

    public override decimal Value
    {
        get
        {
            var strValue = _value?.Replace(',', '.') ?? string.Empty;
            if (!decimal.TryParse(strValue, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
                throw new ArgumentException($"Invalid decimal value '{strValue}'");
            return result;
        }
    }
}

public sealed class CacheDigit : DigitBase
{
    private readonly Lazy<decimal> _lazyOriginal;

    public CacheDigit(IDigit original) => _lazyOriginal = new Lazy<decimal>(() => original.Value);

    public override decimal Value => _lazyOriginal.Value;
}