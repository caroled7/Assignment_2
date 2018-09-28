using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      Stock mostShareStock = null;

      // write your implementation here
      // idea = use sort by value, then retrieve first stock in list

      return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
   public int Length()
    {
      int length = 0;

            if (this.IsEmpty())
            {
                return length;
            }
            else
            {
                StockNode current = this.head;
             //   StockNode previous = null; // no need for previous

                if (current.Next == null) // good, this situation will only happen if there is one item in list
                {
                    length = 1;
                }
                else
                {
                    length = 1; // if you don't start with 1 here, you will be short one item

                    while (current.Next != null)
                    {
                        length++;

                     //   previous = current; // no need for previous
                        current = current.Next;

                     
                    }
                    length = length + 1; // this is the same as length ++, it works here, I just find it easier to be consistent;
                }
            }
            return length;
    }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            // write your implementation here

        }

    }
}
