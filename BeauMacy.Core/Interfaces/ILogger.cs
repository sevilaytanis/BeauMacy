using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeauMacy.Core.Interfaces
{
    internal interface ILogger<T>
    {
        void Info(string message,params object[] args);
        void Warn(string message,params object[] args);

          
    }
}
