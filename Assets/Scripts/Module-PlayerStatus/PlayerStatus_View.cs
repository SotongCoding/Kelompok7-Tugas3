using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Agate.MVC.Base;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public class PlayerStatus_View : ObjectView<IPlayerStatus_Model>
    {
        [SerializeField] TextMeshProUGUI playerScore;
        [SerializeField] Image[] playerHealth;

        protected override void InitRenderModel(IPlayerStatus_Model model)
        {
            playerScore.text = "Score : " + model.currentScore.ToString();
            for (int i = 0; i < 3 - model.playerHealth; i++)
            {
                playerHealth[i].gameObject.SetActive(false);
            }

        }

        protected override void UpdateRenderModel(IPlayerStatus_Model model)
        {
            playerScore.text = "Score : " + model.currentScore.ToString();
            for (int i = 0; i < 3 - model.playerHealth; i++)
            {
                playerHealth[i].gameObject.SetActive(false);
            }
        }
    }
}
