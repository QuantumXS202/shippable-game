using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Text text;
    private int Score = 0;
    public GameObject prefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, new Vector3(0f,70f,0f), Quaternion.identity);
            Score += 1;
            text.text = "Score: " + Score;
        }
           

    }
}
