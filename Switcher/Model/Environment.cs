using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcher.Model
{
    public class Environment
    {
        private List<Item> _items;

        public string Name { get; set; }

        public List<Item> Items 
        {
            get
            {
                if (this._items == null)
                    this._items = new List<Item>();
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }

        public Environment()
        {

        }

        public Environment(string name)
        {
            this.Name = name;
        }

        public Environment(string name, List<Item> items)
        {
            this.Name = name;
            this.Items = items;
        }
    }
}
