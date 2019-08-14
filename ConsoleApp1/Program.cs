using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (!args.Any())
                    MessageBox.Show("No file path specified. Aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                var stringBuilder = new StringBuilder(2048);
                Kernel32.GetFullPathNameW(args[0], (uint)stringBuilder.Capacity, stringBuilder, IntPtr.Zero);
                var convertedPath = stringBuilder.ToString();

                Clipboard.SetData(DataFormats.Text, convertedPath);

                MessageBox.Show("The path has been copied to the clipboard. Use the paste function in your slicer to add the file."
                    + Environment.NewLine + Environment.NewLine + convertedPath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
