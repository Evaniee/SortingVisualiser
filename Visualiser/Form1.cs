using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Schema;
using ColorHelper;
using System.Linq;

namespace Visualiser
{
    public partial class Form1 : Form
    {
        private int[] _array;
        private Random rng;
        private int interval;
        private bool allowDuplicates;

        public Form1()
        {
            rng = new Random();
            InitializeComponent();
            RandomiseArray();
            allowDuplicates = false;
        }

        /// <summary>
        /// Perform a bubble sort on _array
        /// </summary>
        private void BubbleSort()
        {
            bool swapped;
            int loops = 0;
            // Loop until no swaps were performed in a look
            do
            {
                swapped = false;
                // Check each pair, check 1 less pair per loop completed
                for (int i = 0, j = 1; j < _array.Length - loops; i++, j++)
                {
                    // Swap out of order pairs
                    if(_array[i] > _array[j])
                    {
                        Swap(i, j);
                        swapped = true;
                    }
                }
                loops++;
            }
            while (swapped);
        }

        private void RandomiseArray()
        {
            // Parse Text Boxes
            int length, min, max;
            if(!int.TryParse(ts_txt_length.Text, out length))
            {
                MessageBox.Show("ERROR: Length must be an integer");
                return;
            }
            if(!int.TryParse(ts_txt_min.Text, out min))
            {
                MessageBox.Show("ERROR: Minimum value must be an integer");
                return;
            }
            if(!int.TryParse(ts_txt_max.Text, out max))
            {
                MessageBox.Show("ERROR: Maximum value must be an integer");
                return;
            }

            // Ensure min < max
            max = max + 1;
            if(min >= max)
            {
                MessageBox.Show("ERROR: Minimum value must be below maximum value");
                return;
            }

            // Ensure enough values are present if duplicates are not allowed
            if(max - min < length && !allowDuplicates)
            {
                MessageBox.Show("ERROR: Insufficent number of values to prevent duplicates");
                return;
            }

            // Randomise Array
            _array = new int[length];
            for (int i = 0; i < length; i++)
            {
                int number = rng.Next(min, max);
                // Duplicate check
                if (allowDuplicates || !_array.Contains(number))
                    _array[i] = number;
                else    // Re-run this attempt
                    i--;
            }

            // Resize visualiser
            pb_visualiser.Height = max;
            pb_visualiser.Width = length * 3;

            pb_visualiser.Refresh();
        }

        /// <summary>
        /// Perform bogosort on _array
        /// </summary>
        private void BogoSort()
        {
            bool sorted = false;

            // Loop while not sorted
            while (!sorted)
            {
                sorted = true;

                // Random Swap
                Swap(rng.Next(0, _array.Length), rng.Next(0, _array.Length));

                // Check if sorted
                for (int i = 0, j = 1; j < _array.Length; i++, j++)
                    if (_array[i] > _array[j])
                    {
                        sorted = false;
                        break;
                    }
            }
        }

        /// <summary>
        /// Perform a quick sort on _array
        /// </summary>
        /// <param name="leftIndex">Left side index</param>
        /// <param name="rightIndex">Right side index</param>
        private void QuickSort(int leftIndex, int rightIndex)
        {
            int left = leftIndex;
            int right = rightIndex;
            int mid = (leftIndex + rightIndex) / 2; // Find the middle index
            int pivot;

            // Determine Pivot via median of 3
            if (left > mid)
                if (left < right)
                    pivot = _array[left];
                else if (mid > right)
                    pivot = _array[mid];
                else
                    pivot = _array[right];
            else
                if (left > right)
                    pivot = _array[left];
                else if (mid < right)
                    pivot = _array[mid];
                else
                    pivot = _array[right];

            // Sort
            while (left <= right)
            {
                while (_array[left] < pivot) left++;    // Increase Left
                while (_array[right] > pivot) right--;  // Reduce Right
                if (left <= right)                      // Out of place
                {
                    Swap(left, right);
                    left++;
                    right--;
                }
            }

            // Sorting Finished, find new pivot to sort from
            if (leftIndex < right)
                QuickSort(leftIndex, right);
            if (left < rightIndex)
                QuickSort(left, rightIndex);

            return;
        }

        private void ts_btn_randomise_Click(object sender, EventArgs e)
        {
            RandomiseArray();
        }

        private void ts_btn_bubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void ts_txt_interval_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(ts_txt_interval.Text, out interval);
        }

        /// <summary>
        /// Swap array indexes
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap(int i, int j)
        {
            int temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;

            pb_visualiser.Refresh();
        }

        private void pb_visualiser_Paint(object sender, PaintEventArgs e)
        {
            if (_array == null) return;

            // Paint each value as a rectangle with height and colour matching its value
            for(int i = 0; i < _array.Length; i++)
            {
                Rectangle rectangle = new Rectangle(i * 3, pb_visualiser.Height - _array[i], 3, _array[i]);
                ColorHelper.RGB colour = ColorHelper.ColorConverter.HslToRgb(new HSL(_array[i], 50, 50));

                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(colour.R, colour.G, colour.B)), rectangle);
            }

            System.Threading.Thread.Sleep(interval);
        }

        private void ts_btn_allowDuplicates_Click(object sender, EventArgs e)
        {
            allowDuplicates = !allowDuplicates;

            if (allowDuplicates)
                ts_btn_allowDuplicates.Text = "Duplicates: True";
            else
                ts_btn_allowDuplicates.Text = "Duplicates: False";
        }

        private void ts_btn_quickSort_Click(object sender, EventArgs e)
        {
            QuickSort(0, _array.Length - 1);
        }

        private void ts_btn_bogoSort_Click(object sender, EventArgs e)
        {
            BogoSort();
        }
    }
}
