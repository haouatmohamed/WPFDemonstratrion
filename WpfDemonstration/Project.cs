using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemonstration
{
    class Project
    {
        private string name;
        private ObservableCollection<string> pathsOfDependencies;
        public string Name { get { return name; }
            set
            { if (name != value)
                    name = value;
            }
        }

        public ObservableCollection<string> PathsOfDependencies { get {
                return pathsOfDependencies;
            } set {
                pathsOfDependencies = value;
            } }
    }
}
