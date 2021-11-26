using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTool
{
    public partial class DocImageComponent : Component
    {
        public DocImageComponent()
        {
            InitializeComponent();
        }

        public DocImageComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
