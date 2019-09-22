using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AppWindonws
{
    public class MeuWindowsService
    {
        public void Start()
        {
            var timer1 = new Timer();
            timer1.Interval = 10000;
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            timer1.Enabled = true;
            Console.WriteLine("Meu Serviço do Windows foi iniciado");

        }

        private void timer1_Tick(object sender,ElapsedEventArgs e)
        {
            Console.WriteLine("Meu Serviço do Windows sendo executado a cada 10 segundos ");
        }

        public void Stop()
        {
            Console.WriteLine("Meu Serviço do Windows Encerrou");
        }
    }
}
