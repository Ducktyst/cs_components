using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComponents1
{
    public partial class OutputListVisualComponent : Component
    {
        public OutputListVisualComponent()
        {
            InitializeComponent();
        }

        public OutputListVisualComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
