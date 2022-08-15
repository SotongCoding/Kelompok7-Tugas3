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

        protected override void Connect()
        {
            Subscribe<Messege.AddNewScoreMessege>(_scoreBoard.AddNewScore);
            // Subscribe<UpdateScoreMessege>(OnUpdateScore);
            // Subscribe<CharacterDieMessege>(OnCharacterDieMessege);
            Subscribe<characterTakeDamageMessage>(TakeDamage);
            Subscribe<EnemyTakeDamageMessage>(EnemyTakeDamage);
        }

        protected override void Disconnect()
        {
            Unsubscribe<Messege.AddNewScoreMessege>(_scoreBoard.AddNewScore);
            // Unsubscribe<UpdateHealthMessege>(OnUpdateHealth);
            // Unsubscribe<UpdateScoreMessege>(OnUpdateScore);
            // Unsubscribe<CharacterDieMessege>(OnCharacterDieMessege);
            Unsubscribe<characterTakeDamageMessage>(TakeDamage);
            Unsubscribe<EnemyTakeDamageMessage>(EnemyTakeDamage);
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