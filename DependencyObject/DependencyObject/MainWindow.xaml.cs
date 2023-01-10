using System.Windows;

namespace DependencyObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //propdp
        //public int MyProperty
        //{
        //    get { return (int)GetValue(MyPropertyProperty); }
        //    set { SetValue(MyPropertyProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty MyPropertyProperty =
        //    DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



        public static int GetMyProperty(System.Windows.DependencyObject obj)
        {
            return (int)obj.GetValue(MyPropertyProperty);
        }
        public static void SetMyProperty(System.Windows.DependencyObject obj, int value)
        {
            obj.SetValue(MyPropertyProperty, value);
        }
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
