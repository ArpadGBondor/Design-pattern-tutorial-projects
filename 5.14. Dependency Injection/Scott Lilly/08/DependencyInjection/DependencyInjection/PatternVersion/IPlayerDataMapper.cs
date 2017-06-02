using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.PatternVersion
{
    public interface IPlayerDataMapper
    {
        bool PlayerNameExistInDatabase(string name);
        void InsertNewPlayerIntoDatabase(string name);
    }
}
