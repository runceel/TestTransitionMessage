using Livet;
using System.Diagnostics;

namespace TestTransitionMessage.ViewModels
{
	public class SubWindowViewModel : ViewModel
	{
		public void Initialize()
		{
			// 2 回目のウィンドウオープンで 'Cannot access a disposed object' エラーが発生する
			// Visual Studio 2019 + Livet v3.2.1
			Debug.WriteLine("Initialize() CompositeDisposable.Count: " + CompositeDisposable.Count);
		}
	}
}
