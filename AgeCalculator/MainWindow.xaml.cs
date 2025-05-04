using AgeCalculator.Models;
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

        private void ShowAge(IAge objectWithAge)
        {
            MessageBox.Show(this, $"Leeftijd: {objectWithAge.Age}", objectWithAge.Name);
        }

        private void OnCalculatePersonAge(object sender, RoutedEventArgs e)
        {
            Person p = new Person(personFirstNameTextBox.Text, personLastNameTextBox.Text, personBirthDatePicker.SelectedDate.Value);
            ShowAge(p);
        }

        private void OnCalculateDogAge(object sender, RoutedEventArgs e)
        {
            Dog d = new Dog(dogNameTextBox.Text, (Breed)dogBreedComboBox.SelectedItem, int.Parse(dogBirthYearTextBox.Text));
            ShowAge(d);
        }

        private void OnCalculateTreeAge(object sender, RoutedEventArgs e)
        {
            Tree t = new Tree((Species)treeSpeciesComboBox.SelectedItem, int.Parse(treeCircumferenceTextBox.Text));
            ShowAge(t);
        }
    }
}