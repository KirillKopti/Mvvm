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
        public FriendsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChsnged("ListViewModle");
                }
            }
        }
        public string Name
        {
            get { return Friend.Name; }
            set
            {
                if (Friend.Name != value )
                {
                    Friend.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

    }
}
