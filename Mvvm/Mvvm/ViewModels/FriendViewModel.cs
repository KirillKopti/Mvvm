using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using Mvvm.Models;

namespace Mvvm.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        FriendsListViewModel lvm;
        public Friend Friend { get; private set; }
        public FriendViewModel()
        {
            Friend = new Friend();
        }

    }
}
