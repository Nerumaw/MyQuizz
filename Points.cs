using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyQuiz
{
	public class Points : INotifyPropertyChanged
	{
		private int _pts;

		public int Pts
		{
			get => _pts;
			set
			{
				if(_pts != value)
				{
					_pts = value;
					OnPropertyChanged();
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
