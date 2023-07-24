using System;
using DG.Tweening;
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
            PlayerPrefs.SetInt("score",score);
            if (score > highScore) {
                highScore = score;
                PlayerPrefs.SetInt("highScore",highScore);
                highScoreText.text = "" + highScore;
            }
            
            scoreText.text = "" + score;
            scoreText2.text = "Your Score: " + score;
            scoreText.transform.DOScale(1.5f, 0.1f).OnComplete(() => {
                scoreText.transform.DOScale(1f, 0.1f);
            });
        }
        
        public void RemoveScore(int amount) {
            score -= amount;
            PlayerPrefs.SetInt("score",score);
            if (score < 0) score = 0;
            
            scoreText.text = "" + score ;
            scoreText2.text = "Your Score: " + score;
        }
        
        public void ResetScore() {
            score = PlayerPrefs.GetInt("score", 0);
            highScore =PlayerPrefs.GetInt("highScore", 0);
            scoreText.text = score+"";
            highScoreText.text = highScore+"";
            scoreText2.text = "Your Score: "+score;
        }
        
        


    }
}