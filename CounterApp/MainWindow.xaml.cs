using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CounterApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int _counter = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void IncrementButton_Click(object sender, RoutedEventArgs e)
    {
        _counter++;
        UpdateCounterDisplay();
    }

    private void DecrementButton_Click(object sender, RoutedEventArgs e)
    {
        _counter--;
        UpdateCounterDisplay();
    }

    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
        _counter = 0;
        UpdateCounterDisplay();
    }

    private void UpdateCounterDisplay()
    {
        CounterText.Text = _counter.ToString();
    }
}