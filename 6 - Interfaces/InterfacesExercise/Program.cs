namespace InterfacesExercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow1 = new Workflow();
            workflow1.InitalizeActivity(new UploadVideo());
            workflow1.InitalizeActivity(new CallEncondingWebService());
            workflow1.InitalizeActivity(new SendNotification());
            workflow1.InitalizeActivity(new UpdateStatus());

            WorkflowEngine.Run(workflow1);
        }
    }
}
