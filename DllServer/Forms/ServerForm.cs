using DllServer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllServer
{
    public partial class ServerForm : Form
    {
        private DllServerFacade dllsfacade = new DllServerFacade();

        public ServerForm()
        {
            InitializeComponent();
        }

        private void TaskManagerMenuItem_Click(object sender, EventArgs e)
        {
            dllsfacade.OpenTaskManagerWindow();
            
            
        }

        private void AddDllMenuItem_Click(object sender, EventArgs e)
        {
            
            dllsfacade.OpenAddDllWindow();
        }
    }
}
