using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cardashians
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetButtonContent(Subject1, "Mathe", Brushes.Aquamarine);
        }



        private void SetButtonContent(Button button, string name, Brush color)
        {
            
            string buttonText = string.Concat(name.Select(c => c + "\n"));
            
            button.Content = buttonText.Replace("\n", Environment.NewLine);
            button.Background = color;
            

            /*TextBlock textBlock = new TextBlock();
            textBlock.Text = buttonText.Replace("\n", Environment.NewLine);
            textBlock.TextTrimming = TextTrimming.CharacterEllipsis;
            button.Content = textBlock;*/

            /*
            Grid grid = new Grid();
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;
            TextBlock textBlock = new TextBlock();
            textBlock.Text = buttonText;
            textBlock.MaxHeight = 10;
            textBlock.TextTrimming = TextTrimming.CharacterEllipsis;
            grid.Children.Add(textBlock);
            button.Content = grid;*/

        }

        
    }

}

