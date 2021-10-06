using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
namespace Slime
{
    public class pausemenu : MonoBehaviour
    {
        [SerializeField]
        GameObject pauseMenu;
        [SerializeField]
        GameObject debugMenu;
        

        public void Pause()
        {
            pauseMenu.SetActive(true);
            
            Time.timeScale = 0f;
        }
        public void Debug()
        {
            debugMenu.SetActive(true);
            pauseMenu.SetActive(false);
            Time.timeScale = 0f;
            
        }    
        public void Resume()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;

        }


        public void Quit()
        {
            Time.timeScale = 1f;
            FindObjectOfType<AudioManager>().StopPlaying("theme");

            SceneManager.LoadScene(0);
            
        }
            

    }
}
