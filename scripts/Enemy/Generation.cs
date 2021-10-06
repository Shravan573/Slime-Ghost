using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public GameObject[] objects;


    public void Start()
    {
        asteriod();
        
    }
    void asteriod()
    {
        int random = Random.Range(0, objects.Length);
        Instantiate(objects[random], transform.position, Quaternion.identity);
        StartCoroutine(waitforasteriod());
    }

    IEnumerator waitforasteriod()
    {
        yield return new WaitForSeconds(1f);
        asteriod();
    }

}
