using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatXF.Model.Entities;
using ChatXF.Model.Services;
using Xamarin.Forms;

namespace ChatXF.ViewModel
{
    public class MensajeDirectoryVM : ObservableBaseObject
    {
        private AzureMobileServiceClient _client;
        public ObservableCollection<Mensaje> Mensajes { get; set; }

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public Command LoadDirectoryCommand { get; set; }

        public MensajeDirectoryVM()
        {
            Mensajes = new ObservableCollection<Mensaje>();
            IsBusy = false;
            _client = new AzureMobileServiceClient();
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        //private async void LoadDirectory()
        //{
        //    if (!IsBusy)
        //    {
        //        IsBusy = true;
        //        await Task.Delay(3000);
        //        var loadedDirectory = MensajeDirectoryService.LoadMensajeDirectory();
        //        foreach (var mensaje in loadedDirectory.Mensajes)
        //        {
        //            Mensajes.Add(mensaje);
        //        }
        //        IsBusy = false;
        //    }
        //}

        private async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                Mensajes.Clear();
                var mensajesDirectory = await _client.GetMensajes();
                foreach (var mensaje in mensajesDirectory)
                {
                    Mensajes.Add(mensaje);
                }
                IsBusy = false;
            }
        }
    }
}
