namespace Cau6_NoteManager;

internal static class Program
{
    /// <summary>
    ///  Điểm khởi chạy của ứng dụng.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormChinh());
    }
}
