using LoginWPF.Database.Context;
using LoginWPF.Repositories;
using LoginWPF.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWPF;

namespace LoginWPF.ViewModel
{
    internal class LoginVM : ObserverVM
    {
		Validation validation = new Validation();
		AddUserToDb addUser = new AddUserToDb();
		UsernameIsNotRepeat usernameIsNotRepeat = new UsernameIsNotRepeat();
		UsernameAndPasswordCorrect usernameAndPasswordCorrect = new UsernameAndPasswordCorrect();

        private string _username;
		public string Username
		{
			get { return _username; }
			set
			{ 
				_username = value; 
				OnPropertyChanged(nameof(Username));
			}
		}

		private string _password;
		public string Password
		{
			get { return _password; }
			set 
			{ 
				_password = value;
                OnPropertyChanged(nameof(Password));
            }
		}

		private string _error;
		public string Error
		{
			get { return _error; }
			set 
			{
				_error = value; 
				OnPropertyChanged(nameof(Error)); 
			}
		}

		private string _summary;
		public string Summary
		{
			get { return _summary; }
			set 
			{ 
				_summary = value;
                OnPropertyChanged(nameof(Summary));
            }
		}


		private ICommand _loginCommand;

		public ICommand LoginCommand
		{
			get 
			{
				_loginCommand = new RelayCommand<object>(
					(object o) =>
					{
                        Dictionary<string, string> dictionaryOfError = new Dictionary<string, string>();
                        if (usernameAndPasswordCorrect.ValidationUsernameAndPasswordCorrect(Username, Password, dictionaryOfError) == false)
							ShowError(dictionaryOfError);
						else
                            ShowSummary("Zalogowano pomyślnie!");
                    });
				return _loginCommand; 
			}
		}

		private ICommand _registerCommand;

		public ICommand RegisterCommand
		{
			get 
			{
				_registerCommand = new RelayCommand<object>(
					(object o) =>
                    {
						Dictionary<string, string> dictionaryOfError = new Dictionary<string, string>();
						if (validation.Validate(Username, Password, dictionaryOfError) == false)
							ShowError(dictionaryOfError);
						else
						{
							ShowSummary("Zarejestrowano pomyślnie!");
							addUser.AddUserToDatabase(Username, Password);
						}
                    });
				return _registerCommand; 
			}
		}

        #region Shows
        private void ShowError(Dictionary<string, string> dictionaryOfError)
        {
            if (dictionaryOfError.ContainsKey("validateError"))
            {
                Error = dictionaryOfError["validateError"];
				Summary = "";
            }
        }

		private void ShowSummary(string contents)
		{
			Summary = contents;
			Error = "";
		}

        #endregion
    }
}
