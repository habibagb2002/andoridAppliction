using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundry : MonoBehaviour
{
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public  float internalLeft;
    public  float internalright;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalright = rightSide;
    }
}
