//Create class Fraction with private int fields numerator and denominator that can only be initialized on creation or in constructor

//Create a constructor to initialize these values

//Define operators unary and binary + and - (example: Fraction(-167, 100) - Fraction(3, 2) should result in "-317 / 100")

//Define the ! operator that will return reversed fraction - with numerator as denominator and denominator as numerator (For example, Fraction(-3, 100) results to "-100 / 3")

//Define binary  * and / operations.

//All operations should return simplified fractions.

//Define ToString() method which will return string representing Fraction in the format numerator / denominator. 

//Value should be simplified: numerator and denominator divided by the greatest common divisor. 

//if  numerator and denominator are both negative, the fraction should become positive. 

//If only denominator is negative the sign should be outputted before numerator without space.

//Define Equals method and operators == and !=. Fractions are equal if their simplified versions are equal. 

//(for example, 20/25 is equal to 4/5)

//Define GetHashCode() method with the implementation of your choice.
public class Fraction
{
    private readonly int numerator;
    private readonly int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        this.numerator = numerator;
        this.denominator = denominator;

        int gcd = GreatestCommonDivisor(Math.Abs(numerator), denominator);

        if (gcd != 1)
        {
            Simplify(gcd);
        }
    }

    private int GreatestCommonDivisor(int a, int b)
    {
        return b == 0 ? a : GreatestCommonDivisor(b, a % b);
    }

    private Fraction Simplify(int gcd)
    {
        if (denominator < 0)
        {
            return new Fraction(-numerator, -denominator);
        }

        var bufferNumerator = numerator;
        var bufferDenominator = denominator;

        return new Fraction(bufferNumerator /= gcd, bufferDenominator /= gcd);
    }

    public static Fraction operator +(Fraction a)
    {
        return new Fraction(a.numerator, a.denominator);
    }

    public static Fraction operator -(Fraction a)
    {
        return new Fraction(a.numerator, -a.denominator);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.numerator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator;
        int newDenominator = a.denominator * b.numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator !(Fraction fraction)
    {
        return new Fraction(-fraction.denominator, fraction.numerator);
    }
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{numerator} / {denominator}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction other)
            return numerator == other.numerator && denominator == other.denominator;

        return false;
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !a.Equals(b);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }
}