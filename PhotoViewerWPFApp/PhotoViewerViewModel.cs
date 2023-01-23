using System.Windows.Input;
using UtilitiesWPF;

namespace PhotoViewerWPFApp
{
    internal class PhotoViewerViewModel : ObserverVM
    {
		private string _imagePath;
		public string ImagePath
		{
			get { return _imagePath; }
			set 
			{ 
				_imagePath = value; 
				OnPropertyChanged(nameof(ImagePath));
			}
		}

		private ICommand _loadFromFileCommand;
		private readonly ViewDialogs viewDialogs;

		public ICommand LoadFromFileCommand
		{
			get 
			{
				if (_loadFromFileCommand == null)
					_loadFromFileCommand = new RelayCommand<object>(
						x =>
						{
							string path = viewDialogs.GetPathToPicture();
							if(path != null)
								ImagePath = path;
						});
				return _loadFromFileCommand; 
			}
		}

		public PhotoViewerViewModel(ViewDialogs viewDialogs)
		{
			this.viewDialogs = viewDialogs;
		}

	}
}
