using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public interface IPlayerStatus_Model : IBaseModel
    {
        int currentScore { get; }
        int playerHealth { get; }


        string playerName { get; }
    }
}
