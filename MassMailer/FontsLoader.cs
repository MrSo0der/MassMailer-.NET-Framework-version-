using System;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace MassMailer
{
    internal class FontsLoader
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern int AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, out uint pcFonts);

        public static PrivateFontCollection pfc = new PrivateFontCollection();
        public FontsLoader()
        {
            byte[] fontData = Convert.FromBase64String(Properties.Resources.HSESans_Black);
            IntPtr fontPtr = Marshal.AllocHGlobal(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, out _);
            pfc.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeHGlobal(fontPtr);

            fontData = Convert.FromBase64String(Properties.Resources.HSESans_Regular);
            fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, out _);
            pfc.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeHGlobal(fontPtr);
        }
    }
}
