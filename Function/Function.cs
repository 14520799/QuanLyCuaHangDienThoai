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
        // Hàm chuyển đổi Tiếng Việt sang không dấu => Dùng cho chức năng tìm kiếm
        public static string convertText(string text)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            return regex.Replace(text.Normalize(NormalizationForm.FormD), String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower();
        }


        // Hàm clear input
        public static void clearInput(Control control)
        {

            foreach (Control item in control.Controls)
            {
                if (item is TextBox || item is ComboBox)
                    ((TextBox)item).Text = "";

                clearInput(item);
            }
        }
    }
}
