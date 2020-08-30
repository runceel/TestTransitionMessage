
using Livet;
using System;

namespace TestTransitionMessage.ViewModels
{
    public class MainWindowViewModel : ViewModel
	{
		public SubWindowViewModel SubWindowViewModel { get; } = new SubWindowViewModel();

        public MainWindowViewModel()
        {
			CompositeDisposable.Add(SubWindowViewModel);
        }

		// Some useful code snippets for ViewModel are defined as l*(llcom, llcomn, lvcomm, lsprop, etc...).
		public void Initialize()
		{
		}
    }
}
