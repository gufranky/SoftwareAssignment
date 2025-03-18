using System;
using System.Threading;
namespace Assignment4_2
{
    public delegate void AlarmHandler(int hour,int minute,int second,int type);
    public class AlarmClock
    {
        private int hour, minute, second;
        public AlarmClock(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public event AlarmHandler Tick;
        public event AlarmHandler Alarm;
        public void OnTick()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            
            }
            Tick?.Invoke(hour, minute, second, 0);
            if (hour == 17 && minute == 24 && second == 00)
            {
                Alarm?.Invoke(hour, minute, second, 1);
            }
        }

    }
    public class Alarmout
    {
        public void Tick(int hour, int minute, int second, int type)
        {
            if (type == 0)
            {
                Console.WriteLine("Tick"+hour + ":" + minute + ":" + second);

            }
        }
        public void Alarm(int hour, int minute, int second, int type)
        {
            if (type == 1)
            {
                Console.WriteLine("Alarm" + hour + ":" + minute + ":" + second);
            }
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock(17, 23, 49);
            Alarmout alarmout = new Alarmout();
            alarmClock.Tick += alarmout.Tick;
            alarmClock.Alarm += alarmout.Alarm;
            for (int i = 0; i < 100; i++)
            {
                alarmClock.OnTick();
                Thread.Sleep(1000);
            }
        }
    }
}