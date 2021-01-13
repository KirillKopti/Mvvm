using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using Mvvm.Views;

namespace Mvvm.ViewModels
{
    public class FriendsListViewModel : INotifyPropertyChanged
    {
       public ObservableCollection<FriendViewModel> Friends { get; set;  }

        public event PropertyChangedEventHandler PropertyChanged;
      
        public ICommand CreateFriendCommand { protected set; get; }
        public ICommand DeleteFriendCommand { protected set; get; }
        public ICommand SaveFriendCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        FriendViewModel selectedFriend;
        public INavigation Navigation { get; set; }
        public FriendsListViewModel()
        {

        }
    }
}
