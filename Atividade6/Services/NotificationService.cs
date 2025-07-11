namespace Atividade6.Services
{
    public class NotificationService
    {
        public event Action<string, string>? OnNotification;

        public void ShowSuccess(string message)
        {
            OnNotification?.Invoke(message, "success");
        }

        public void ShowError(string message)
        {
            OnNotification?.Invoke(message, "error");
        }

        public void ShowInfo(string message)
        {
            OnNotification?.Invoke(message, "info");
        }

        public void ShowWarning(string message)
        {
            OnNotification?.Invoke(message, "warning");
        }
    }
}