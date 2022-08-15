using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

using SpaceInvader.Gameplay.PlayerStatus;
using SpaceInvader.Messege;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private ScoreBoard.ScoreBoard_Controller _scoreBoard;
        private PowerUps.PowerUps_ControllerContainer _powerUpContainer;
        Gameplay.PlayerStatus.PlayerStatus_Controller _playerStatus;

        protected override void Connect()
        {
            Subscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);
            Subscribe<characterTakeDamageMessage>(TakeDamage);

            Subscribe<EnemyTakeDamageMessage>(EnemyTakeDamage);
            Subscribe<EnemyTakeDamageMessage>(_playerStatus.EnemyTakeDamage);

            Subscribe<AddNewScoreMessege>(_scoreBoard.AddNewScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);
            Unsubscribe<characterTakeDamageMessage>(TakeDamage);

            Unsubscribe<EnemyTakeDamageMessage>(EnemyTakeDamage);
            Unsubscribe<EnemyTakeDamageMessage>(_playerStatus.EnemyTakeDamage);

            Unsubscribe<AddNewScoreMessege>(_scoreBoard.AddNewScore);

        }

        void TakeDamage(characterTakeDamageMessage TD)
        {
            Debug.Log("HIT");
        }
        void EnemyTakeDamage(EnemyTakeDamageMessage ETD)
        {
            Debug.Log("Destroy");
        }
    }
}