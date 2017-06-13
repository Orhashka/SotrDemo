using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotrDemo
{
    /*
        Stopwatch runtime = new Stopwatch();

        runtime.Start();
        Thread.Sleep(10000);
        runtime.Stop();

        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = runtime.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        */


    public static class SortingAlgorithms
    {


        public static void Swap(ref double a, ref double b)
        {
            double t = a;
            a = b;
            b = t;
        }

        public static string[] BubbleSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nBubble sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        //double temp = mas[j];
                        //mas[j] = mas[j + 1];
                        //mas[j + 1] = temp;
                        Swap(ref mas[j], ref mas[j + 1]);
                        ++step;
                        //log.Add("\r\n   Step №" + (step).ToString());
                        s = "\r\n";
                        for (int g = 0; g < Global.numOfElements; g++)
                            s += Math.Round(Global.array[g], 2) + "\t";
                        log.Add(s);
                    }
                }
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();
        }

        public static string[] CoctailSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nCoctail sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            int left = 0;
            int right = mas.Length - 1;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        Swap(ref mas[i], ref mas[i + 1]);
                        step++;
                        s = "\r\n";
                        for (int g = 0; g < Global.numOfElements; g++)
                            s += Math.Round(Global.array[g], 2) + "\t";
                        log.Add(s);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (mas[i - 1] > mas[i])
                    {
                        step++;
                        Swap(ref mas[i - 1], ref mas[i]);
                        s = "\r\n";
                        for (int g = 0; g < Global.numOfElements; g++)
                            s += Math.Round(Global.array[g], 2) + "\t";
                        log.Add(s);
                    }
                }
                left++;
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();
        }

        public static string[] GnomeSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nGnome sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            int spot = 1;
            while (spot < mas.Length)
            {
                if (spot == 0 || mas[spot - 1] < mas[spot])
                {
                    ++step;
                    s = "\r\n";
                    for (int g = 0; g < Global.numOfElements; g++)
                        s += Math.Round(Global.array[g], 2) + "\t";
                    log.Add(s);
                    spot++;
                }
                else
                {
                    Swap(ref mas[spot - 1], ref mas[spot]);
                    ++step;
                    s = "\r\n";
                    for (int g = 0; g < Global.numOfElements; g++)
                        s += Math.Round(Global.array[g], 2) + "\t";
                    log.Add(s);
                    spot--;
                }
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();
        }

        public static string[] InsertionSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nInsertion sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            int spot = 1;
            while (spot < mas.Length)
            {
                if (spot == 0 || mas[spot - 1] < mas[spot])
                {
                    ++step;
                    s = "\r\n";
                    for (int g = 0; g < Global.numOfElements; g++)
                        s += Math.Round(Global.array[g], 2) + "\t";
                    log.Add(s);
                    spot++;
                }
                else
                {
                    Swap(ref mas[spot - 1], ref mas[spot]);
                    ++step;
                    s = "\r\n";
                    for (int g = 0; g < Global.numOfElements; g++)
                        s += Math.Round(Global.array[g], 2) + "\t";
                    log.Add(s);
                    spot--;
                }
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();
        }

        public static string[] MergeSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nMerge sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            mas = MergeRec(mas);

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();
        }

        public static double[] MergeRec(double[] mass)
        {
            if (mass.Length > 1)
            {
                double[] left = new double[mass.Length / 2];
                double[] right = new double[mass.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = mass[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = mass[left.Length + i];
                }

                if (left.Length > 1)
                    left = MergeRec(left);
                if (right.Length > 1)
                    right = MergeRec(right);


                int li = 0, ri = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (ri >= right.Length)
                    {
                        mass[i] = left[li];
                        li++;
                    }
                    else if (li < left.Length && left[li] < right[ri])
                    {
                        mass[i] = left[li];
                        li++;
                    }
                    else
                    {
                        mass[i] = right[ri];
                        ri++;
                    }
                }
            }
            //возврат отсортированного массива
            return mass;
        }

        public static string[] SelectionSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nSelection sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                        min = j;
                }
                Swap(ref mas[i], ref mas[min]);

                s = "\r\n";
                for (int g = 0; g < Global.numOfElements; g++)
                    s += Math.Round(Global.array[g], 2) + "\t";
                log.Add(s);
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();

        }

        public static string[] CombSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nComb sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            double gap = mas.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < mas.Length)
                {
                    int igap = i + (int)gap;
                    if (mas[i] > mas[igap])
                    {
                        Swap(ref mas[i], ref mas[igap]);
                        swaps = true;

                        s = "\r\n";
                        for (int g = 0; g < Global.numOfElements; g++)
                            s += Math.Round(Global.array[g], 2) + "\t";
                        log.Add(s);
                    }
                    i++;
                }
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();

        }

        public static string[] ShellSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nShell sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            int st = mas.Length / 2;
            while (st > 0)
            {
                int i, j;
                for (i = st; i < mas.Length; i++)
                {
                    double value = mas[i];
                    for (j = i - st; (j >= 0) && (mas[j] > value); j -= st)
                        mas[j + st] = mas[j];
                    mas[j + st] = value;
                }
                st /= 2;
            }

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();

        }

        public static string[] QuickSort(double[] mas)
        {
            List<string> log = new List<string>();
            Stopwatch runtime = new Stopwatch();

            log.Add("\r\nQuick sorting algorithm");
            log.Add("\r\n" + DateTime.Now.ToString());
            log.Add("\r\nArray:");
            string s = "\r\n";
            for (int i = 0; i < Global.numOfElements; i++)
                s += Math.Round(Global.array[i], 2) + "\t";
            log.Add(s);
            int step = 0;

            runtime.Start();
            ////////////////////////////////////////////

            quickSort(mas,0, mas.Length-1);

            ///////////////////////////////////////////

            runtime.Stop();

            log.Add("\r\n\r\nResult:");
            s = "\r\n";
            for (int g = 0; g < Global.numOfElements; g++)
                s += Math.Round(Global.array[g], 2) + "\t";
            log.Add(s);
            log.Add("\r\n\r\nSteps: " + step.ToString());
            log.Add("\r\nTime: " + runtime.Elapsed.ToString());

            return log.ToArray();

        }

        static void quickSort(double[] a, int l, int r)
        {
            double x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    Swap(ref a[i], ref a[j]);
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }


    }
}
