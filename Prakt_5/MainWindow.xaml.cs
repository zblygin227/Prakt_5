using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prakt_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            CheckArrays();
        }

        private void CheckArrays()
        {
            // Создаем двумерные массивы
            int[,] array1 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[,] array2 = { { 1, 5, 7 }, { 2, 3, 4 }, { 10, 14, 15 } };

            // Проверяем каждый столбец первого массива
            output1.Text = "Столбцы с кратными 5 или 7 элементами в массиве 1:\n";
            CheckColumns(array1, output1);

            // Проверяем каждый столбец второго массива
            output2.Text = "\nСтолбцы с кратными 5 или 7 элементами в массиве 2:\n";
            CheckColumns(array2, output2);
        }

        private void CheckColumns(int[,] array, TextBlock output)
        {
            int columns = array.GetLength(1);
            bool hasValidColumns = false;

            for (int i = 0; i < columns; i++)
            {
                bool isValidColumn = true;

                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[j, i] % 5 != 0 && array[j, i] % 7 != 0)
                    {
                        isValidColumn = false;
                        break;
                    }
                }

                if (isValidColumn)
                {
                    output.Text += "Столбец " + (i + 1) + "\n";
                    hasValidColumns = true;
                }
            }

            if (!hasValidColumns)
            {
                output.Text += "Нет столбцов с кратными 5 или 7 элементами\n";
            }
        }
    }
}
    

