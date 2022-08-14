using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Messege
{
    public class PubSubMessege
    {

    }

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
}
