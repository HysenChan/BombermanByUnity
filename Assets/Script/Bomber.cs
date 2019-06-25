using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    GameObject Itemfire;
    private int wallmask;
    private float v = 1.0f;

    bool iswallUp = false;
    bool iswallDown = false;
    bool iswallLeft = false;
    bool iswallRight = false;

    GameObject ItemfireUp;
    GameObject ItemfireDown;
    GameObject ItemfireLeft;
    GameObject ItemfireRight;

    // Start is called before the first frame update
    void Start()
    {
        wallmask = LayerMask.GetMask("Wall");
        StartCoroutine(Bomboo());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Bomboo()
    {
        yield return new WaitForSeconds(1.0f);//炸弹爆炸时间
        Destroy(gameObject);

        Itemfire = Instantiate(Resources.Load("Prefabs/fire"), transform.position, transform.rotation) as GameObject;

        iswallUp = Physics2D.Raycast(transform.position, Vector2.up, v, wallmask);
        iswallDown = Physics2D.Raycast(transform.position, Vector2.down, v, wallmask);
        iswallLeft = Physics2D.Raycast(transform.position, Vector2.left, v, wallmask);
        iswallRight = Physics2D.Raycast(transform.position, Vector2.right, v, wallmask);

        if (!iswallUp)
        {
            ItemfireUp = Instantiate(Resources.Load("Prefabs/fire"), new Vector2(
               transform.position.x, transform.position.y + v), transform.rotation) as GameObject;
        }
        if (!iswallDown)
        {
            ItemfireDown = Instantiate(Resources.Load("Prefabs/fire"), new Vector2(
               transform.position.x, transform.position.y - v), transform.rotation) as GameObject;
        }
        if (!iswallLeft)
        {
            ItemfireLeft = Instantiate(Resources.Load("Prefabs/fire"), new Vector2(
               transform.position.x - v, transform.position.y), transform.rotation) as GameObject;

        }
        if (!iswallRight)
        {
            ItemfireRight = Instantiate(Resources.Load("Prefabs/fire"), new Vector2(
               transform.position.x + v, transform.position.y), transform.rotation) as GameObject;
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Fire")
        {
            Destroy(gameObject);
        }
    }
}
