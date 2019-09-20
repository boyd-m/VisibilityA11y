namespace VisibilityA11y.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		private bool _isVisible;
		public bool IsVisible
		{
			get { return _isVisible; }
			set
			{
				_isVisible = value;
				OnPropertyChanged();
			}
		}
	}
}