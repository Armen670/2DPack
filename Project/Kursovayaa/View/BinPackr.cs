using System.Windows.Forms;

namespace Kursovayaa
{
    class BinPackr
    {
        public static void Main()
        {
            BinList binList = new BinList(); //создание бин листа
            MainForm mainForm = new MainForm(ref binList);

            mainForm.RefreshPanel();

            //запуск wpf

            Application.EnableVisualStyles();
            Application.Run(mainForm);
        }
    }
}