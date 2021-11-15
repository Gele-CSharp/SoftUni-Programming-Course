using System;

namespace EGNValidation
{
    public interface IEGNValidator
    {
         bool isEGNValid(string egn);

         string[] GenatateEGNS(DateTime birthDate, string region, bool isMale);
        
    }
}
