using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using SpaceInvader.Boot;

namespace SpaceInvader.MainMenu
{
    public class MainMenu_View : BaseSceneView
    {
        public ScoreBoard.ScoreBoard_View scoreBoardView;

        public void LoadGameplayScene(){
            SceneLoader.Instance.LoadScene("Gameplay");
        }
    }
}
