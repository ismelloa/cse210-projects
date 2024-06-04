public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top  = 1;
        _bottom = 1;      
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;      
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;      
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    } 

    public double GetDecimalValue()
    {
        return (double) _top / _bottom;
    } 
}



// def create_fraction(top=1, bottom=1):
//     return {'top': top, 'bottom': bottom}

// def get_fraction_string(fraction):
//     return f"{fraction['top']}/{fraction['bottom']}"

// def get_decimal_value(fraction):
//     return fraction['top'] / fraction['bottom']

// def main():
//     # Create a new fraction using the default values
//     fraction1 = create_fraction()
//     print(get_fraction_string(fraction1))
//     print(get_decimal_value(fraction1))

//     # Create a fraction with the top value 5 and default bottom value
//     fraction2 = create_fraction(5)
//     print(get_fraction_string(fraction2))
//     print(get_decimal_value(fraction2))

//     # Create a fraction with top value 3 and bottom value 4
//     fraction3 = create_fraction(3, 4)
//     print(get_fraction_string(fraction3))
//     print(get_decimal_value(fraction3))

//     # Create a fraction with top value 1 and bottom value 3
//     fraction4 = create_fraction(1, 3)
//     print(get_fraction_string(fraction4))
//     print(get_decimal_value(fraction4))

// if __name__ == "__main__":
//     main()
