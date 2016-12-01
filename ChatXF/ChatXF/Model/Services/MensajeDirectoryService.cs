using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatXF.Model.Entities;

namespace ChatXF.Model.Services
{
    public class MensajeDirectoryService
    {
        public static MensajeDirectory LoadMensajeDirectory()
        {
            MensajeDirectory mensajeDirectory = new MensajeDirectory();
            string[] messages = {
                "Hola. Como estan?",
                "Yo bien. Y vos?",
                "Mas o menos. Me duele un poco la cabeza.",
                "Ah. Podes tomarte un paracetamol.",
                "Ya tome. Supongo que es cuestión de tiempo para que haga efecto.",
                "Si. Paciencia.",
                "Hola.",
                "Chau.",
                "Buenos días.",
                "Bunas noches.",
                "Xamarin Forms"
            };
            string[] users =
            {
                "Juan Carlos",
                "Gustavo Gramajo",
                "Felicity Smock",
                "Pablo Fernandez",
                "German Mendia"
            };
            Random rnd = new Random(DateTime.Now.Millisecond);
            var mensajes = new ObservableCollection<Mensaje>();
            for (int i = 0; i < 20; i++)
            {
                Mensaje m = new Mensaje();
                m.Message = messages[rnd.Next(0, 10)];
                m.User = users[rnd.Next(0, 4)];
                m.DateTime = DateTime.Now;
                mensajes.Add(m);
            }
            mensajeDirectory.Mensajes = mensajes;
            return mensajeDirectory;
        }
    }
}
