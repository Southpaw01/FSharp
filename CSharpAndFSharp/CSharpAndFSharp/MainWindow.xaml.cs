using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;
using CountingSortCSharp;

namespace IST_Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<CountingSort.Person> people = new List<CountingSort.Person>()
            {
                new CountingSort.Person(23, "Sam", 175),
                new CountingSort.Person(17, "Jack", 183),
                new CountingSort.Person(17, "Dustin", 170),
                new CountingSort.Person(45, "Alex", 160)
            };

            Func<CountingSort.Person, int> func = person => person.Age;

            var sortedList = new Sorting().Sort(people, 200, func); // Record'ы F# сортировка C# программа C#

            foreach (var sl in sortedList)
            {
                lb1.Items.Add(sl);
            }


            IEnumerable<Book> books = new List<Book>()
            {
                new Book() { Pages = 123 },
                new Book() { Pages = 189},
                new Book() { Pages = 101},
                new Book() { Pages = 130}
            };

            var sList = CountingSort.sortBooksByPages(books, 200); // Классы C# сортировка F# программа C#

            foreach (var sl in sList)
            {
                lb2.Items.Add(sl.Pages);
            }
        }
    }
}
