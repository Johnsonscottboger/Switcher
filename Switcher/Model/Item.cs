using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcher.Model
{
    public class Item
    {
        public string Name { get; set; }

        public string SourcePath { get; set; }

        public string TargetPath { get; set; }

        public Item()
        {

        }

        public Item(string name)
        {
            this.Name = name;
        }

        public Item(string name, string path)
        {
            this.Name = name;
            this.SourcePath = path;
        }
    }
}
