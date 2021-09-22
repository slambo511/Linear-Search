using System;
using System.Windows.Forms;

namespace Linear_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Please enter some integers, separated by spaces:");
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');
            for (int i = 0; i < integers.Length; i++)
                MessageBox.Show("i=" + i + " integers[i]=" + integers[i]);
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(integers[i]);

            for (int i = 0; i < data.Length; i++)
                MessageBox.Show("i=" + i + " data[i]=" + data[i]);

            while (true)
            {
                MessageBox.Show("Please enter a number you want to find (blank line to end):");
                input = Console.ReadLine();
                if (input.Length == 0)
                    break;
                int searchItem = int.Parse(input);
                MessageBox.Show("Please enter a position to start searching from (0 for beginning): ");
                input = Console.ReadLine();
                int searchPos = int.Parse(input);
                int foundPos = IntArrayLinearSearch(data, searchItem, searchPos);
                if (foundPos < 0)
                    MessageBox.Show("Item " + searchItem + " not found");
                else
                    MessageBox.Show("Item " + searchItem + " found at position " + foundPos);
            }
        }

        public static int IntArrayLinearSearch(int[] data, int item, int start)
         {
                int N = data.Length;
                if (start < 0)
                    return -1;
                for (int i = start; i < N; i++)
                    if (data[i] == item)
                        return i;
                return -1;
         }

    }
}
