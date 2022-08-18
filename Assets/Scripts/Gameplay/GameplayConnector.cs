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
        private Character.AlienShip_Controller _alienShip;
        private Character.UFO_Controller _ufo;
        private Pooling.ActivateEnemy_Controller _activateEnemy;

        protected override void Connect()
        {
            Subscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);
            Subscribe<characterTakeDamageMessage>(TakeDamage);

            Subscribe<EnemyTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Subscribe<AlienTakeDamageMessage>(AlienTakeDamage);
            Subscribe<UfoTakeDamageMessage>(UfoTakeDamage);
            Subscribe<AlienShipSpawnMessage>(_activateEnemy.Spawn);

            Subscribe<AddNewScoreMessege>(_scoreBoard.AddNewScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);
            Unsubscribe<characterTakeDamageMessage>(TakeDamage);

            Unsubscribe<EnemyTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Unsubscribe<AlienTakeDamageMessage>(AlienTakeDamage);
            Unsubscribe<UfoTakeDamageMessage>(UfoTakeDamage);
            Unsubscribe<AlienShipSpawnMessage>(_activateEnemy.Spawn);

            Unsubscribe<AddNewScoreMessege>(_scoreBoard.AddNewScore);

        }

        void TakeDamage(characterTakeDamageMessage TD)
        {
            Debug.Log("HIT");
        }
        void AlienTakeDamage(AlienTakeDamageMessage ATD)
        {
            Debug.Log("Hancur");
        }
        void UfoTakeDamage(UfoTakeDamageMessage UTD)
        {
            Debug.Log("Hilang");
        }
    }
}