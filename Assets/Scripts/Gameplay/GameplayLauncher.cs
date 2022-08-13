using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

using SpaceInvader.Boot;
using SpaceInvader.Gameplay.PlayerStatus;

namespace SpaceInvader.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private PlayerStatus_Controller _scoreControl;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new PlayerStatus_Controller(),
                // new SoundfxController(),
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _scoreControl.SetView(_view.statusView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}