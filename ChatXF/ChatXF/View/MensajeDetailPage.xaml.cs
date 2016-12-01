using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatXF.Model.Entities;
using Xamarin.Forms;

namespace ChatXF.View
{
    public partial class MensajeDetailPage : ContentPage
    {
        public MensajeDetailPage(Mensaje selectedMessage)
        {
            InitializeComponent();
            this.BindingContext = selectedMessage;
        }
    }
}
