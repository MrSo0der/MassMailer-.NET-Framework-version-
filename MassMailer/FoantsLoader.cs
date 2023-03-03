using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MassMailer
{
    internal class FoantsLoader
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern int AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, out uint pcFonts);

        public static PrivateFontCollection pfc = new PrivateFontCollection();
        public static void Initialize()
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
