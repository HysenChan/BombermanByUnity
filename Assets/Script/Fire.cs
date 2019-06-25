using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator fire()
    {
        yield return new WaitForSeconds(0.5f);//火焰消失时间0.5s
        Destroy(gameObject);
    }
}
