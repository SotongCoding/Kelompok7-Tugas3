using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

using SpaceInvader.Character;

namespace SpaceInvader.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        public Gameplay.PlayerStatus.PlayerStatus_View statusView;
        public Character_View baseObjectView;
        public EnemySatu_View enemySatuView;
        public AlienShip_View alienShipView;
        public UFO_View ufoView;
        public Pooling.ActivateEnemy activateView;
    }
}