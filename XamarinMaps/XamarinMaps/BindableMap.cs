using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamarinMaps
{
	public class BindableMap : Map
	{

		public static readonly BindableProperty MapPositionProperty = BindableProperty.Create(
				nameof(MapPosition),
				typeof(Position),
				typeof(BindableMap),
				new Position(0,0),
				propertyChanged: (b, o, n) =>
				{
					((BindableMap)b).MoveToRegion(MapSpan.FromCenterAndRadius(
								(Position)n, Distance.FromMiles(1)));

				});

		private Position _mapPosition;
		public Position MapPosition
		{
			get { return _mapPosition; }
			set
			{				
				_mapPosition = value;
			}
		}
	}
}
