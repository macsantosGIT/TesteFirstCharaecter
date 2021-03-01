using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.UtilGoldArray
{
    public class GoldArrayIterator1 : ICustomIterator
    {
        private List<ItemContents> _itemsList = new List<ItemContents>();
        int position = 0;

        public GoldArrayIterator1(List<ItemContents> itemsList)
        {
            _itemsList = itemsList;
        }

        #region ICustomIterator Members

        public bool HasNext()
        {
            if (position < _itemsList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            ItemContents itemContents = _itemsList[position];
            position++;
            return itemContents;
        }
        #endregion
    }
}
