using Microsoft.Extensions.Logging;
using WalletManager.Database;
using WalletManager.Service;

namespace WalletManager
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.Services.AddSingleton<JsonFileService<DataStore>>();

            builder.Services.AddMauiBlazorWebView();
           /* builder.Services.AddSingleton<Appdbcontext>();*/




#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
