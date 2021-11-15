namespace EGNValidation
{
    public class ValidatorDigitsWeightGetter : IDigitsWeightGetter
    {
        public virtual long SumDigitsWeight(long EGN)
        {
            long sum = 0;

            EGN /= 10;
            long digit = EGN % 10;
            sum += digit * 6;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 3;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 7;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 9;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 10;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 5;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 8;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 4;

            EGN /= 10;
            digit = EGN % 10;
            sum += digit * 2;

            return sum;
        }
    }
}
