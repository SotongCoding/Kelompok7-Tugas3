using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using SpaceInvader.Boot;
namespace SpaceInvader.MainMenu
{
    public class MainMenu_Launcher : SceneLauncher<MainMenu_Launcher, MainMenu_View>
    {
        private ScoreBoard.ScoreBoard_Controller _scoreBoard;
        public override string SceneName => "MainMenu";

        protected override IConnector[] GetSceneConnectors()
        {
            //This is Testing
            return new IConnector[]
             {
                new Gameplay.GameplayConnector(),
             };
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _scoreBoard.SetView(_view.scoreBoardView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

    }
}
