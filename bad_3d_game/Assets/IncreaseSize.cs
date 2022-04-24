using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotationChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += (scaleChange * Time.deltaTime);
        transform.localPosition += (positionChange * Time.deltaTime);
        transform.Rotate(rotationChange * Time.deltaTime);
    }
}
