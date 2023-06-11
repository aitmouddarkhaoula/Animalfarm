using System;
using OknaaEXTENSIONS.CustomWrappers;
using UnityEngine;

namespace _Game.Scripts {
    public class ScoreSystem : Singleton<ScoreSystem> {
        
        
        public static Action OnScoreChanged;



        public int score;
        
        public void AddScore(int amount) {
            score += amount;
            OnScoreChanged?.Invoke();
        }
        
        public void RemoveScore(int amount) {
            score -= amount;
            OnScoreChanged?.Invoke();
        }
        
        public void ResetScore() {
            score = 0;
            OnScoreChanged?.Invoke();
        }
        
        


    }
}