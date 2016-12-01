using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatXF.Model.Entities;
using ChatXF.ViewModel;
using Xamarin.Forms;

namespace ChatXF.View
{
    public partial class MensajesPage : ContentPage
    {
        public MensajesPage()
        {
            InitializeComponent();
            this.BindingContext = new MensajeDirectoryVM();
            lvMensajes.ItemSelected += LvMensajes_ItemSelected;
        }
        void LvMensajes_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            Mensaje selectedMessage = (Mensaje)e.SelectedItem;
            if (selectedMessage == null)
                return;
            Navigation.PushAsync(new MensajeDetailPage(selectedMessage));
            lvMensajes.SelectedItem = null;
        }
    }
}
