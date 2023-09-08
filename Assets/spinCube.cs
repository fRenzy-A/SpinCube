using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinCube : MonoBehaviour
{
    public Transform dacube;
    public Vector2 rotate; // = new Vector2(0,1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dacube.transform.Rotate(rotate * Time.deltaTime);
    }
}
