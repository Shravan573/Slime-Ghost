using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Slime
{
    public class Food : MonoBehaviour
    {

        private void Update()
        {
            transform.Rotate(0, 90 * Time.deltaTime, 0);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "player")
            {
                other.GetComponent<PlayerController>().points++;
                FindObjectOfType<AudioManager>().Play("Eat");
                Destroy(gameObject);
                
            }
        }
    }
}
