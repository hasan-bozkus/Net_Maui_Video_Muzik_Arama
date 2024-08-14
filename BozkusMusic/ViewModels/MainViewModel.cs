using BozkusMusic.Models;
using BozkusMusic.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozkusMusic.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        ISearchService _searchService = new SearchService();

        [ObservableProperty]
        private string _searchText;

        [ObservableProperty]
        List<Video> _listResult;

        public MainViewModel()
        {

        }

        [RelayCommand]
        public async void GetVideos()
        {
            var searchText = SearchText.Replace(' ', '+');
            ListResult = await _searchService.GetVideoBySearch(searchText);
        }
    }
}
