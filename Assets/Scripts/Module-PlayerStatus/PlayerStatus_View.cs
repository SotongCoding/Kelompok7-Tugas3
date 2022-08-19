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
        [SerializeField] Text show_playerScore;
        [SerializeField] Image[] playerHealth;

        [SerializeField] GameObject GameOverUI;
        public InputField nameInput;

        public System.Action DonePlaying;

        protected override void InitRenderModel(IPlayerStatus_Model model)
        {
            playerScore.text = "Score : " + model.currentScore.ToString();
            show_playerScore.text = "Current Score :\n" + model.currentScore.ToString();
            for (int i = 0; i < 3 - model.playerHealth; i++)
            {
                playerHealth[i].gameObject.SetActive(false);
            }

        }

        protected override void UpdateRenderModel(IPlayerStatus_Model model)
        {
            playerScore.text = "Score : " + model.currentScore.ToString();
            show_playerScore.text = "Current Score :\n" + model.currentScore.ToString();

            if (model.playerHealth < 0) return;
            for (int i = 0; i < 3 - model.playerHealth; i++)
            {
                playerHealth[i].gameObject.SetActive(false);
            }
        }

        public void ShowGameOverUI()
        {
            GameOverUI.SetActive(true);
        }
        public void Done()
        {
            if (string.IsNullOrEmpty(nameInput.text)) Debug.Log("Input Name Pls");
            else DonePlaying?.Invoke();
            // SceneLoader.Instance.LoadScene("GamePlay");
        }
    }
}
