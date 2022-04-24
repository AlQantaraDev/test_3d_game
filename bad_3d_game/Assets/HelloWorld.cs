using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelloWorld : MonoBehaviour
{
    // int framecount = 0;
    public string testMessage;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(testMessage);
        // Debug.Log("Frame: "+ framecount);
        // framecount = framecount+1;
    }
}
