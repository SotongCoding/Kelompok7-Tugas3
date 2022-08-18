using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Agate.MVC.Base;
using SpaceInvader.Boot;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public class PlayerStatus_View : ObjectView<IPlayerStatus_Model>
    {
        [SerializeField] TextMeshProUGUI playerScore;
        [SerializeField] Image[] playerHealth;

        [SerializeField] GameObject GameOverUI;
        public InputField nameInput;

        public System.Action DonePlaying;

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

        public void ShowGameOverUI()
        {
            GameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
        public void Done()
        {
            DonePlaying?.Invoke();
            // SceneLoader.Instance.LoadScene("GamePlay");
        }
    }
}
