using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirhurt_V4.ExtraData
{
    class ExtraFunc
    {
        public bool ToBool(string Item)
        {
            Item = Item.ToLower();
            if (Item == "true")
                return true;
            if (Item == "false")
                return false;
            return false;
        }

        public Color ToColor(string color)
        {
            var arrColorFragments = color?.Split(',').Select(sFragment =>
            {
                int.TryParse(sFragment, out var fragment);
                return fragment;
            }).ToArray();

            switch (arrColorFragments?.Length)
            {
                case 3:
                    return Color.FromArgb(arrColorFragments[0], arrColorFragments[1], arrColorFragments[2]);
                case 4:
                    return Color.FromArgb(arrColorFragments[0], arrColorFragments[1], arrColorFragments[2],
                        arrColorFragments[3]);
                default:
                    return Color.Transparent;
            }
        }

        internal class IniFile // revision 11
        {
            private readonly string EXE = Assembly.GetExecutingAssembly().GetName().Name;

            // Ty stackoverflow
            private readonly string Path;

            public IniFile(string IniPath = null)
            {
                Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
            }

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern int GetPrivateProfileString(string Section, string Key, string Default,
                StringBuilder RetVal, int Size, string FilePath);

            public string Read(string Key, string Section = null)
            {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                return RetVal.ToString();
            }

            public void Write(string Key, string Value, string Section = null)
            {
                WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            }

            public void DeleteKey(string Key, string Section = null)
            {
                Write(Key, null, Section ?? EXE);
            }

            public void DeleteSection(string Section = null)
            {
                Write(null, null, Section ?? EXE);
            }

            public bool KeyExists(string Key, string Section = null)
            {
                return Read(Key, Section).Length > 0;
            }
        }
    }
}
