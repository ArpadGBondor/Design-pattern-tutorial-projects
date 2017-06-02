using DependencyInjection.PatternVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.PatternVersion.Tests
{
    public class MockPlayerDataMapper : IPlayerDataMapper
    {
        //private readonly List<string> mockDB;

        //public MockPlayerDataMapper()
        //{
        //    mockDB = new List<string>();
        //}
        //public void InsertNewPlayerIntoDatabase(string name)
        //{
        //    mockDB.Add(name);
        //}

        //public bool PlayerNameExistInDatabase(string name)
        //{
        //    return mockDB.Any(x => x == name);
        //}

        // This property holds the value for PlayerNameExistInDatabase to return.
        // This lets us "mock" the results that we would recieve from a real database.
        public bool ResultToReturn { get; set; }

        // These functions implement the IPlayerDataMapper interface
        public bool PlayerNameExistInDatabase(string name)
        {
            // This is whatever answer we need, for current unit test
            return ResultToReturn;
        }

        public void InsertNewPlayerIntoDatabase(string name)
        {
        }
    }
    
}
