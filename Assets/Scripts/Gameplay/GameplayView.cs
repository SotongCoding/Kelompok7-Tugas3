using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

using SpaceInvader.Gameplay.PlayerStatus;

namespace SpaceInvader.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public PlayerStatus_View statusView;
    }
}