namespace WinFormsApp4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(@"MzM4Nzg0MEAzMjM2MmUzMDJlMzBLNERXQWUzaC96eUNQaGwrc09xblg5MTU0d25YeDc0Z3c5YTE4V0YwSHhjPQ==");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}