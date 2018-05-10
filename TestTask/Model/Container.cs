using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.CustomException;

namespace TestTask.Model
{
    public class Container<T> : PMCDataModel<Matrix<T>> where T : struct
    {
        public bool check;
        public static int count = 0;

        public new void Add(Matrix<T> item)
        {
            if (count == 0 | count == item.Count)
            {
                count = item.Count;
                base.Add(item);
                check = true;
            }
            else
            {
                check = false;
                throw new InvalidMatrixCountException("All matrices in all containers should have the same number of possition. Try again...");                
            }
        }

        public new void AddRange(IEnumerable<Matrix<T>> item)
        {
            Matrix<T>[] matrices = item.ToArray();

            for (int i = 0; i < matrices.Length; i++)
            {
                if(count == 0 || count == matrices[i].Count)
                {
                    count = matrices[i].Count;
                    base.Add(matrices[i]);
                    check = true;
                }
                else
                {
                    throw new InvalidMatrixCountException("All matrices in all containers should have the same number of possition. Try again...");
                    check = false;
                }
            }
        }

    }
}
