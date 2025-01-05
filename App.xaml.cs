

using WalletManager.Database;

namespace WalletManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Database= new Appdbcontext();
            MainPage = new MainPage();

        }
        public static Appdbcontext Database {  get; private set; }
    }
}
