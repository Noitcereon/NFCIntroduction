using System;
using System.IO;
using System.Text;
using System.Text.Json;
using NdefLibrary.Ndef;

namespace NFCConsoleApp
{
    public class Worker
    {
        public void Start()
        {
            try
            {
                // Simply using the string type works as well
                NdefTextRecord ndefTextRecord = new NdefTextRecord { Text = Console.ReadLine() };

                if (ndefTextRecord.Text == "0716656832")
                {
                    Console.WriteLine("The white chip was scanned");
                    return;
                }

                Console.WriteLine("Something other than the white chip was entered.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
