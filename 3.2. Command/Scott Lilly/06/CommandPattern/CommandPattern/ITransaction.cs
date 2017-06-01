using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}
