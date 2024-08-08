using System.ComponentModel;

namespace Kursovayaa
{
    public class Log : BindingList<string>
    {
        private static readonly Log instance = new Log();

        private const int LINES_MAX = 15;

        public static Log Instance
        {
            get
            {
                return instance;
            }
        }
        public void AddLine(string line)
        {
            if (this.Count >= LINES_MAX)
            {
                this.RemoveAt(0);
            }

            this.Add(line);
        }
    }
}
