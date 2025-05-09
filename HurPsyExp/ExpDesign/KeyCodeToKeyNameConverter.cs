using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    public class KeyCodeToKeyNameConverter : IValueConverter
    {
        public object Convert(object kcode, Type targetType, object parameter, CultureInfo culture)
        {
            if (kcode != null && kcode is int)
            {
                string str = Enum.GetName(typeof(Key), (Key)kcode);
                return str;
            }
            return string.Empty; // Or handle null/non-enum values as needed
        }

        public object ConvertBack(object kname, Type targetType, object parameter, CultureInfo culture)
        {
            if (kname != null && kname is string str)
            {
                int val = (int)Enum.Parse(typeof(Key), str);
                return val;
            }
            return -1;
        }
    }
}
