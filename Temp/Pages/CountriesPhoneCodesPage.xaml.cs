using System.Text.Json;
using Temp.Models;
using Temp.ViewModels;

namespace Temp.Pages;

public partial class CountriesPhoneCodesPage : ContentPage
{
    public CountriesPhoneCodesPage()
    {
        InitializeComponent();
        var data = SetCountryCodeData().Result;
        this.BindingContext = new CountryCodeSelectViewModel(data);
    }

    private readonly string FileName = "country-code-data.json";
    private async Task<List<CountryCode>> SetCountryCodeData()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync(FileName);
            using var reader = new StreamReader(stream);

            var json = reader.ReadToEnd();

            var countryCodes = JsonSerializer.Deserialize<List<CountryCode>>(json);

            return countryCodes;
        }
        catch (Exception e)
        {

            throw;
        }
    }

}