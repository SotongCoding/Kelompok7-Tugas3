using System.Collections;
using System.Collections.Generic;
using SpaceInvader.PowerUps;
using UnityEngine;

namespace SpaceInvader.Messege
{
    public class PubSubMessege
    {

    }

    #region PlayerStatus Messege
    public struct UpdateHealthMessege
    {
        public int currentHealth { private set; get; }
        public UpdateHealthMessege(int currentHealth)
        {
            this.currentHealth = currentHealth;
        }
    }
    public struct UpdateScoreMessege
    {
        public int currentScore { private set; get; }
        public UpdateScoreMessege(int currentScore)
        {
            this.currentScore = currentScore;
        }
    }
    public struct CharacterDieMessege
    {
        public CharacterDieMessege(string playerName, int lastScore)
        {
            this.playerName = playerName;
            this.lastScore = lastScore;
        }

        public string playerName { private set; get; }
        public int lastScore { private set; get; }

    }
    #endregion

    #region PowerUp Messege
    public struct SpawnPowerUpMessege
    {
        public PowerUps.PowerUps_View powerUpObject;
        public Vector2 spawnPos;

        public SpawnPowerUpMessege(PowerUps_View powerUpObject, Vector2 spawnPos)
        {
            this.powerUpObject = powerUpObject;
            this.spawnPos = spawnPos;
        }
    }
    public struct RecivePowerUpMessege
    {
        public int powerUpId;
        public float powerUpDuration;

        public RecivePowerUpMessege(int powerUpId, float powerUpDuration)
        {
            this.powerUpId = powerUpId;
            this.powerUpDuration = powerUpDuration;
        }
    }
    #endregion

    #region ScoreBoard Messege
    public struct AddNewScoreMessege{
        public string playerName;
        public int currentPlayerScore;

        public AddNewScoreMessege(string playerName, int currentPlayerScore)
        {
            this.playerName = playerName;
            this.currentPlayerScore = currentPlayerScore;
        }
    }
    #endregion

    #region  Audio Messege
    public struct PlayAuidoMessege{
        public string audioName;

        public PlayAuidoMessege(string audioName)
        {
            this.audioName = audioName;
        }
    }
    #endregion
    #region Character
    public struct characterTakeDamageMessage
    {
        
    }
    #endregion
    #region Enemy
    public struct EnemyTakeDamageMessage
    {

    }
    #endregion
    #region AlienShip
    public struct AlienTakeDamageMessage
    {

    }
    #endregion
    #region AlienShip
    public struct UfoTakeDamageMessage
    {

    }
    #endregion
}
