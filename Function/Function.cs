using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function
{
    public static class Algorithm
    {
        // Đổi tiếng Việt sang không dấu => Dùng để tìm kiếm theo tên
        public static string convertText(string text)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            return regex.Replace(text.Normalize(NormalizationForm.FormD), String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower();
        }

        // Kiểm tra giá trị của các input
        public static bool emptyInput(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if ((item is TextBox || item is ComboBox) && item.Text.Equals(string.Empty))
                    return true;
            }

            return false;
        }

        // Clear các input
        public static void clearInput(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;

                if (item is ComboBox)
                    ((ComboBox)item).Text = string.Empty;

                clearInput(item);
            }
        }
    }
}
