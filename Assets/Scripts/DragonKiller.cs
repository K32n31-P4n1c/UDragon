using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 6)
        {
            // Load the scene at index 0
            SceneManager.LoadScene(0);
        }

        if (transform.position.y < -6)
        {
            SceneManager.LoadScene(0);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        SceneManager.LoadScene(0);
    }

}
