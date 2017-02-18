using System.Collections.ObjectModel;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Citicon.CommonUi.Controls
{
    /// <summary>
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
            DataContext = this;
            SuggestionTriggerTimer = new Timer(SuggestionTriggerInterval);
            SuggestionTriggerTimer.Elapsed += SuggestionTriggerTimer_Elapsed;
            SuggestionItems = new ObservableCollection<object>();
        }

        public event SearchTriggeredEventHandler SearchTriggered;
        private Timer SuggestionTriggerTimer { get; }
        private string _Keyword;

        public ObservableCollection<object> SuggestionItems { get; }

        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }
        
        public static readonly DependencyProperty PlaceHolderProperty = DependencyProperty.Register(nameof(PlaceHolder), typeof(string), typeof(SearchBar), new PropertyMetadata("Search..."));

        public bool? IsSuggestionEnabled
        {
            get { return (bool?)GetValue(IsSuggestionEnabledProperty); }
            set { SetValue(IsSuggestionEnabledProperty, value); }
        }
        
        public static readonly DependencyProperty IsSuggestionEnabledProperty = DependencyProperty.Register(nameof(IsSuggestionEnabled), typeof(bool?), typeof(SearchBar), new PropertyMetadata(null));

        public string Keyword
        {
            get { return (string)GetValue(KeywordProperty); }
            set
            {
                _Keyword = value;
                SetValue(KeywordProperty, value);
            }
        }
        
        public static readonly DependencyProperty KeywordProperty = DependencyProperty.Register(nameof(Keyword), typeof(string), typeof(SearchBar), new PropertyMetadata(null));

        public double SuggestionTriggerInterval
        {
            get { return (double)GetValue(SuggestionTriggerIntervalProperty); }
            set
            {
                SuggestionTriggerTimer.Interval = value;
                SetValue(SuggestionTriggerIntervalProperty, value);
            }
        }

        public static readonly DependencyProperty SuggestionTriggerIntervalProperty = DependencyProperty.Register(nameof(SuggestionTriggerInterval), typeof(double), typeof(SearchBar), new PropertyMetadata(200D));

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }
        
        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(nameof(SelectedItem), typeof(object), typeof(SearchBar), new PropertyMetadata(null));
        
        private void OnSearchTriggered()
        {
            if (IsSuggestionEnabled ?? false)
            {
                SuggestionItems.Clear();
            }

            SearchItemDisplay.IsOpen = true;
            SearchTriggered?.Invoke(this, new SearchTriggeredEventArgs(Keyword));
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                OnSearchTriggered();
            }
            else if (e.Key == Key.Down && ListBox.Items.Count > 0)
            {
                ListBox.SelectedIndex = 0;
                ListBox.Focus();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OnSearchTriggered();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SuggestionTriggerTimer.Stop();
            SuggestionTriggerTimer.Start();
        }

        private void SuggestionTriggerTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            SuggestionTriggerTimer.Stop();
            MessageBox.Show(_Keyword);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchItemDisplay.Visibility = Visibility.Collapsed;
        }

        private void ListBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SelectCurrent();
            }
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SelectCurrent();
        }

        private void SelectCurrent()
        {
            if (ListBox.SelectedItem != null)
            {
                TextBox.Text = ListBox.SelectedItem.ToString();
                SelectedItem = ListBox.SelectedItem;
            }

            SuggestionItems.Clear();
        }
    }

    public delegate void SearchTriggeredEventHandler(object sender, SearchTriggeredEventArgs e);

    public sealed class SearchTriggeredEventArgs : RoutedEventArgs
    {
        public SearchTriggeredEventArgs(string keyword)
        {
            Keyword = keyword;
        }

        public string Keyword { get; }
    }
}
