using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.UtilGoldArray
{
    public class ItemContents
    {
        public string Name;
        public string Description;

        public ItemContents(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name + " - " + Description;
        }

    }
}
