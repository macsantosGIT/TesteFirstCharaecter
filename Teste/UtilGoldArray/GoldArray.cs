using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.UtilGoldArray
{
    public class GoldArray
    {
        private List<ItemContents> goldList = new List<ItemContents>();

        public int Add(string name, string description)
        {
            goldList.Add(new ItemContents(name, description));
            return goldList.Count;
        }

        public int Add(ItemContents itemContents)
        {
            goldList.Add(itemContents);
            return goldList.Count;
        }

        public ItemContents GetItem(int index)
        {
            if (index < goldList.Count)
            {
                return goldList[index];
            }
            else
            {
                return null;
            }
        }

        public List<ItemContents> GetItems()
        {
            return goldList;
        }

        public bool RemoveItem(int index)
        {
            if (index < goldList.Count)
            {
                goldList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public ICustomIterator CreateIterator()
        {
            return new GoldArrayIterator1(goldList);
        }
    }
}
