namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.TextFile);

            ApplicationConfiguration.Initialize();
            Application.Run(new CreatePrizeForm());
        }
    }
}