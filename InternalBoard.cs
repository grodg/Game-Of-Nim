/* Gavin Rodgers
 * This creates the class for the Internal Board class
 * 3309 Project 1 Game of Nim
 * Last updated: 9/22/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.classes
{
    //the Internal Board class that handles the game board
    class InternalBoard
    {
        //class variable attributes
        private const int marblesCountMax = 16;
        private int maxRows;
        private int currentMarbleCount = 0;
        private int[] rowMarbleCounts;

        //constructor for the internal board class
        public InternalBoard()
        {
        }
        //builds the rowMarbleCount array 
        public InternalBoard(int rowCount)
        {
            maxRows = rowCount;
            currentMarbleCount = marblesCountMax;
            rowMarbleCounts = new int[maxRows];
            for(int i = 0; i < maxRows; i++)
            {
                rowMarbleCounts[i] = 2 * i + 1;
            }
        }
        //updates the rowMarbleCount array and returns a boolean if its empty or full
        public bool recordTurn(int rowId, int currenSelectionCount)
        {
            rowMarbleCounts[rowId] = rowMarbleCounts[rowId] - currenSelectionCount;
            currentMarbleCount = currentMarbleCount - currenSelectionCount;
            if (rowMarbleCounts[rowId] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     //gets the remaining row count for an index input
        public int getRowCount(int i)
        {
            return rowMarbleCounts[i];
        }
       // determines whether or not the game has finished and theres a winner
        public bool isWinner()
        {
             bool winner = false;
            if (currentMarbleCount == 0 || currentMarbleCount == -1)
            {
                winner = true;
            }
            else if (currentMarbleCount != 0)
            {
                winner = false;
            }
            return winner;
        }
        
    }
}
