using DllServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DllServer
{
    public class DllExecutor
    {
        private ErrorProvider ep = new ErrorProvider();

        private Dictionary<string,Dll> running_dlls = new Dictionary<string, Dll>();
        private Dictionary<string,Dll> awaiting_dlls = new Dictionary<string, Dll>();
        private Mutex awaiting_dll_mutex = new Mutex();
        private Mutex running_dlls_mutex = new Mutex();

        public List<Dll> RunningDlls_data_source
        {
            get { return new List<Dll>(running_dlls.Values);}
        }

        public List<Dll> AwaitingDlls_data_source
        {
            get { return new List<Dll>(awaiting_dlls.Values);}
        }



        public void AddDll(ref List<Dll> dlls)
        { 
            List<string> fail_to_load = new List<string>();
             
            awaiting_dll_mutex.WaitOne();

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

            awaiting_dll_mutex.ReleaseMutex();

            ep.ShowFailedToLoadDlls(ref fail_to_load);
                                          
                

        }
        
    }
}
