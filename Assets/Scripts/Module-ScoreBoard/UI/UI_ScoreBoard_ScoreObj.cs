using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace SpaceInvader.ScoreBoard
{
    public class UI_ScoreBoard_ScoreObj : MonoBehaviour
    {
        [SerializeField] public Text playerName;
        [SerializeField] public Text scoreValue;

        internal void SetScore(SocoreBoardData socoreBoardData)
        {
            playerName.text = socoreBoardData.name;
            scoreValue.text = socoreBoardData.score.ToString();
        }
    }
}
