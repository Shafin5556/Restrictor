using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrictor.UI
{
    public partial class AppBlock : UserControl
    {
        private static AppBlock _instance;
        public static AppBlock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppBlock();
                return _instance;
            }
        }
        public AppBlock()
        {
            InitializeComponent();
        }

        private void AppBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
