﻿using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");
Console.WriteLine($"Writing to:{logPath}");
TextWriterTraceListener logFile = new (File.CreateText(logPath));
Trace.Listeners.Add(logFile);

#if DEBUG
Trace.AutoFlush = true;
#endif

string settingsFile = "appsettings.json";
string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);
Console.WriteLine("Processiong: {0}", settingsPath);
Console.WriteLine("--{0} contents--", settingsFile);
Console.WriteLine(File.ReadAllText(settingsPath));
Console.WriteLine("------");
ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile(settingsFile, optional:false, reloadOnChange:true);
IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");
configuration.GetSection("PacktSwitch").Bind(ts);
Console.WriteLine($"Trace switch value:{ts.Value}");
Console.WriteLine($"Trace switch level:{ts.Level}");
Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning"); 
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");


Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am listening!");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

Debug.Close();
Trace.Close();

Console.WriteLine("Press enter to exit.");
Console.ReadLine();
