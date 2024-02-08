using System;


namespace DelgateEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProcessBusinessLogic bl= new ProcessBusinessLogic();
            // register with an event
            bl.ProcessCompleted += b2_ProcessCompleted;
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.ProcessStarted += b3_ProcessStarted;
            bl.ProcessStarted += bl_ProcessCompleted;
            bl.StartProcess();
            Console.ReadLine();

            //deregistering events
            bl.ProcessStarted -= bl_ProcessCompleted;
            bl.ProcessCompleted -= b2_ProcessCompleted;
            bl.StartProcess();
            Console.ReadLine();
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed by bl_ProcessCompleted");
        }

        public static void b2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed b2_ProcessCompleted");
        }

        public static void b3_ProcessStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Started b3_ProcessStarted");
        }

    }

    public class ProcessBusinessLogic
    {
        public event EventHandler ProcessCompleted;
        public event EventHandler ProcessStarted;
        
        public void StartProcess()
        {
            Console.WriteLine("Process started");
            OnProcessStarted(EventArgs.Empty);
            OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessStarted(EventArgs e)
        {
            ProcessStarted?.Invoke(this, e);  
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}

