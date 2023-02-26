using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ListOfContactsApp
{
    internal class MainVM : BindableObject
    {
        public ObservableCollection<Contact> CollectionOfContacts { get; set; }

        private string _smsText;
        public string SmsText
        {
            get { return _smsText; }
            set 
            { 
                _smsText = value; 
                OnPropertyChanged();
            }
        }



        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        private ICommand _sendSmsCommand;
        public ICommand SendSmsCommand
        {
            get 
            {
                if (_sendSmsCommand == null)
                    _sendSmsCommand = new Command<object>(
                        async o =>
                        {
                            try
                            {
                                string phoneNumber = "";
                                if (SelectedContact != null)
                                    phoneNumber = SelectedContact.Phones[0].PhoneNumber;
                                var message = new SmsMessage(SmsText, phoneNumber);
                                await Sms.ComposeAsync(message);
                            }
                            catch (FeatureNotSupportedException ex)
                            {
                                // Sms is not supported on this device.
                            }
                            catch (Exception ex)
                            {
                                // Other error has occurred.
                            }
                        });
                return _sendSmsCommand; 
            }
        }

        private ICommand _phoneCallCommand;
        public ICommand PhoneCallCommand
        {
            get 
            {
                if (_phoneCallCommand == null)
                    _phoneCallCommand = new Command<Contact>(
                        c =>
                        {
                            try
                            {
                                PhoneDialer.Open(c.Phones[0].PhoneNumber);
                            }
                            catch (FeatureNotSupportedException ex)
                            {
                                // Phone Dialer is not supported on this device.
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        });
                return _phoneCallCommand; 
            }
            set { _phoneCallCommand = value; }
        }


        public MainVM()
        {
            try
            {
                //Contacts.PickContactAsync();
                CollectionOfContacts = new ObservableCollection<Contact>();
                var contacts = Contacts.GetAllAsync().Result;
                if(contacts == null)
                    return;
                foreach(var item in contacts)
                {
                    CollectionOfContacts.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
