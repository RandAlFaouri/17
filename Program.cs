internal class Program
{
    private static void Main(string[] args)
    {
        var day = (DAY.SATURDAY | DAY.SUNDAY);
        if (day.HasFlag(DAY.WEEKEND)) {
            Console.WriteLine("Enjoy your weekend");
        }

    }
}
enum Month
{
    JAN=1,
    FEB,
    MAR,
    APR,
    MAY,
    JUN,
    JUL,
    AUG,
    SEP,
    OCT,
    NOV,
    DEC
}
[Flags]
enum DAY
{
    NONE = 0b_0000_0000,
    MONDAY = 0b_0000_0001,
    TUESDAY = 0b_0000_0010,
    WEDNSDAY = 0b_0000_0100,
    THURSDAY = 0b_0000_1000,
    FRIDAY = 0b_0001_0000,
    SATURDAY = 0b_0010_0000,
    SUNDAY = 0b_0100_0000,
    BUSDAY = MONDAY | TUESDAY | WEDNSDAY | THURSDAY | FRIDAY,
    WEEKEND=SATURDAY | SUNDAY
}