using System.Reflection;

namespace SquirrelTest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var assembly = Assembly.GetExecutingAssembly();

            //Exeの場所を表示
            ExeTextBox.Text = assembly.Location;

            //バージョン番号を表示
            VersionTextBox.Text = assembly.GetName().Version.ToString();
        }
    }
}
