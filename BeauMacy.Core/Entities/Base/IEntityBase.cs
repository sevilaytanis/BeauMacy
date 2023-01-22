using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeauMacy.Core.Entities.Base
{
    internal interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
