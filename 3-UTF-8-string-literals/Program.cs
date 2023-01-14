// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello human!");

string mytext = "Javi Vela"; //UTF-16

ReadOnlySpan<byte> myNameUTF8 = "Javi Vela"u8;
ReadOnlySpan<byte> myNameUTF16 = System.Text.Encoding.Unicode.GetBytes(mytext);

byte[] myBytes = "Javi Vela"u8.ToArray();


Debugger.Break();



Console.ReadLine();