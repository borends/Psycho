using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void Start()
    {
        Invoke("Winning", 120);
    }

    private void Winning()
    {
        SceneManager.LoadScene(1);
    }
}
