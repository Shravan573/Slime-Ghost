
using UnityEngine;
namespace Slime
{
    public class GameManger : MonoBehaviour
    {
        bool gamehasend = false;
        public GameObject gameoverscreen;
        public void GameOver()
        {

            if(gamehasend== false)
            {
                gamehasend = true;
                Debug.Log("gameover");
                gameoverscreen.SetActive(true);
                Time.timeScale = 0f;
            }
        }

    }
}

