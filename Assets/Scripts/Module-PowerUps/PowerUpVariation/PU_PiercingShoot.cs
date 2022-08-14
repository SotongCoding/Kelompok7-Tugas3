using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SpaceInvader.Character;
 
namespace SpaceInvader.PowerUps
{
    public class PU_PiercingShoot : PowerUps_Model
    {

        public override void OnPick()
        {

            Debug.Log("Character Shoot hit 2 enemys");
            
        }
    }
}