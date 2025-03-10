using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
#if WINDOWS
using Microsoft.UI.Windowing;
using Microsoft.UI;
using WinRT.Interop;
#endif

namespace AdventureWorks;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if WINDOWS
        SetWindowOptions(builder);
        SetWindowHandlers();
#endif

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

#if WINDOWS
// Настроим отображение окна приложения в Windows
    public static void SetWindowOptions(MauiAppBuilder builder)
    {
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddWindows(windowsLifecycleBuilder =>
            {
                windowsLifecycleBuilder.OnWindowCreated(window =>
                {
                    IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);

                    // Получаем AppWindow для настройки
                    var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                    var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

                    if (appWindow != null)
                    {
                        int width = 1400;
                        int height = 1000;
                        // Устанавливаем размер окна 1400x1000
                        appWindow.Resize(new Windows.Graphics.SizeInt32(width, height));

                        // Центрируем окно на экране
                        var displayArea = Microsoft.UI.Windowing.DisplayArea.GetFromWindowId(windowId, Microsoft.UI.Windowing.DisplayAreaFallback.Nearest);
                        if (displayArea != null)
                        {
                            int centerX = displayArea.WorkArea.Width / 2 - (width / 2);
                            int centerY = displayArea.WorkArea.Height / 2 - (height / 2);
                            appWindow.Move(new Windows.Graphics.PointInt32(centerX, centerY));
                        }
                    

                        // Переключаем в полноэкранный режим
                        // appWindow.SetPresenter(Microsoft.UI.Windowing.AppWindowPresenterKind.FullScreen);
                    }
                    // Дополнительные настройки окна
                    window.ExtendsContentIntoTitleBar = true; // Расширить контент в заголовок
                    window.Title = "Custom MAUI Window";
                });
            });
        });
    }
#endif

    // Изменим обработчик переключателя switch для Windows
#if WINDOWS
    public static void SetWindowHandlers()
    {
        Microsoft.Maui.Handlers.SwitchHandler.Mapper
        .AppendToMapping(key: "Custorm", method: (switchHandler, iSwitch) =>
        {
            // Добавим надпись Yes/No рядом с переключателем switch
            switchHandler.PlatformView.OffContent = "No";
            switchHandler.PlatformView.OnContent = "Yes";
            switchHandler.PlatformView.MinWidth = 0;
        });
    }
#endif
}

