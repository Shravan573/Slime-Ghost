using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Slime
{

    public class mainmenu : MonoBehaviour
    {
        public GameObject settings;
        public GameObject Mainmenu;

        public void Start()
        {
            
            FindObjectOfType<AudioManager>().Play("main theme");
        }
        public void Play()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void quit()
        {
            Application.Quit();
            Debug.Log("quit");
        }
        public void Setting()
        {
            settings.SetActive(true);
            Mainmenu.SetActive(false);
        }

    }
}
