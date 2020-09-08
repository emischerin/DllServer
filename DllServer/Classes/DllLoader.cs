using DllServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DllServer
{
    public class DllLoader
    {
        public List<Dll> ParseFiles(string[] files)
        {
            List<Dll> newdlls = new List<Dll>();
            string filename,path;


            for(int i = 0; i < files.Length;++i)
            {
                filename = Path.GetFileName(files[i]);
                path = files[i];

                newdlls.Add
                (
                    new Dll {Name = filename,Path = path }
                );
            }

            return newdlls;
        }
    }
}
