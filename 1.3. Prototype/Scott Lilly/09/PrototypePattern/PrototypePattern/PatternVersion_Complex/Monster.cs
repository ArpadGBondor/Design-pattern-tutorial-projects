using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PatternVersion_Complex
{
    public class Monster
    {
        public string Name { get; private set; }
        public int HitPoints { get; private set; }
        public List<LootTableEntity> LootTable { get; set; }

        public Monster(string name, int hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;

            // In this part, pretend we are populating LootTable using a database query.
            LootTable = new List<LootTableEntity>();

            LootTable.Add(new LootTableEntity { ItemId = 1, DropPercentage = 10 });
            LootTable.Add(new LootTableEntity { ItemId = 2, DropPercentage = 5 });
            LootTable.Add(new LootTableEntity { ItemId = 5, DropPercentage = 1 });
            LootTable.Add(new LootTableEntity { ItemId = 12, DropPercentage = 50 });
            LootTable.Add(new LootTableEntity { ItemId = 27, DropPercentage = 33 });
            LootTable.Add(new LootTableEntity { ItemId = 42, DropPercentage = 100 });
        }

        // private constructor called by Clone() method.
        // Does not need to connect to the database to populate the LootTable property.
        private Monster(string name, int hitPoints, List<LootTableEntity> lootTable)
        {
            Name = name;
            HitPoints = hitPoints;
            LootTable = lootTable;
        }
        public void ApplyDamage(int amountOfDamage)
        {
            HitPoints -= amountOfDamage;
        }

        // This version of Clone calls the private constructor,
        // to prevent re-running the database query to populate the LootTable.
        public Monster Clone()
        {
            return new Monster(Name, HitPoints,LootTable);
        }
    }
}
