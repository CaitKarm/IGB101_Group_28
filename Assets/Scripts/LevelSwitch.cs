using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public GameManager gameManagerScript;
    public String nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(gameManagerScript.levelComplete)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
