using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

using SpaceInvader.Gameplay.PlayerStatus;
using SpaceInvader.Messege;
using SpaceInvader.ScoreBoard;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private ScoreBoard_Controller _scoreBoard;
        private PlayerStatus_Controller _playerStatus;

        void OnUpdateHealth(UpdateHealthMessege messege)
        {
            //Maybe Sfx when player Get Hit
        }

        void OnUpdateScore(UpdateScoreMessege messege)
        {
            //Maybe Sfx when player recive Score
        }
        void OnCharacterDieMessege(CharacterDieMessege messege)
        {
            _scoreBoard.AddNewScore(new SocoreBoardData(messege.playerName, messege.lastScore));
        }

        protected override void Connect()
        {
            Subscribe<UpdateHealthMessege>(OnUpdateHealth);
            Subscribe<UpdateScoreMessege>(OnUpdateScore);
            Subscribe<CharacterDieMessege>(OnCharacterDieMessege);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateHealthMessege>(OnUpdateHealth);
            Unsubscribe<UpdateScoreMessege>(OnUpdateScore);
            Subscribe<CharacterDieMessege>(OnCharacterDieMessege);
        }
    }
}