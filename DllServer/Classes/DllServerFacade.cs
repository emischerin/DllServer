using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using DllServer.Classes;
using DllServer.Forms;

namespace DllServer
{
    public class DllServerFacade
    {
        private DllLoader dllloader = new DllLoader();
        private DllExecutor dllexecutor = new DllExecutor();

        public void OpenAddDllWindow()
        {
            using(OpenFileDialog opfd = new OpenFileDialog())
            {
                
                opfd.InitialDirectory = "c:\\";
                
                opfd.Filter = "Dlls (*.dll)|*.dll";
                opfd.Multiselect = true;
                

                if(opfd.ShowDialog() == DialogResult.OK)
                {
                    
                    
                    List<Dll> newdlls = dllloader.ParseFiles(opfd.FileNames);
                    
                    dllexecutor.AddDll(ref newdlls);
                                             
                   
                  
                }
            }
        }
        

        public void OpenTaskManagerWindow()
        {
            TaskManagerForm tmf = new TaskManagerForm();
            tmf.ShowDialog();
            
        }

        private void ThOpenTaskManagerWindow()
        {
                        
        }

        private void ThOpenAddDllWindow()
        {
           
        }

    }
}
