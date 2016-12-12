using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorting_algorithm_representation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p;
            InsertionSort aInsertionSort = new InsertionSort(listBox1.Items.Count);
            for (p = 0; p < listBox1.Items.Count; p++)
            {
                aInsertionSort.A[p] = int.Parse(listBox1.Items[p].ToString());
            }
            if (comboBox1.SelectedItem.ToString() == "Insertion Sort")
            {
                aInsertionSort.sortedList();
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    listBox2.Items.Add(aInsertionSort.A[pp].ToString());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Merge Sort")
            {
                MergeSort aMergeSort = new MergeSort();
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    aMergeSort.A[pp] = int.Parse(listBox1.Items[pp].ToString());
                }
                p = 1;
                int r = listBox1.Items.Count;
                aMergeSort.mergeSort(aMergeSort.A, p, r);
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    listBox2.Items.Add(aMergeSort.A[pp].ToString());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Quick Sort")
            {
                QuickSort aQuickSort = new QuickSort();
                p = 0;
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    aQuickSort.A[pp] = int.Parse(listBox1.Items[pp].ToString());
                }
                int r = listBox1.Items.Count-1;
                aQuickSort.quickSort(aQuickSort.A, p, r);
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    listBox2.Items.Add(aQuickSort.A[pp].ToString());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Bubble Sort")
            {
                BubbleSort aBubbleSort = new BubbleSort();
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    aBubbleSort.A[pp] = int.Parse(listBox1.Items[pp].ToString());
                }
                int n = listBox1.Items.Count;
                aBubbleSort.bubbleSort(aBubbleSort.A, n);
                for (int pp = 0; pp < listBox1.Items.Count; pp++)
                {
                    listBox2.Items.Add(aBubbleSort.A[pp].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
