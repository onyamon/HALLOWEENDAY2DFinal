using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{

    public string sceneName;
    void OnTriggerEnter2D(Collider2D other) 
    {
        SceneManager.LoadScene("Winner");
    }
}
