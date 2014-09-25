using System;
using System.Threading;



public class AsyncTimer
{
    private volatile  Action<string> actionMethod;
    private volatile int interval;
    private volatile int ticks;

    public AsyncTimer(Action<string> actionMethod, int interval, int ticks)
    {
        this.ticks = ticks;
        this.interval = interval;
        this.actionMethod = actionMethod;
    }

    private void DoWork()
    {
         while (this.ticks > 0)
        {
            Thread.Sleep(this.interval);

            if (actionMethod != null)
            {
                actionMethod((this.ticks/1000) + "");
            }

            this.ticks -= 1000;
        }
    }

    public void Start()
    {
        Thread thread = new Thread(this.DoWork);
        thread.Start();
    }

}

