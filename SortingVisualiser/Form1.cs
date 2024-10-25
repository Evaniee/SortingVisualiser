using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualiser
{
    public partial class Form1 : Form
    {
        private int[] array;
        private int indexI, indexJ;
        private const int width = 5, scaling = 3;
        private bool swapped;
        private SolidBrush 
            brushNormal = new SolidBrush(Color.Black),
            brushSwap = new SolidBrush(Color.Green),
            brushNoSwap = new SolidBrush(Color.Red);

        public Form1()
        {
            MakeArray();
            InitializeComponent();
            BubbleSort();
        }

        private void MakeArray()
        {
            Random rng = new Random();
            array = new int[rng.Next(100, 101)];
            for (int i = 0; i < array.Length; i++)
                array[i] = rng.Next(1, 101);
        }

        private Rectangle[] GetBars()
        {
            Rectangle[] bars = new Rectangle[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                bars[i] = new Rectangle(width * i, pictureBox1.Height - array[i] * scaling, width, array[i] * scaling);
            }
            return bars;
        }

        private async void BubbleSort()
        {
            int loops = 0;
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0, j = 1; j < array.Length - loops; i++, j++)
                {
                    if (array[i] > array[j])
                    {
                        swapped = true;
                        Swap(i, j);
                        sorted = false;
                    }
                    else
                    {
                        swapped = false;
                    }
                    pictureBox1.Refresh();
                    await Task.Delay(10);
                }
                loops++;
            } while (!sorted);
        }

        private async void SelectionSort()
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                int minValue = array[i];
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (minValue > array[j])
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }
                Swap(int i)
            }
        }

        private void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            indexI = i;
            indexJ = j;
        }
    }
}