using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Slime
{
    public class gamecomplete : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<GameManger>().GameOver();
            FindObjectOfType<AudioManager>().Play("gameover");
           
        }
    }
}
