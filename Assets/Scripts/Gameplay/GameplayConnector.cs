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
        private Character.Character_Controller _character;

        protected override void Connect()
        {
            Subscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);

            // Subscribe<AlienTakeDamageMessage>(AlienTakeDamage);
            Subscribe<AlienTakeDamageMessage>(_powerUpContainer.OnAlienShipDie);

            Subscribe<AlienTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Subscribe<UfoTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Subscribe<CharacterDieMessege>(_playerStatus.ShowGameOver);

            Subscribe<RecivePowerUpMessege>(_character.GetPowerUp);
            //Subscribe<UfoTakeDamageMessage>(UfoTakeDamage);

            Subscribe<AlienShipSpawnMessage>(_activateEnemy.Spawn);

            //Subscribe<SpawnPowerUpMessege>(_powerUpContainer.SpawnPowerUp);

            Subscribe<SendScoreBoardScoreMessege>(_scoreBoard.AddNewScore);

        }

        protected override void Disconnect()
        {
            Unsubscribe<characterTakeDamageMessage>(_playerStatus.CharacterReciveDamage);

            //Unsubscribe<AlienTakeDamageMessage>(AlienTakeDamage);
            Unsubscribe<AlienTakeDamageMessage>(_powerUpContainer.OnAlienShipDie);

            Unsubscribe<AlienTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Unsubscribe<UfoTakeDamageMessage>(_playerStatus.EnemyTakeDamage);
            Unsubscribe<CharacterDieMessege>(_playerStatus.ShowGameOver);

            Unsubscribe<RecivePowerUpMessege>(_character.GetPowerUp);
            //Unsubscribe<UfoTakeDamageMessage>(UfoTakeDamage);

            Unsubscribe<AlienShipSpawnMessage>(_activateEnemy.Spawn);

            //Subscribe<SpawnPowerUpMessege>(_powerUpContainer.SpawnPowerUp);

            Unsubscribe<SendScoreBoardScoreMessege>(_scoreBoard.AddNewScore);

        }


        void AlienTakeDamage(AlienTakeDamageMessage ATD)
        {

        }
        void UfoTakeDamage(UfoTakeDamageMessage UTD)
        {
            Debug.Log("Hilang");
        }
    }
}