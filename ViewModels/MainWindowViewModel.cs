namespace GetStartedApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    private ToolbarViewModel _toolbar = new ToolbarViewModel();
	public ToolbarViewModel Toolbar => _toolbar;
}
