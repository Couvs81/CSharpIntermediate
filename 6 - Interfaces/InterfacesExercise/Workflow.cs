namespace InterfacesExercise
{
    public class Workflow
    {
        private readonly List<IActivity> _workflowActivities;

        public Workflow()
        {
            _workflowActivities = new List<IActivity>();
        }

        public void InitalizeActivity(IActivity activity)
        {
            _workflowActivities.Add(activity);
        }

        public void RunWorkflow()
        {
            foreach (var activity in _workflowActivities)
            {
                activity.Execute();
            }
        }
    }
}


