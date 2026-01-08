using Microsoft.Maui.Controls;

namespace PersonalJournaling;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        // Create a window with AppShell as the root
        var window = new Window(new AppShell());

        // Optional: set window size for testing
#if WINDOWS
        window.Width = 800;
        window.Height = 600;
#endif

        return window;
    }
}
