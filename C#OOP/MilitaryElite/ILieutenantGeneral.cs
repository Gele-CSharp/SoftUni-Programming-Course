using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ILieutenantGeneral : IPrivate
    {
         ICollection<ISoldier> Privates { get; set; }
    }
}
