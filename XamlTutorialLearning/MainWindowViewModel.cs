namespace XamlTutorialLearning
{
    public class MainWindowViewModel
    {
        private string _name;
        private string _title;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public MainWindowViewModel(Employee emp)
        {
            Name = emp.Name;
            Title = emp.Title;
        }
    }
}
