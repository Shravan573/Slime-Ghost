using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Slime
{


    public class debugmenu : MonoBehaviour
    {
        [SerializeField]
        GameObject pauseMenu;
        [SerializeField]
        GameObject debugMenu;
        public GameObject player;
        //public GameObject[] enemy;


        ////private void Start()
        ////{
        ////    enemy = GameObject.FindGameObjectsWithTag("enemy");
        ////    Debug.Log(enemy.Length);
        ////    foreach (GameObject go in enemy)
        ////    {
        ////        go.SetActive(false);
        ////    }
        ////    //enemy[1].SetActive(true);
        ////}
        //public void increaseEnemy(int number)
        //{
        //    //enemy = GameObject.FindGameObjectsWithTag("enemy");
        //    //int enemynumber = enemy.Length;
        //    //number = number + 1;
        //    //Debug.Log(number);
        //    //foreach (GameObject go in enemy)
        //    //{
        //    //    go.SetActive(false);
        //    //}
        //    //for (int i = 0; i < number; i++)
        //    //{
        //    //    enemy[i].SetActive(true);

        //    //}
        //}
        public void increaseJump(float jump)
        {
            //PlayerController playerObj = new PlayerController();
            //playerObj.playerSpeed = Speed;
            jump = player.GetComponent<PlayerController>().jumpHeight + 1;
            player.GetComponent<PlayerController>().jumpHeight = jump;

        }
        public void decreasesJump(float jump)
        {
            //PlayerController playerObj = new PlayerController();
            //playerObj.playerSpeed = Speed;
            jump = player.GetComponent<PlayerController>().jumpHeight - 1;
            player.GetComponent<PlayerController>().jumpHeight = jump;

        }
        public void increaserotation(float rotate)
        {
            //PlayerController playerObj = new PlayerController();
            //playerObj.playerSpeed = Speed;
            rotate = player.GetComponent<PlayerController>().rotationspeed + 1;
            player.GetComponent<PlayerController>().rotationspeed = rotate;

        }
        public void decreasesrotation(float rotate)
        {
            //PlayerController playerObj = new PlayerController();
            //playerObj.playerSpeed = Speed;
            rotate = player.GetComponent<PlayerController>().rotationspeed - 1;
            player.GetComponent<PlayerController>().rotationspeed = rotate;

        }
        public void increaseSpeed(float Speed)
            {
            //PlayerController playerObj = new PlayerController();
            //playerObj.playerSpeed = Speed;
            Speed =player.GetComponent<PlayerController>().playerSpeed +3 ;
            player.GetComponent<PlayerController>().playerSpeed = Speed;
            
        }
        public void decreasesSpeed(float Speed)
        {
            //PlayerController playerObj = new PlayerController();
            //playerObj.playerSpeed = Speed;
            Speed = player.GetComponent<PlayerController>().playerSpeed - 3;
            player.GetComponent<PlayerController>().playerSpeed = Speed;
        }


        public void Back()
        {
            pauseMenu.SetActive(true);
            debugMenu.SetActive(false);
            Time.timeScale = 1f;

        }
    }
}
