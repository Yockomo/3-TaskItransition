using System.Collections.Generic;
using ConsoleTables;
using System.Linq;

namespace _3_Itransition
{
    class Table
    {
        public void Print(string[] names ,Dictionary<string,string> objectRelations)
        {
            var headerItems = names.Prepend("User \\ PC");
            var table = new ConsoleTable(headerItems.ToArray());
            for(int i =1; i <= names.Length;i++)
            {
                var currentRow = new string[names.Length + 1];
                currentRow[0] = names[i-1];
                for (int j = 1; j <= names.Length; j++)
                    currentRow[j] = objectRelations[names[i-1] + names[j-1]];
                table.AddRow(currentRow);
            }
            table.Write(Format.Alternative);
        }
    }
}
