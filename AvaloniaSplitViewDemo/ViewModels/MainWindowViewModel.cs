using ReactiveUI;
using System.Reactive;

namespace AvaloniaApplicationTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _isPaneOpen = false;

        public bool IsPaneOpen
        {
            get => _isPaneOpen;
            set => this.RaiseAndSetIfChanged(ref _isPaneOpen, value);
        }

        public ReactiveCommand<Unit,  Unit> TogglePanelCommand { get; set; }

        public MainWindowViewModel()
        {
            TogglePanelCommand = ReactiveCommand.Create(TogglePannel);
        }

        void TogglePannel()
        {
            IsPaneOpen = !IsPaneOpen;
        }

    }
}
