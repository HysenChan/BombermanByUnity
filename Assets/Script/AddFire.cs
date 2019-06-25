using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFire : MonoBehaviour
{
    public static float fire;
    // Start is called before the first frame update
    void Start()
    {
        fire = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            fire++;
            Destroy(this.gameObject, 0.5f);
            return;
        }
    }
}
