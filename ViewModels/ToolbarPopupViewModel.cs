using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedApp.ViewModels;

public class ToolbarPopupViewModel : ViewModelBase
{
	private ObservableCollection<string> _items = new ObservableCollection<string>()
	{
		"Item 1",
		"Item 2",
		"Item 3",
		"Item 4",
		"Item 5",
		"Item 6",
		"Item 7",
		"Item 8",
		"Item 9",
		"Item 10"
	};
	public ObservableCollection<string> Items
	{
		get => _items;
	}
}
