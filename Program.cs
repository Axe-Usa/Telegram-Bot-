using System;
using System.Windows.Forms;
using TLSharp.Core;

namespace TelegramTools
{
  internal static class Program
  {
    public static TelegramClient client;

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      using (Program.client = new TelegramClient(19474, "a2514f96431a228e4b9ee473f6c51945", (ISessionStore) null, "session"))
      {
        if (Program.client.IsUserAuthorized())
          Application.Run((Form) new MainForm());
        else
          Application.Run((Form) new LoginForm());
      }
    }
  }
}
