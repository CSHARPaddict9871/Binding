using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BindingPractice.ViewModels {
    public partial class MainWindowViewModel : ObservableObject {


        private string greeting = "Hi Prisco";

        public string Greeting {
            get {
                return greeting;
            }
            set {
                SetProperty(ref greeting, value);

            }
        }

        [RelayCommand]
        private void ChangeDogsName() {
            if (greeting == "Hi Fido")
                Greeting = "Hi Prisco";
            else
                Greeting = "Hi Fido";
        }
    }
}