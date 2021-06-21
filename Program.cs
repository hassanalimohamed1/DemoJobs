using System;
using static System.Console;
namespace DemoJobs
{
    class DemoJobs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Harold’s Home Services!");
            Jobs job1 = new Jobs("wash windows", 3.5, 35.00);
            Jobs job2 = new Jobs("moving pots", 1, 15.00);
            job2.ChangeRate(5.0);
            job1.Display();
            job2.Display();
        }
    }

    class Jobs
    {
        private string description;
        private double Hours_to_complete;
        private double Per_hour_rate;
        private double Total_Fee;

        public string Descriptor
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }

        public double Time
        {
            set
            {
                Hours_to_complete = value;
                CalculateTotal();
            }
            get
            {
                return Hours_to_complete;
            }
        }

        public double Hourly
        {
            set
            {
                Per_hour_rate = value;
                CalculateTotal();
            }
            get
            {
                return Per_hour_rate;
            }
        }


        public double Total
        {

            get
            {
                return Total_Fee;
            }
        }

        public void CalculateTotal()
        {
            Total_Fee = Time * Hourly;

        }
        public void Display()
        {
            WriteLine($"This job: {Descriptor} for the duration of {Time} at the rate of {Hourly.ToString("C")} hourly.");
            WriteLine($"The revenue of the job will be {Total.ToString("C")}.");
        }
        public void ChangeRate(double amt)
        {
            if (Hourly < 20)
                Hourly += amt;


        }

        public Jobs(string jb, double tm, double hr)
        {
            Descriptor = jb;
            Time = tm;
            Hourly = hr;
        }
    }


}
