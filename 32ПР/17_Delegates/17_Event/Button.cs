using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Event
{
    delegate string MyDel();

    class Button
    {
        public event MyDel ButtonClickYes;
        public event MyDel ButtonClickNo;

        public void Yes()
        {
            Console.WriteLine(ButtonClickYes());
        }

        public void No()
        {
            Console.WriteLine(ButtonClickNo());
        }

        public Button()
        {
            YesBtn();
            NoBtn();
        }
        private void YesBtn()
        {
            ButtonClickYes += ClickYes;
            ButtonClickYes += ShowMsg;
            ButtonClickYes += Sleep;
            ButtonClickYes += Reset;
        }

        private void NoBtn()
        {
            ButtonClickNo += ClickNo;
            ButtonClickNo += Sleep;
            ButtonClickNo += Close;
            ButtonClickNo += Reset;
        }



        private string ClickYes()
        {
            DialogResult result =  MessageBox.Show("Do you like your salary?", "My box", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Yes clicked");
            }
            else
            {
                Console.WriteLine("NO");
            }
            return "yes";
        }

        private string ClickNo()
        {
            Console.WriteLine("No clicked");
            return "no";
        }

        private string ShowMsg()
        {
            Console.WriteLine("Start program");
            return "Start program";
        }

        private string Close()
        {
            Console.WriteLine("Close");
            return "Close";
        }

        private string Sleep()
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            return "";
        }

        private string Reset()
        {
            Thread.Sleep(500);
            Console.ResetColor();
            Console.WriteLine("Reset to start position");
            return "";
        }
    }
}
