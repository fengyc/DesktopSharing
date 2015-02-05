using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RDPCOMAPILib;

namespace DesktopSharing
{
    public partial class FormSharer : Form
    {
        private RDPSession rdpSession;

        public FormSharer()
        {
            InitializeComponent();
        }

        private void init()
        {
            rdpSession = new RDPSessionClass();
        }
    }
}
