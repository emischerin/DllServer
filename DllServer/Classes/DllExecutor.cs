using DllServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllServer
{
    public class DllExecutor
    {
        private ErrorProvider ep = new ErrorProvider();

        private Dictionary<string,Dll> running_dlls = new Dictionary<string, Dll>();
        private Dictionary<string,Dll> awaiting_dlls = new Dictionary<string, Dll>();
        private List<Dll> running_dlls_data_source;
        private List<Dll> awaiting_dlls_data_source;
        private Dictionary<string,Thread> running_dll_executing_thread = new Dictionary<string, Thread>();
        private Mutex awaiting_dlls_mutex = new Mutex();
        private Mutex running_dlls_mutex = new Mutex();

        public List<Dll> RunningDlls_data_source
        {
            get 
            { 
                running_dlls_mutex.WaitOne();
                running_dlls_data_source = running_dlls.Values.ToList();
                running_dlls_mutex.ReleaseMutex();
                return running_dlls_data_source;
            }
        }
        
        public List<Dll> AwaitingDlls_data_source
        {
            get
            {
                awaiting_dlls_mutex.WaitOne();
                awaiting_dlls_data_source = running_dlls.Values.ToList();
                awaiting_dlls_mutex.ReleaseMutex();
                return awaiting_dlls_data_source;
            }
        }

        public void StartDll(string dll_name)
        {
            
            Dll tmp;
            awaiting_dlls_mutex.WaitOne();

            if (!awaiting_dlls.ContainsKey(dll_name))
            {
                awaiting_dlls_mutex.ReleaseMutex();
                MessageBox.Show("Assembly wasn't loaded");
                return;
            }
            else
            {
                tmp = awaiting_dlls[dll_name];
                awaiting_dlls.Remove(dll_name);

                running_dlls_mutex.WaitOne();
                if(running_dlls.ContainsKey(dll_name))
                {
                    awaiting_dlls_mutex.ReleaseMutex();
                    running_dlls_mutex.ReleaseMutex();
                    return;
                }
                else
                {

                }

                
            }

            
        }

        public void AddDll(ref List<Dll> dlls)
        {  
            List<string> fail_to_load = new List<string>();
             
            awaiting_dlls_mutex.WaitOne();

            for(int i = 0; i < dlls.Count;++i)
            {
                if(!awaiting_dlls.ContainsKey(dlls[i].Name))
                {
                    awaiting_dlls.Add(dlls[i].Name,dlls[i]);
                }
                else
                {
                    fail_to_load.Add(dlls[i].Name);
                }
                
                    
            }

            awaiting_dlls_mutex.ReleaseMutex();

            ep.ShowFailedToLoadDlls(ref fail_to_load);
                                          
                

        }
        
    }
}
