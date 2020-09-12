using Newtonsoft.Json;
using Switcher.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcher.Config
{
    public class ConfigManager
    {
        private static readonly string _config = AppDomain.CurrentDomain.BaseDirectory + "\\config.json";

        private static List<Project> _projects;

        public static List<Project> Projects
        {
            get
            {
                if (_projects == null)
                    _projects = new List<Project>();
                return _projects;
            }
            set => _projects = value;
        }

        static ConfigManager()
        {
            Load();
        }

        public static List<Project> Load()
        {
            if(!File.Exists(_config))
            {
                File.Create(_config);
            }
            var text = File.ReadAllText(_config);
            _projects = JsonConvert.DeserializeObject<List<Project>>(text) ?? new List<Project>();
            return _projects;
        }

        public static void Save()
        {
            var text = JsonConvert.SerializeObject(Projects, Formatting.Indented);
            File.WriteAllText(_config, text);
        }
    }
}
