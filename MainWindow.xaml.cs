using System.Linq;
using System.Windows;

namespace WpfBitmapCacheRenderThreadFail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly int[] Items5000 = Enumerable.Range(0, 5000).ToArray();
        
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}