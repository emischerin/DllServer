using DllServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace DllServer
{
    public class DllExecutor
    {
        private ErrorHandler ep = new ErrorHandler();

        private Dictionary<string,Dll> running_dlls = new Dictionary<string, Dll>();
        private Dictionary<string,Dll> awaiting_dlls = new Dictionary<string, Dll>();
        private List<Dll> running_dlls_data_source;
        private List<Dll> awaiting_dlls_data_source;
        private Dictionary<string,Thread> running_dll_executing_threads = new Dictionary<string, Thread>();
        

        public List<Dll> RunningDlls_data_source
        {
            get 
            { 
                
                running_dlls_data_source = running_dlls.Values.ToList();
                return running_dlls_data_source;
            }
        }
        
        public List<Dll> AwaitingDlls_data_source
        {
            get
            {
                
                awaiting_dlls_data_source = running_dlls.Values.ToList();
                return awaiting_dlls_data_source;
            }
        }

        public void StartDll(ref string dll_name)
        {
            if(ValidateOnStartDll(ref dll_name))
            {
                Dll to_start = awaiting_dlls[dll_name];

                awaiting_dlls.Remove(dll_name);

                running_dlls.Add(dll_name,to_start);
                               

                Thread t = new Thread(new ParameterizedThreadStart(StartExecutionThread));

                running_dll_executing_threads.Add(to_start.Name,t);

                t.Start();

            }

                        
        }

        public void AddDll(ref List<Dll> dlls)
        {   
            List<string> fail_to_load = new List<string>();
             
            

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
                      

            ep.ShowFailedToLoadDlls(ref fail_to_load);
                                          
                

        }

        private bool ValidateOnStartDll(ref string dll_name)
        {
            return ((awaiting_dlls.ContainsKey(dll_name)) && 
                (!running_dlls.ContainsKey(dll_name)) && (!running_dll_executing_threads.ContainsKey(dll_name)));
        }
        

        private static void StartExecutionThread(object main)
        {
            

            try
            {
                
                Assembly a = Assembly.LoadFrom
               (
                    (main as Dll).Path
                );
                a.GetType().GetMethod("Main").Invoke(a, null);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        
    }
}
