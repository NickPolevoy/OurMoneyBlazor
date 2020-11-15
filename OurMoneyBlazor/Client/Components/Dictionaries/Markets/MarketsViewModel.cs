using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MvvmBlazor.ViewModel;
using OurMoneyBlazor.Shared.Entities;

namespace OurMoneyBlazor.Client.Components.Dictionaries.Markets
{
    public class MarketsViewModel : ViewModelBase
    {
        private ObservableCollection<Dictionary>? markets;
        private readonly HttpClient httpClient;

        public MarketsViewModel(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public ObservableCollection<Dictionary>? Markets
        {
            get => markets;
            set => Set(ref markets, value, nameof(Markets));
        }
//        IEnumerable<Dictionary> marketsData = new List<Dictionary>();
        public override async Task OnInitializedAsync()
        {
          var  marketsData = await httpClient.GetFromJsonAsync<IEnumerable<Dictionary>>("api/markets");
            markets = new ObservableCollection<Dictionary>(marketsData);
        }
    }
}
