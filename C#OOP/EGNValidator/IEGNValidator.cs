using System;

namespace EGNValidation
{
    public interface IEGNValidator
    {
         bool isEGNValid(string egn);

         string[] GenerateEGNS(DateTime birthDate, string region, bool isMale);
        
    }
}
