namespace EGNValidation
{
    public class CreatorDigitsWeightGetter : ValidatorDigitsWeightGetter
    {
        public override long SumDigitsWeight(long EGN)
        {
            EGN *= 10;
            return base.SumDigitsWeight(EGN);
        }
    }
}
