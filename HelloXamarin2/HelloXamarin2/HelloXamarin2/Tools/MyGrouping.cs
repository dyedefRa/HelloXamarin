using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloXamarin2.Tools
{
    public class MyGrouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; set; }
        public MyGrouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
