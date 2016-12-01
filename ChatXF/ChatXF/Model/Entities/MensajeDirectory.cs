using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatXF.Model.Entities
{
    public class MensajeDirectory : ObservableBaseObject
    {
        private ObservableCollection<Mensaje> _mensajes = new ObservableCollection<Mensaje>();
        public ObservableCollection<Mensaje> Mensajes
        {
            get { return _mensajes; }
            set { _mensajes = value; OnPropertyChanged(); }
        }
    }
}
