using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading;

namespace MyTaskApp
{
    internal class MainVM : BindableObject
    {
		private ICommand _setOnCommand;
		public ICommand SetOnCommand
		{
			get 
			{
				if (_setOnCommand == null)
					_setOnCommand = new Command<object>(
						async o =>
						{
                            try
                            {
                                // Turn On
                                await Flashlight.TurnOnAsync();

                            }
                            catch (FeatureNotSupportedException fnsEx)
                            {
                                // Handle not supported on device exception
                            }
                            catch (PermissionException pEx)
                            {
                                // Handle permission exception
                            }
                            catch (Exception ex)
                            {
                                // Unable to turn on/off flashlight
                            }

                        });
                return _setOnCommand; 
			}
			set { _setOnCommand = value; }
		}

        private ICommand _setOffCommand;
        public ICommand SetOffCommand
        {
            get
            {
                if (_setOffCommand == null)
                    _setOffCommand = new Command<object>(
                        async o =>
                        {
                            try
                            {
                                // Turn Off
                                await Flashlight.TurnOffAsync();
                            }
                            catch (FeatureNotSupportedException fnsEx)
                            {
                                // Handle not supported on device exception
                            }
                            catch (PermissionException pEx)
                            {
                                // Handle permission exception
                            }
                            catch (Exception ex)
                            {
                                // Unable to turn on/off flashlight
                            }
                        });
                return _setOffCommand;
            }
            set { _setOffCommand = value; }
        }

        CancellationTokenSource cts;

        private string _latitude;
        public string Latitude
        {
            get { return _latitude; }
            set 
            { 
                _latitude = value; 
                OnPropertyChanged(nameof(Latitude));
            }
        }

        private string _longitude;
        public string Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                OnPropertyChanged(nameof(Longitude));
            }
        }

        private string _altitude;
        public string Altitude
        {
            get { return _altitude; }
            set
            {
                _altitude = value;
                OnPropertyChanged(nameof(Altitude));
            }
        }

        private ICommand _location;
        public ICommand Location
        {
            get 
            { 
                if(_location == null)
                    _location = new Command<object>(
                        async o =>
                        {
                            try
                            {
                                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                                cts = new CancellationTokenSource();
                                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                                if (location != null)
                                {
                                    Latitude = location.Latitude.ToString();
                                    Longitude = location.Longitude.ToString();
                                    Altitude = location.Altitude.ToString();
                                }
                            }
                            catch (FeatureNotSupportedException fnsEx)
                            {
                                // Handle not supported on device exception
                            }
                            catch (FeatureNotEnabledException fneEx)
                            {
                                // Handle not enabled on device exception
                            }
                            catch (PermissionException pEx)
                            {
                                // Handle permission exception
                            }
                            catch (Exception ex)
                            {
                                // Unable to get location
                            }
                        });
                return _location; 
            }
            set 
            { 
                _location = value;
            }
        }

        private ICommand _vibrate;
        public ICommand Vibrate
        {
            get 
            { 
                if(_vibrate == null)
                    _vibrate = new Command<object>(
                        o => 
                        {
                            try
                            {
                                // use specified time
                                var duration = TimeSpan.FromSeconds(1);
                                Vibration.Vibrate(duration);
                            }
                            catch (FeatureNotSupportedException ex)
                            {
                                // Feature not supported on device
                            }
                            catch (Exception ex)
                            {
                                // Other error has occurred.
                            }
                        });
                return _vibrate; 
            }
            set { _vibrate = value; }
        }

        private ImageSource _showScreenshot;
        public ImageSource ShowScreenshot
        {
            get { return _showScreenshot; }
            set 
            { 
                _showScreenshot = value; 
                OnPropertyChanged(nameof(ShowScreenshot));
            }
        }

        private ICommand _makeScreenshot;

        public ICommand MakeScreenshot
        {
            get
            {
                if (_makeScreenshot == null)
                    _makeScreenshot = new Command<object>(
                        async o =>
                        {
                            var screenshot = await Screenshot.CaptureAsync();
                            var stream = await screenshot.OpenReadAsync();

                            ShowScreenshot = ImageSource.FromStream(() => stream);
                        });
                return _makeScreenshot; 
            }
            set { _makeScreenshot = value; }
        }


    }
}
