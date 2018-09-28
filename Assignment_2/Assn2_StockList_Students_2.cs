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
                StockNode previous = null;

                if (current.Next == null)
                {
                    length = 1;
                }
                else
                {
                    while (current.Next != null)
                    {
                        length++;

                        previous = current;
                        current = current.Next;
                    }
                    length = length + 1;
                }
            }
            return length;
    }
  }
}
