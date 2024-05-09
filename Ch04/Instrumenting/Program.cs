using System.Diagnostics;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");
Console.WriteLine($"Writing to:{logPath}");
TextWriterTraceListener logFile = new (File.CreateText(logPath));
Trace.Listeners.Add(logFile);

#if DEBUG
Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debug says, I am watching666!");
Trace.WriteLine("Trace says, I am listening!");

Debug.Close();
Trace.Close();
