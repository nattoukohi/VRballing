using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace balling{
    public class TurnManager : MonoBehaviour
    {
        [SerializeField] CreatePins CreatePin;
        //round1-10
        public int round=0;
        //turn1-2
        public int turn;
        //score for individual turns?
        public int score;
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
        }

        // Update is called once per frame
        void Update()
        {
            checkpin = GameObject.FindGameObjectsWithTag("Pin");
            ballplace = GameObject.FindGameObjectWithTag("Ball");

            if (ballplace)
            {
                if (ballplace.transform.position.y < -100)
                {
                    CalculateScore();
                    Destroy(ballplace);
                }

            }

        }

        public  void DestoryPins()
        {
            foreach (GameObject x in checkpin)
            {
                Destroy(x);

            }
        }

        //start next round
        public void NextRound()
        {
            DestoryPins();
            CreatePin.CreateThePins();
            turn = 0;
            round++;
            Debug.Log(turn + "," + round);
        }

        //start next turn
        public void NextTurn()
        {
            turn = 1;
            Debug.Log(turn + "," + round);
        }

        //Destroy after end of round
        

        public void CalculateScore()
        {
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
            Debug.Log(score);

            if (turn == 1)
            {
                NextRound();
            }

                if (score == 10)
            {
                NextRound();
            }
            else
            {
                NextTurn();
            }

            
        }
    }
}


