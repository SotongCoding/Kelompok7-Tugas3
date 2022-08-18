using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using SpaceInvader.Boot;
using SpaceInvader.Gameplay.PlayerStatus;
using SpaceInvader.ScoreBoard;
using SpaceInvader.PowerUps;
using SpaceInvader.Character;

namespace SpaceInvader.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private PlayerStatus_Controller _playerStatusControl;
        private BaseObject_Controller _baseObjectControl;
        private EnemySatu_Controller _enemySatuControl;
        private AlienShip_Controller _alienShipControl;
        private UFO_Controller _ufoControl;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector(),
                
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new PlayerStatus_Controller(),
                new PowerUps_Controller(),

                new BaseObject_Controller(),
                new EnemySatu_Controller(),
                new AlienShip_Controller(),
                new UFO_Controller()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _playerStatusControl.SetView(_view.statusView);
            _baseObjectControl.SetView(_view.baseObjectView);
            _enemySatuControl.SetView(_view.enemySatuView);
            _alienShipControl.SetView(_view.alienShipView);
            //_ufoControl.SetView(_view.ufoView);
            

            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}