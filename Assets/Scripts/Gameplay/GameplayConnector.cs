using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

using SpaceInvader.Gameplay.PlayerStatus;
using SpaceInvader.Messege;
using SpaceInvader.Character;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private ScoreBoard.ScoreBoard_Controller _scoreBoard;
        private PowerUps.PowerUps_ControllerContainer _powerUpContainer;
        Gameplay.PlayerStatus.PlayerStatus_Controller _playerStatus;
        private AlienShip_Controller _alienShip;

        protected override void Connect()
        {
            Subscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);
            Subscribe<characterTakeDamageMessage>(TakeDamage);

            Subscribe<EnemyTakeDamageMessage>(EnemyTakeDamage);
            Subscribe<EnemyTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Subscribe<AlienTakeDamageMessage>(AlienTakeDamage);

            Subscribe<AddNewScoreMessege>(_scoreBoard.AddNewScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);
            Unsubscribe<characterTakeDamageMessage>(TakeDamage);

            Unsubscribe<EnemyTakeDamageMessage>(EnemyTakeDamage);
            Unsubscribe<EnemyTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Unsubscribe<AlienTakeDamageMessage>(AlienTakeDamage);

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
        void AlienTakeDamage(AlienTakeDamageMessage ATD)
        {
            Debug.Log("Hancur");
        }
    }
}