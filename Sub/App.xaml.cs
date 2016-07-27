using System.Threading.Tasks;
using Squirrel;

namespace SquirrelTest
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App
    {
        public App()
        {
            Task.Run(async () =>
            {
                using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/YoshihiroIto/SquirrelTest"))
                {
                    await mgr.Result.UpdateApp();
                }
            });
        }
    }
}
