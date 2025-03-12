using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui;
#if WINDOWS
using Microsoft.UI.Xaml.Controls;
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
            })
            .ConfigureMauiHandlers(handlers =>
            {
#if WINDOWS
                handlers.AddHandler<Microsoft.Maui.Controls.TimePicker, CustomTimePickerHandler>();
#endif
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

#if WINDOWS
// Настройки обработчика TimePicker в Windows. Но из всего работает только MinuteIncrement
public class CustomTimePickerHandler : TimePickerHandler
{
    protected override Microsoft.UI.Xaml.Controls.TimePicker CreatePlatformView()
    {
        var platformView = base.CreatePlatformView();
        CustomizeTimePicker(platformView);
        return platformView;
    }

    private void CustomizeTimePicker(Microsoft.UI.Xaml.Controls.TimePicker winTimePicker)
    {
        // Основные настройки
        winTimePicker.Background = new Microsoft.UI.Xaml.Media
            .SolidColorBrush(Windows.UI.Color.FromArgb(255, 240, 240, 240)); // Серый фон

        winTimePicker.Foreground = new Microsoft.UI.Xaml.Media
            .SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 120, 212)); // Синий текст

        // Настройки часов/минут
        winTimePicker.MinuteIncrement = 10; // Шаг 10 минут
        winTimePicker.ClockIdentifier = "24HourClock"; // 24-часовой формат

        // Стиль границы
        winTimePicker.BorderBrush = new Microsoft.UI.Xaml.Media
            .SolidColorBrush(Windows.UI.Color.FromArgb(255, 240, 240, 240));
        winTimePicker.BorderThickness = new Microsoft.UI.Xaml.Thickness(2);

        // Размеры
        winTimePicker.Width = 200;
        winTimePicker.Height = 40;
    }
}
#endif
