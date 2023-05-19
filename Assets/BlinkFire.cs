using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkFire : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private bool run = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (run == false)
        {
            spriteRenderer.enabled = false;
            run = true;
        } else if (run == true) {
            spriteRenderer.enabled = true;
            run = false;
        }
        
    }
}
