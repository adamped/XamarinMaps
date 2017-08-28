using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace XamarinMaps
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		public MainViewModel()
		{
			Task.Run(async () =>
			{
				await Task.Delay(5000);
				MyPosition = new Position(-37.8141, 144.9633);
			});
		}


		private Position _myPosition= new Position(-37.8141, 144.9633);
		public Position MyPosition { get { return _myPosition; } set { _myPosition = value; OnPropertyChanged(); } }

	}
}
