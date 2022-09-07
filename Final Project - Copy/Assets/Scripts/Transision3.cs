using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transision3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("transision", 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void transision()
    {
        SceneManager.LoadScene(6);
    }
}
