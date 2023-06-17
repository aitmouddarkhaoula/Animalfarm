using System;
using OknaaEXTENSIONS.CustomWrappers;
using TMPro;
using UnityEngine;

namespace _Game.Scripts {
    public class ScoreSystem : Singleton<ScoreSystem> {
        public int score;
        public int highScore;

        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI scoreText2;
        public TextMeshProUGUI highScoreText;

        private void Start()
        {
            ResetScore();
        }

        
        public void AddScore(int amount) {
            score += amount;
            if (score > highScore) {
                highScore = score;
                highScoreText.text = "" + highScore;
            }
            
            scoreText.text = "" + score;
            scoreText2.text = "" + score;
        }
        
        public void RemoveScore(int amount) {
            score -= amount;
            if (score < 0) score = 0;
            
            scoreText.text = "" + score ;
            scoreText2.text = "" + score;
        }
        
        public void ResetScore() {
            score = 0;
            highScore = 0;
            scoreText.text = "";
            scoreText2.text = "";
            highScoreText.text = "";
        }
        
        


    }
}