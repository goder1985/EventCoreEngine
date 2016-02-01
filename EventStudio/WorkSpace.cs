using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStudio
{
    public partial class WorkSpace : Component
    {
        public WorkSpace()
        {
            InitializeComponent();
        }

        public WorkSpace(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
