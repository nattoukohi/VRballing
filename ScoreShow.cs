using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace balling
{

    public class ScoreShow : MonoBehaviour
    {
        public TurnManager TurnManager;
        public Text scoreLabel;

        // Use this for initialization
        void Start()
        {
            //scoreLabel = GameObject.Find("Text").GetComponent<Text>();

            AddScore();
        }

        // Update is called once per frame
        void Update()
        {
            //scoreLabel.text = score.ToString();
        }

        public void AddScore()
        {
            //Debug.Log(score);
            scoreLabel.text = "Round: " + (TurnManager.round + 1).ToString() + "\n";
            scoreLabel.text += "Turn: " + (TurnManager.turn + 1).ToString() + "\n";
            scoreLabel.text += "TScore: " + TurnManager.TotalScore.ToString();
        }
    }
}

