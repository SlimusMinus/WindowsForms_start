using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        
        static DialogResult ShowMSGBox()
        {
            DialogResult res = MessageBox.Show("Открыть сообщение?", "Заголовок сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res == DialogResult.Yes)
                MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.OK);           
            return res;
        }
        static DialogResult ShowMSGBox2()
        {
            DialogResult res = MessageBox.Show("Сообщение от програмиста!", "Win_forms", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
                MessageBox.Show("Your best of the best", "Win_forms", MessageBoxButtons.OK);
            else if (res == DialogResult.No)
                MessageBox.Show("Вы нажали кнопку нет", "Win_forms", MessageBoxButtons.OK);
            return res;
        }

        [STAThread]


        static void Main()
        {
           
            DialogResult result;

            do
            {
                result = ShowMSGBox();
            } while (result != DialogResult.No);

            do
            {
                result = ShowMSGBox2();
            } while (result != DialogResult.Cancel);
        }
    }
}
