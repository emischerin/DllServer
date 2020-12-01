using DllServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.ComponentModel;

namespace DllServer
{
    public class DllExecutor
    {
        private ErrorHandler ep = new ErrorHandler();

        private Dictionary<string,Dll> running_dlls = new Dictionary<string, Dll>();
        private Dictionary<string,Dll> awaiting_dlls = new Dictionary<string, Dll>();
        public BindingList<Dll> running_dlls_data_source = new BindingList<Dll>();
        public BindingList<Dll> awaiting_dlls_data_source = new BindingList<Dll>();
        private Dictionary<string,Thread> running_dll_executing_threads = new Dictionary<string, Thread>();
        

        public BindingList<Dll> RunningDlls_data_source
        {
            get 
            { 
                                
                return running_dlls_data_source;
            }
        }
        
        public BindingList<Dll> AwaitingDlls_data_source
        {
            get
            {
                              
                return awaiting_dlls_data_source;
            }
        }

        public void StartDll(string dll_name)
        {
            if(ValidateOnStartDll(ref dll_name))
            {
                Dll to_start = awaiting_dlls[dll_name];

                awaiting_dlls.Remove(dll_name);

                running_dlls.Add(dll_name,to_start);
                               

                Thread t = new Thread(new ParameterizedThreadStart(StartExecutionThread));

                running_dll_executing_threads.Add(to_start.Name,t);

                t.Start(to_start);

            }

                        
        }

        public void StopDll(string dll_name) 
        {
            if(running_dll_executing_threads.ContainsKey(dll_name))
            {
                if(ValidateOnStopThread(dll_name))
                {
                    running_dll_executing_threads[dll_name].Abort();
                    running_dll_executing_threads.Remove(dll_name);

                    Dll tmp = running_dlls[dll_name];

                    running_dlls.Remove(dll_name);

                    awaiting_dlls.Add(dll_name,tmp);
                    

                }

                
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
                    awaiting_dlls_data_source.Add(dlls[0]);
                }
                else
                {
                    fail_to_load.Add(dlls[i].Name);
                }
                
                    
            }
                      

            ep.ShowFailedToLoadDlls(ref fail_to_load);
                                          
                

        }

        private bool ValidateOnStopThread(string dll_name)
        {
            ThreadState t = running_dll_executing_threads[dll_name].ThreadState;

            return t != ThreadState.Aborted || t != ThreadState.AbortRequested;
            
        }

        private bool ValidateOnStartDll(ref string dll_name)
        {
            return ((awaiting_dlls.ContainsKey(dll_name)) && 
                (!running_dlls.ContainsKey(dll_name)) && (!running_dll_executing_threads.ContainsKey(dll_name)));
        }
        

        private static void StartExecutionThread(object main)
        {
            
            Dll d = (main as Dll);

            try
            {
                
                Assembly a = Assembly.Load
               (
                    File.ReadAllBytes(d.Path)
                );

                


                MethodInfo entry_point = a.EntryPoint;

                if(entry_point != null)
                {
                                            
                    Type entry_point_type = entry_point.DeclaringType;
                    if(!entry_point_type.IsAbstract)
                    {
                        InvokeEntryPoint(entry_point,entry_point_type);
                    }
                                
                     else
                     {
                        IEnumerable<Type> exporting_types = a.ExportedTypes;
                        Type start_assembly_type = exporting_types.First().GetType();
                        InvokeEntryPoint(entry_point,start_assembly_type);
                    }


                }
                
                



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private static void InvokeEntryPoint(MethodInfo method_info,Type t)
        {
            object o = Activator.CreateInstance(t);
            method_info.Invoke(o, new object[1]);
        }
        
     
    }
}
