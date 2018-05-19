using System;
using System.Data.SqlClient;
using DevExpress.ExpressApp;

namespace WinSolution.Module {
    public sealed partial class WinSolutionModule : ModuleBase {
        public WinSolutionModule() {
            InitializeComponent();
        }
        public override void Setup(XafApplication application) {
            application.CreateCustomObjectSpaceProvider += application_CreateCustomObjectSpaceProvider;
            base.Setup(application);
        }
        private void application_CreateCustomObjectSpaceProvider(object sender, CreateCustomObjectSpaceProviderEventArgs e) {
            XafApplication application = (XafApplication)sender;
            application.CreateCustomObjectSpaceProvider -= application_CreateCustomObjectSpaceProvider;
            string connectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=(local);Initial Catalog=E1708";
            SqlConnection connection = new SqlConnection(connectionString);
            e.ObjectSpaceProvider = new ObjectSpaceProvider(new ConnectionDataStoreProvider(connection));
        }
    }
}