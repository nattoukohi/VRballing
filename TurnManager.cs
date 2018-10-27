using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace balling{
    public class TurnManager : MonoBehaviour
    {
        [SerializeField] CreatePins CreatePin;
        public ScoreShow ScoreShow;
        //round1-10
        public int round=0;
        //turn1-2
        public int turn;
        //score for individual turns?
        public int score;
        //total score
        public int TotalScore;
        private float destorySeconds = 1.0f;

        //score for every round and turn
        private int[,] turnscore = new int[10,2];

        //find pins that are down
        private GameObject [] checkpin;
        //check where the ball is
        private GameObject ballplace;

        // Use this for initialization
        void Start()
        {
            CreatePin.CreateThePins();
            Debug.Log("Round 1 Turn 1");
        }

        // Update is called once per frame
        void Update()
        {
            checkpin = GameObject.FindGameObjectsWithTag("Pin");
            ballplace = GameObject.FindGameObjectWithTag("Ball");

            if (ballplace)
            {
                //if ball falls enough = enough time has passed
                if (ballplace.transform.position.y < -75)
                {
                    //calculate how many pins are down, and delete the pins that are down
                    CalculateScore();
                    Destroy(ballplace);
                }

            }

        }

        //destroy all pins
        public  void DestoryPins()
        {
            foreach (GameObject x in checkpin)
            {
                Destroy(x);

            }
        }

        public void GameEnd()
        {
            Debug.Log("Your Final score was: " + TotalScore);
        }

        //start next round
        public void NextRound()
        {//reset score
            
            
            if (round == 9)
            {
                GameEnd();
            }
            else
            {

            }
            DestoryPins();
            CreatePin.CreateThePins();
            turn = 0;
            round++;
            Debug.Log("Turn: " + (turn+1) + ", Round: " + (round+1));
            ScoreShow.AddScore();
            score = 0;
        }

        //start next turn
        public void NextTurn()
        {//reset score
            
            
            turn = 1;
            ScoreShow.AddScore();
            Debug.Log("Turn: " + (turn + 1) + ", Round: " + (round + 1));
            score = 0;
        }

        //Destroy after end of round
      

        public void CalculateScore()
        {
            //only the pins that are down
            foreach (GameObject x in checkpin)
            {
                if (x.transform.position.y < 0.65)
                {
                    score++;
                    //n秒後に破壊
                    Destroy(x, destorySeconds);

                }
            }

            turnscore[round, turn] = score;
            Debug.Log("Pins you destroyed this turn: "+score);
            

            TotalScore += score;
            Debug.Log("Total score: " + TotalScore);

            ScoreShow.AddScore();

            if (score == 10)
            {
                NextRound();
            }else if (turn == 1)
            {
                NextRound();
            }else if(turn == 0)
            {
                NextTurn();
            }

            
            

             

            
        }
    }
}


