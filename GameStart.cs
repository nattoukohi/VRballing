using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace balling
{

    public class GameStart : MonoBehaviour
    {
        public GameObject check;
        //if ball go passes through a certain point, start the game
        public bool turnstarted;

        // Use this for initialization
        void Start()
        {
            turnstarted = false;
        }

        // Update is called once per frame
        void Update()
        {
            check = GameObject.FindGameObjectWithTag("Ball");

  

            //if turn is started, no need to check it for a while
            if(check != null&&turnstarted == false)
            {
                if (check.transform.position.x > 10)
                {
                    turnstarted = true;
                }
            }
            
        }
    }


}
