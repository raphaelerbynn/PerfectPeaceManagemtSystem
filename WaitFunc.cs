using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    
    internal class WaitFunc
    {
        Pages.WaitForm wait;
        Thread loadThread;

        public void show()
        {
            loadThread = new Thread(new ThreadStart(loadingProcess));
            loadThread.Start();
        }

        public void show(Form parent)
        {
            loadThread = new Thread(new ParameterizedThreadStart(loadingProcess));
            loadThread.Start(parent);
        }

        public void close()
        {

            //wait.Close();
            if (wait != null)
            {
                
                wait.BeginInvoke(new ThreadStart(wait.closeWaitForm));
                wait = null;
                loadThread = null;
            }
        }


        private void loadingProcess()
        {
            wait = new Pages.WaitForm();
            wait.ShowDialog();
        }
        
        private void loadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new Pages.WaitForm(parent1);
            wait.ShowDialog();
        }
    }
}
