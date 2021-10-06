using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Slime
{
    public class gameover : MonoBehaviour
    {
        private void Awake()
        {
            FindObjectOfType<AudioManager>().StopPlaying("theme");

        }
       
        public void restart()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
        public void mainmenu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;

        }
    }
}
