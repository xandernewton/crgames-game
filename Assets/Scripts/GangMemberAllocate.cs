﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRGames_game
{



    public class GangMemberAllocate : MonoBehaviour
    {

        Map map;
        Player aPlayer;

        GangMemberAllocate(Map map, Player aPlayer)
        {
            this.map = map;
            this.aPlayer = aPlayer;
        }



        public int calculateMembers()
        {
            int noOfGangMembers = aPlayer.GetOwnedTiles().Count; 
            
            return 0;
        }





    }
}