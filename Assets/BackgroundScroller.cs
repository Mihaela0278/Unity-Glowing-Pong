using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(-0.5f * Time.deltaTime, 0);

        if(transform.position.x < -16.73)
        {
            transform.position = new Vector3(17.37f, transform.position.y);
        }
    }
}
