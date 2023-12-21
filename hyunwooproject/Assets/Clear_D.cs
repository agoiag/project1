using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear_D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Goyang_04_Game");
        }
    }
}


