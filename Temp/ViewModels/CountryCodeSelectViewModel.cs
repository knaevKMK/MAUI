using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text.Json;
using System.Windows.Input;
using Temp.Models;

namespace Temp.ViewModels
{
    public class CountryCodeSelectViewModel : BaseViewModel
    {
        public ObservableCollection<CountryCode> CountryCodes { get; set; }


        private string iconUrl;
        public string IconUrl
        {
            get => iconUrl;
            set
            {
                iconUrl = value;
                OnPropertyChanged(nameof(IconUrl));
            }
        }

        private string code;
        public string Code
        {
            get => code;
            set
            {
                code = value;
                OnPropertyChanged(nameof(Code));
            }
        }

        public string Country { get; set; }

        public string SearchText { get; set; }

        public ICommand SearchCommand { get; }

        public ICommand SelectedCommand { get; }

        private List<CountryCode> countryCodesData { get; set; }// = new List<CountryCode>()
        //{
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+6", Country = "USA"},
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+7", Country = "USA"},
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+8", Country = "USA"},
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+17", Country="USA"},
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+18", Country="USA"},
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+19", Country="USA"},
        //    new CountryCode(){IconUrl = "us_icon.png", Code="+20", Country="USA"},
        //    new CountryCode(){IconUrl="us_icon.png", Code="+359",Country="Bulgaria"}
        //};

        public CountryCodeSelectViewModel(List<CountryCode> countryCodesData)
        {
            CountryCodes = new ObservableCollection<CountryCode>(countryCodesData);
            OnPropertyChanged(nameof(CountryCodes));
            SearchCommand = new Command(Search);
            SelectedCommand = new Command<CountryCode>(Selected);
        }
      

       
        public void Selected(CountryCode countryCode)
        {
        //    Shell.Current.GoToAsync($"..?code={countryCode.Code}&icon={countryCode.IconUrl}");
        }

        public void Search()
        {
            //Expression<Func<CountryCode, bool>> querry = x =>
            //x.Code.Contains(SearchText) ||
            //x.Country.Contains(SearchText) ||
            //x.Code == SearchText ||
            //x.Country == SearchText;

            //var newData = countryCodesData.Where(querry.Compile()).ToList();
            //CountryCodes = new ObservableCollection<CountryCode>(newData);

            //OnPropertyChanged(nameof(CountryCodes));
        }
    }
}

