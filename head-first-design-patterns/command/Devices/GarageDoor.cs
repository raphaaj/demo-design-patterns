using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace command.Devices
{
    public class GarageDoor
    {
        private CancellationTokenSource UpCancelationToken = null;
        private CancellationTokenSource DownCancelationToken = null;

        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Down");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Door Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Door Light is Off");
        }

        public async Task UpAsync()
        {
            if (UpCancelationToken != null) return;

            UpCancelationToken = new CancellationTokenSource();
            
            Console.WriteLine("Opening Door");
            try
            {
                await Task.Delay(3000, UpCancelationToken.Token);
                Console.WriteLine("Garage Door is Open");
            }
            catch (OperationCanceledException) {
                Console.WriteLine("Garage Door is Stopped");
            }
            finally
            {
                UpCancelationToken = null;
            }
        }

        public async Task DownAsync()
        {
            if (DownCancelationToken != null) return;
            
            DownCancelationToken = new CancellationTokenSource();

            Console.WriteLine("Closing Door");
            try
            {
                await Task.Delay(3000, DownCancelationToken.Token);
                Console.WriteLine("Garage Door is Closed");
            }
            catch (OperationCanceledException) {
                Console.WriteLine("Garage Door is Stopped");
            }
            finally
            {
                DownCancelationToken = null;
            }
        }

        public void Stop()
        {
            if (UpCancelationToken != null) UpCancelationToken.Cancel();
            if (DownCancelationToken != null) DownCancelationToken.Cancel();
        }
    }
}
