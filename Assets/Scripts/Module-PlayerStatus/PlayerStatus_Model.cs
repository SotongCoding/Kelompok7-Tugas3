using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public class PlayerStatus_Model : BaseModel, IPlayerStatus_Model
    {
        public int currentScore { private set; get; }
        public int playerHealth { private set; get; }
        public string playerName { private set; get; }

        public void AddScore(int value)
        {
            currentScore += value;
            SetDataAsDirty();
        }
        public void ReduceHealth()
        {
            playerHealth -= 1;
            SetDataAsDirty();
        }
        public void SetPlayerName(string name)
        {
            playerName = name;
        }
    }
}
