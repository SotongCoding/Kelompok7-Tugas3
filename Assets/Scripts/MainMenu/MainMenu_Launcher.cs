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
        public override string SceneName => "MainMenu";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
