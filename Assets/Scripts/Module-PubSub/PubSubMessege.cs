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

    #region  Score Board
    public struct SendScoreBoardScoreMessege{
        public string playerName;
        public int currentScore;

        public SendScoreBoardScoreMessege(string playerName, int currentScore)
        {
            this.playerName = playerName;
            this.currentScore = currentScore;
        }
    }
    #endregion

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

    #region  Audio Messege
    public struct PlayAuidoMessege
    {
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

    #region AlienShip
    public struct AlienTakeDamageMessage
    {
        public Vector2 destroyPosition;

        public AlienTakeDamageMessage(Vector2 destroyPosition)
        {
            this.destroyPosition = destroyPosition;
        }
    }
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
