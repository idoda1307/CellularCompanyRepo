using Client.ServerServiceReference;
using ClientModels.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class LinesViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public LineModel Line { get; set; }
        public PackageModel Package { get; set; }
        public PackageIncludesModel PackageIncludes { get; set; }

        public ObservableCollection<LineModel> Lines { get; set; }

        private ServerServiceReference.CRMServiceClient server = new ServerServiceReference.CRMServiceClient();

        public ICommand SaveCommand { get; set; }

        public LinesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Line = new LineModel();

            var task = Task.Factory.StartNew(() => GetLines());
            Lines = new ObservableCollection<LineModel>(task.Result.Result);

            LineDto dto = server.GetLineAsync(Line.Number).Result;
            LineModel model = dto.ToModel();
            dto.Package = model.Package.ToDto();
        }

        public async Task<IEnumerable<LineModel>> GetLines()
        {
            try
            {
                List<LineDto> Lines = await server.GetLinesAsync();
                List<LineModel> linesList = Lines.Select(l => l.ToModel()).ToList();
                return linesList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
