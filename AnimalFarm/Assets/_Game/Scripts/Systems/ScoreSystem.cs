using System;
using OknaaEXTENSIONS.CustomWrappers;
using TMPro;
using UnityEngine;

namespace _Game.Scripts {
    public class ScoreSystem : Singleton<ScoreSystem> {

        public TextMeshProUGUI scoreText;
        public static Action OnScoreChanged;

        private void Start()
        {
            ResetScore();
        }

        public int score;
        
        public void AddScore(int amount) {
            score += amount;
            OnScoreChanged?.Invoke();
            scoreText.text = "" + score;
        }
        
        public void RemoveScore(int amount) {
            score -= amount;
            OnScoreChanged?.Invoke();
            scoreText.text = "" + score;
        }
        
        public void ResetScore() {
            score = 0;
            OnScoreChanged?.Invoke();
            scoreText.text = "" + score;
        }
        
        


    }
}