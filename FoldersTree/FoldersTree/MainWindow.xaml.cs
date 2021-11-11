using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace FoldersTree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string[] ParsingPath(string path)
        {
            string[] parts = path.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            return parts;
        }

        private TreeViewItem CreateTree(string[] parts)
        {
            TreeViewItem file = null;
            TreeViewItem folder = null;
            TreeViewItem tempFolder = null;

            for (int i = parts.Length - 1; i >= 0; i--)
            {
                if (Regex.IsMatch(parts[i], @"\w+\.(pdf|txt|doc|docx|png|gif|jpeg|jpg|zip|rar)$"))
                {
                    file = new TreeViewItem { Header = parts[i] };
                    i--;

                    folder = new TreeViewItem { Header = parts[i] };
                    folder.Items.Add(file);
                }
                else
                {
                    tempFolder = folder;

                    folder = new TreeViewItem { Header = parts[i] };
                    folder.Items.Add(tempFolder);
                }
            }

            return folder;
        }

        private void AddToExists(int index, string[] parts, ItemsControl parent, ref bool temp)
        {
            TreeViewItem treeViewItem = null;

            for (int i = 0; i < parent.Items.Count; i++)
            {
                treeViewItem = parent.Items[i] as TreeViewItem;

                if ((string)treeViewItem.Header != parts[index])
                {
                    temp = true;

                    string[] newParts = new string[parts.Length - index];

                    for (int j = index; j < parts.Length; j++)
                        newParts[j - index] = parts[j];


                    if (newParts.Length == 1)
                        parent.Items.Add(new TreeViewItem { Header = newParts[0] });
                    else
                        parent.Items.Add(CreateTree(newParts));

                    break;
                }
                else
                {
                    AddToExists(index + i + 1, parts, treeViewItem, ref temp);
                    break;
                }
            }
        }

        private void AlreadyExists()
        {
            MessageBox.Show("The dirictory or file already exists.", "Information",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Path.Text = Path.Text.Trim();

            string[] parts = ParsingPath(Path.Text);

            if (Tree.Items.Count == 0)
            {
                TreeViewItem treeViewItem = CreateTree(parts);
                Tree.Items.Add(treeViewItem);
            }
            else
            {
                bool temp = false;
                AddToExists(0, parts, Tree, ref temp);

                if (!temp)
                    AlreadyExists();
            }

            Path.Text = "";
        }

        private void Path_TextChanged(object sender, TextChangedEventArgs e)
        {
            MatchCollection matchCollection = Regex.Matches(Path.Text, @"\w+\\\w+\.(pdf|txt|doc|docx|png|gif|jpeg|jpg|zip|rar)$");

            if (matchCollection.Count == 1)
            {
                Path.Background = Brushes.LightGreen;
                Add.IsEnabled = true;
            }
            else
            {
                Path.Background = Brushes.LightCoral;
                Add.IsEnabled = false;
            }

            if (Path.Text.Length == 0)
                Path.Background = Brushes.White;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Tree.Items.Clear();
        }
        private ItemsControl GetParent(TreeViewItem item)
        {
            DependencyObject parent = item.Parent;
            return parent as ItemsControl;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            ItemsControl parent = null;
            TreeViewItem item = Tree.SelectedItem as TreeViewItem;
            parent = GetParent(item);
            parent.Items.Remove(item);
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (Tree.SelectedItem != null)
                Remove.IsEnabled = true;
            else
                Remove.IsEnabled = false;
        }
    }
}
