using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace SampleMVVM.Views
{
    public partial class MainView : Window
    {
        MainViewModel mainViewModel = null;

        internal MainView(MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.mainViewModel = mainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = NewName.Text;
            string author = NewAuthor.Text;
            int count = 10;

            ObservableCollection<BookViewModel> BooksList = mainViewModel.BooksList;

            foreach (BookViewModel book in BooksList)
            {
                if (book.Author.ToLower() == author.ToLower() 
                    && book.Title.ToLower() == title.ToLower())
                {
                    MessageBox.Show("Такая книга уже есть!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            BookViewModel viewModel = new BookViewModel(new Book(title, author, count));
            BooksList.Add(viewModel);
        }
    }
}
