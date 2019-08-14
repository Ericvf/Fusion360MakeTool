using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Kernel32
    {
        /// <summary>
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa364963.aspx
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <param name="nBufferLength"></param>
        /// <param name="lpBuffer"></param>
        /// <param name="lpFilePart"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern uint GetFullPathNameW(
           string lpFileName,
           uint nBufferLength,
           StringBuilder lpBuffer,
           IntPtr lpFilePart);

        /// <summary>
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms686206.aspx
        /// </summary>
        /// <param name="lpName"></param>
        /// <param name="lpValue"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        internal static extern bool SetEnvironmentVariableW(
            string lpName,
            string lpValue);

    }
}
