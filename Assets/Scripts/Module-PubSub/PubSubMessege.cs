using System.Collections;
using System.Collections.Generic;
using SpaceInvader.PowerUps;
using UnityEngine;
using SpaceInvader.Pooling;
using SpaceInvader.Character;
using System;

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
    #region AlienShipSpawnMessage
    public struct AlienShipSpawnMessage
    {
        public Vector3 rowPos;
        public int column;
        public AlienShip_View enemyPrefabs;
        public System.Action allienKilled;
        public Transform transform;
        public List<GameObject> AS;

        public AlienShipSpawnMessage(Vector3 rowPos, int column, AlienShip_View enemyPrefabs, Action allienKilled, Transform transform, List<GameObject> aS)
        {
            this.rowPos = rowPos;
            this.column = column;
            this.enemyPrefabs = enemyPrefabs;
            this.allienKilled = allienKilled;
            this.transform = transform;
            AS = aS;
        }
    }
    #endregion
}
