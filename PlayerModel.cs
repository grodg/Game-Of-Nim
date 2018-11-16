/*Gavin Rodgers
 * This code controls the playout to the playerModel class
 * 3309 Project 1 Game of Nim 
 * Last edited: 9/22/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim.classes
{
    //the player class handles storing the information about each player
    class PlayerModel
    {
        //attribute for playername
        string playername;
        //constructor to the PlayerModel class
        public PlayerModel()
        {

        }
        //method for input name and count
        public PlayerModel(string name, int v)
        {

        }
        //method that sets playername class attribute equal to the input name
        public void setplayername(string name, int player)
        {
            playername = name;
        }
       
    }
}
