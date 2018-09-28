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

            /* 1. total stock one holdings
             2. find stock two - make sure not doing the one that is stock 1
             3. total stock two holdings 
             4. compare stock one and two
             5. make stock one the one with largest holdings
             6. repeat 2-5 until at end of list*/

            StockNode current = this.head;
            Stock stockOne = current.StockHolding.Name; // you are trying to assign object of type Stock to a string(name)
            // you either want to create a string to keep the name object
            // or better yet assign do  Stock stockOne = current.Stockholding
            // then you can call stockOne.name to refer to the name
            Stock stockTwo = null;
            Stock stockThree = null;
            int holdingOne = 0;
            int holdingTwo = 0;
            int holdingThree = 0;
            //figure out how to get current node stock name 
            holdingOne = ToInt32(current.StockHolding.Holdings);
            //figure out how to get current node holdings and get to int 
            while (current.Next != null)
            {
                current = current.Next;
                stockThree = current.StockHolding.Name;
                //figure out hoe to get current node name
                if (stockOne.Equals(stockThree))
                {
                    holdingThree = current.StockHolding.Holdings;
                    //figure out how to get current node holdings
                    holdingOne = holdingOne + holdingThree;

                }
            }
            while (current.Next != null)
            {
                current = current.Next;
                if (stockOne.Equals(current.StockHolding.Name))
                { current = current.Next; }
                else
                {
                    stockTwo = current.StockHolding.Name;
                    //find out how to get current node name
                    holdingTwo = current.StockHolding.Holdings;
                    //find out how to get current node holdings
                    while (current.Next != null)
                    {
                        current = current.Next;
                        stockThree = current.StockHolding.Name;
                        //same as above
                        if (stockTwo.Equals(stockThree))
                        {
                            holdingThree = current.StockHolding.Holdings;
                            holdingTwo = holdingTwo + holdingThree;
                        }
                    }

                }
                if (holdingOne.CompareTo(holdingTwo) < 0)
                //find another way to compare
                {
                    stockOne = stockTwo;
                    holdingOne = holdingTwo;
                }
                mostShareStock = stockOne;
            }
            return mostShareStock;
        }
    }
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
