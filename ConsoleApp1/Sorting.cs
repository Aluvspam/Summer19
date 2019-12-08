using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sorting
    {
        AbstractSortStrategy sortStrategy;
        public Sorting()
        {
            sortStrategy = new InsertSort();
        }
        public void Sort(int[] data)
        {
            sortStrategy.Sort(data);
        }
        public void SetStrategy(AbstractSortStrategy newSortStrategy)
        {
            sortStrategy = newSortStrategy;
        }
    }

    public abstract class AbstractSortStrategy
    {
        public abstract void Sort(int[] data);
        public void Swap(int[] data, int m, int n)
        {
            int temporary;
            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }

    public class InsertSort : AbstractSortStrategy
    {
        public override void Sort(int[] data)
        {
            for (int sorted = 1; sorted < data.Length; sorted++)
            {
                int extracted = data[sorted];
                bool extractedPlaced = false;
                for (int i = sorted - 1; i >= 0; i--)
                {
                    if (data[i] > extracted)
                    {
                        data[i + 1] = data[i];
                    }
                    else
                    {
                        data[i + 1] = extracted;
                        extractedPlaced = true;
                        break;
                    }
                }
                if (!extractedPlaced)
                {
                    data[0] = extracted;
                }
            }
        }
    }
}
