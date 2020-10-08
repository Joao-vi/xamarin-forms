using Nubank_recreating.Model;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;

namespace Nubank_recreating.ViewModel
{
    public class MainViewModel : BaseViewModel, IInitialize
    {
        public ObservableCollection<ItemsFrame> Menu { get; private set; }

        public MainViewModel()
        {
            Menu = new ObservableCollection<ItemsFrame>();
            Menu.Add( new ItemsFrame {icon = "outline_payment_24", name="Pagar" });
            Menu.Add(new ItemsFrame { icon = "outline_monetization_on_24", name = "Transferir" });
            Menu.Add(new ItemsFrame { icon = "outline_monetization_on_24", name = "Depositar" });
            Menu.Add(new ItemsFrame { icon = "outline_person_add_alt_1_24", name = "Indicar amigos" });
            Menu.Add(new ItemsFrame { icon = "outline_payment_24", name = "Cartão virtual" });
            Menu.Add(new ItemsFrame { icon = "outline_lock_24", name = "Bloquear cartão" });
            Menu.Add(new ItemsFrame { icon = "outline_chat_bubble_outline_24", name = "Dividir Valor" });
            Menu.Add(new ItemsFrame { icon = "outline_smartphone_24", name = "Recarga de celular" });
            Menu.Add(new ItemsFrame { icon = "outline_help_outline_24", name = "Me ajuda" });
        }

       
    }
}

