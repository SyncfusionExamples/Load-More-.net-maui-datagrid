namespace SfDataGridLoadMoreSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.AllowLoadMore = true;
            dataGrid.LoadMoreCommand = new Command(ExecuteLoadMoreCommand);
        }

        private async void ExecuteLoadMoreCommand()
        {
            this.dataGrid.IsBusy = true;
            await Task.Delay(new TimeSpan(0, 0, 2));
            viewModel.LoadMoreItems();
            this.dataGrid.IsBusy = false;
        }
    }

}
