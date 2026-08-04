using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;

class Program
{
    static void Main()
    {
        string folder = AppDomain.CurrentDomain.BaseDirectory;
        string game = Path.Combine(folder, "gta3_real.exe");

        if (!File.Exists(game))
        {
            Console.WriteLine("No se encontró gta3_real.exe");
            Console.ReadKey();
            return;
        }

        string flagFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "GTA Wrapper Fix"
        );

        Directory.CreateDirectory(flagFolder);

        string flag = Path.Combine(flagFolder, "GTA3_done.txt");

        string registryPath = @"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers";

        bool firstRun = !File.Exists(flag);

        if (firstRun)
        {
            // Primera ejecución: fuerza 640x480
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
            {
                key.SetValue(game, "~ 640x480");
            }
        }

        Process gta = Process.Start(new ProcessStartInfo
        {
            FileName = game,
            WorkingDirectory = folder,
            UseShellExecute = true
        });

        if (firstRun)
        {
            while (!gta.HasExited)
            {
                try
                {
                    gta.Refresh();

                    if (gta.MainWindowHandle != IntPtr.Zero)
                        break;
                }
                catch
                {
                    break;
                }

                Thread.Sleep(200);
            }

            Thread.Sleep(1000);

            // Quitar 640x480
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, true))
            {
                key?.DeleteValue(game, false);
            }

            File.WriteAllText(flag, "Configuración aplicada");
        }
    }
}
