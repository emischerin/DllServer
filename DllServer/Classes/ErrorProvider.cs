using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllServer.Classes
{
    public class ErrorProvider
    {
        public void ShowFailedToLoadDlls(ref List<string> failed_to_load)
        {
            if(failed_to_load.Count == 0) return;

            String Errormessage = "Unable to load dlls:";
            char separator = '\n';
            StringBuilder sb = new StringBuilder();
            
            sb.Append(Errormessage);
            sb.Append(separator);

            for(int i = 0; i < failed_to_load.Count;++i)
            {
                sb.Append(failed_to_load[i]);
                sb.Append(separator);
            }
           


            MessageBox.Show(sb.ToString());
        }

       
    }
}
