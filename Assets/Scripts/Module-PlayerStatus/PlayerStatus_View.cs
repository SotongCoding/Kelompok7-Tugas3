using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

using Agate.MVC.Base;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public class PlayerStatus_View : ObjectView<IPlayerStatus_Model>
    {
        [SerializeField] TextMeshProUGUI playerScore;
        [SerializeField] TextMeshProUGUI playerHealth;

        protected override void InitRenderModel(IPlayerStatus_Model model)
        {
            playerScore.text = model.currentScore.ToString();
            playerHealth.text = model.playerHealth.ToString();
        }

        protected override void UpdateRenderModel(IPlayerStatus_Model model)
        {
            playerScore.text = model.currentScore.ToString();
            playerHealth.text = model.playerHealth.ToString();
        }
    }
}
