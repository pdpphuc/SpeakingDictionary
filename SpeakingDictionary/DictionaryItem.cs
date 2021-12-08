using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakingDictionary
{
    [Serializable]
    public class DictionaryItem
    {
        private List<DictionaryData> items;

        public List<DictionaryData> Items { get => items; set => items = value; }

    }
}
