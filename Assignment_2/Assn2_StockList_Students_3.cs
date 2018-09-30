using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
        {
            decimal value = 0.0m;

            if (this.IsEmpty())
            {
                return value;
            }
            else
            {
                StockNode current = this.head;
                decimal currentStockQty = current.StockHolding.Holdings;
                decimal currentStockPrice = current.StockHolding.CurrentPrice;

                while (current.Next != null)
                {
                    value = value + (currentStockQty * currentStockPrice);

                    current = current.Next;
                    currentStockQty = current.StockHolding.Holdings;
                    currentStockPrice = current.StockHolding.CurrentPrice;
                }
                value = value + (currentStockQty * currentStockPrice);
            }   return value;
        }

                        // Dom: Ok. I changed the code and ran this through it's paces against the program.
                        // I removed the previous node and added a reset of the currentStockQty
                        // and currentStockPrice so that those variables update with new nodes. 
                        
                        //  Chris:  I don't think you need to create previous
                        //  because you don't need to manipulate node positions, just traverse
                        // I think you should be good with current and current.next
                        //  You can compare with professor's function for AddLast, 
                        // the section titled  // traverse the list till the end
                        // I have commented out code in Assn2_Program_test.cs file
                        // so that it just shows portfolio value
                        // you can run this file to test out your code
                        // From what I can now see, 
                        // we also need to update the PortfolioValue {get;set;} 
                        // so that value can show after stock has been added.
                        // Not sure how to do this just yet
                        // I have added two console write lines below to help you 
                        // track what you are doing and test out your results
                        Console.WriteLine("Inner Loop value :" + value);
                      
                      //I think you may need to also put Console.ReadLine()
                      //this can help have the result show up on your screen
                      //Carole might need to correct me but i beleive that is what she showed me


    //param  (StockList) listToCompare     : StockList which has to compared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
            public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            StockNode listToCompareCurrent = listToCompare.head;
            StockNode listToComparePrevious = null;
            StockNode thisListCurrent = this.head;
            StockNode thisListPrevious = null;

            if (listToCompare.IsEmpty() || this.IsEmpty())
            {
                return similarityIndex;
            }
            else
            {
                while (thisListCurrent != null)
                {
                    while (listToCompareCurrent != null)
                    {
                        if (thisListCurrent.StockHolding.Symbol == listToCompareCurrent.StockHolding.Symbol)
                        {
                            similarityIndex++;

                            listToComparePrevious = listToCompareCurrent;
                            listToCompareCurrent = listToCompareCurrent.Next;
                        }
                        else
                        {
                            listToComparePrevious = listToCompareCurrent;
                            listToCompareCurrent = listToCompareCurrent.Next;
                        }
                    }
                    listToCompareCurrent = listToCompare.head;
                    listToComparePrevious = null;
                    thisListPrevious = thisListCurrent;
                    thisListCurrent = thisListCurrent.Next;
                } return similarityIndex;
            }
        }
        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("There is nothing to print.");
                Console.ReadLine();
            }
            else
            {
                StockNode current = this.head;
                StockNode previous = null;

                while (current.Next != null)
                {
                    Console.WriteLine("Stock Symbol: " + current.StockHolding.Symbol + "       " + "Stock Name: " +
                        current.StockHolding.Name + "       " + "Stock Holdings: " + current.StockHolding.Holdings + "       " +
                        "Current Price: " + current.StockHolding.CurrentPrice);

                    previous = current;
                    current = current.Next;
                }

                Console.WriteLine("Stock Symbol: " + current.StockHolding.Symbol + "       " + "Stock Name: " +
                        current.StockHolding.Name + "       " + "Stock Holdings: " + current.StockHolding.Holdings + "       " +
                        "Current Price: " + current.StockHolding.CurrentPrice);
            }

        }
    }
}
