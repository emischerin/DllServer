﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DllServer.Classes;

namespace DllServer.Forms
{
    public partial class TaskManagerForm : Form
    {
        private DllExecutor dll_executor;
        public TaskManagerForm(DllExecutor de)
        {
            
            InitializeComponent();
            this.dll_executor = de;
            AwaitingDlls_DataGrid.DataSource = de.AwaitingDlls_data_source;
            
            
        }

        private void StartDllButton_Click(object sender, EventArgs e)
        {
            Dll selected_dll;
            if((dll_executor != null) && 
                (selected_dll = (AwaitingDlls_DataGrid.SelectedRows[0].DataBoundItem as Dll)) != null)
            {                
                dll_executor.StartDll(selected_dll.Name);
            }
        }

        private void StopDllButton_Click(object sender, EventArgs e)
        {
            Dll selected_dll;
            if ((dll_executor != null) &&
                (selected_dll = (RunningDlls_DataGrid.SelectedRows[0].DataBoundItem as Dll)) != null)
            {
                dll_executor.StopDll(selected_dll.Name);
            }
        }
    }
}
