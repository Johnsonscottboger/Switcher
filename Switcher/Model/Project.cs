using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcher.Model
{
    public class Project
    {
        private List<Environment> _environments;

        public string Name { get; set; }

        public List<Environment> Environments 
        {
            get
            {
                if (this._environments == null)
                    this._environments = new List<Environment>();
                return this._environments;
            }
            set { this._environments = value; }
        }

        public Project()
        {

        }

        public Project(string name)
        {
            this.Name = name;
        }

        public Project(string name, List<Environment> environments)
        {
            this.Name = name;
            this.Environments = environments;
        }
    }
}
