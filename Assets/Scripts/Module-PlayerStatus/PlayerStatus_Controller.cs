using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using SpaceInvader.Messege;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public class PlayerStatus_Controller : ObjectController<PlayerStatus_Controller, PlayerStatus_Model, IPlayerStatus_Model, PlayerStatus_View>
    {

        void ScoreKilledEnemy(int value)
        {
            _model.AddScore(value);
            // Publish<UpdateScoreMessege>(new UpdateScoreMessege(_model.currentScore));
        }
        void ReduceHealth()
        {
            _model.ReduceHealth();
            Publish<UpdateHealthMessege>(new UpdateHealthMessege(_model.playerHealth));

            if (_model.playerHealth <= 0)
            {
                Debug.Log("playerDie");
                // Publish<CharacterDieMessege>(new CharacterDieMessege(_model.playerName, _model.currentScore));
            }
        }

        public override IEnumerator Finalize()
        {
            _model.InitialStatus();
            return base.Finalize();
        }

        public void CharacterReciveDamage(Messege.characterTakeDamageMessage message)
        {
            ReduceHealth();
        }
        public void EnemyTakeDamage(Messege.AlienTakeDamageMessage message)
        {
            ScoreKilledEnemy(10);
        }
        public void EnemyTakeDamage(Messege.UfoTakeDamageMessage messege)
        {
            ScoreKilledEnemy(50);
        }
    }
}
