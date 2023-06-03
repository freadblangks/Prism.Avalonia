using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Prism.Ioc;
using Prism.Services.Dialogs;
using SampleDialogApp.ViewModels;

namespace SampleDialogApp.Views;

public partial class DialogView : UserControl
{
    public DialogView()
    {
        InitializeComponent();
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        // Pass the parent window to the ViewModel
        // given that the ViewModel has been binded to this view
        DialogViewModel? viewModel = this.DataContext as DialogViewModel;
        if (this.Parent is Window parent &&
            viewModel is not null)
        {
            viewModel.ParentWindow = parent;
        }
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void BtnShowModal_Click(object sender, RoutedEventArgs args)
    {
        var dialogSvc = ContainerLocator.Current.Resolve<IDialogService>();

        var title = "MessageBox Title Here";
        var message = "Hello, I am a simple modal MessageBox with an OK button.\n\n" +
                      "I've been called by the `.axaml.cs` UserControl.";

        dialogSvc.ShowDialog(
            this.Parent as Window,
            nameof(MessageBoxView),
            new DialogParameters($"title={title}&message={message}"),
            r => { });
    }
}
