namespace ClassExercises
{
    public class StopWatch()
    {
        private DateTime _startTime = new DateTime();
        private DateTime _endTime = new DateTime();
        private bool _active = false;

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
                
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = DateTime.Now; }
        }

        private bool Active
        { 
            get { return _active; }
            set { _active = value; }
        }

        public void Start()
        {
            if (Active)
            {
                throw new InvalidOperationException("Stopwatch already running!");
            }
            if (StartTime == DateTime.MinValue)
            {
                StartTime = DateTime.Now;
                Active = true;
                Console.WriteLine("Stop Watch started at: {0}", StartTime);
            }
            else
            {
                Console.WriteLine("Stop watch resumed at: {0}", DateTime.Now);
                Active = true;
            }

        }

        public void Stop()
        {
            if (Active)
            {
                EndTime = DateTime.Now;
                Active = false;
                Console.WriteLine("Stopwatch Ended at: {0}", EndTime);
            }
        }

        public double Duration()
        {
            var duration = EndTime - StartTime;
            return duration.TotalSeconds;
        }
        
        public void Reset()
        {
            StartTime = DateTime.MinValue;
            Console.WriteLine("Stopwatch Reset!");
        }

    }
}
