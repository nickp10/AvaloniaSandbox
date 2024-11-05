using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedApp.ViewModels;

public  class ToolbarViewModel : ViewModelBase
{
	private bool _isPopupOpen;
	public bool IsPopupOpen
	{
		get => _isPopupOpen;
		set => SetProperty(ref _isPopupOpen, value);
	}

	private ToolbarPopupViewModel _toolbarPopup = new ToolbarPopupViewModel();
	public ToolbarPopupViewModel ToolbarPopup => _toolbarPopup;
}
