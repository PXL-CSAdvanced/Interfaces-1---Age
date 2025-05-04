using AgeCalculator.Models;
using System.Windows;

namespace AgeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            currentYearStatus.Content = $"Huidig jaar: {DateTime.Today.Year}";

            treeSpeciesComboBox.ItemsSource = Species.GetAll();
            dogBreedComboBox.ItemsSource = Breed.GetAll();
        }
    }
}