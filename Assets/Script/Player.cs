using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    GameObject bomb;

    //public static int BombCount = 0;//炸弹数量
    //private int MaxBomb = 1;//最大炸弹数量
    //int LifeCount = 1;//生命条数
    //private int MaxLife = 2;//最大生命值

    public float speed = 3.0f;//角色速度控制

    // Use this for initialiezation
    void Start()
    {
        //角色选择后禁掉其他Player脚本代码
        if (CharacterCreation.selectedIndex == 0)
        {
            GameObject.Find("Player02").GetComponent<Player>().enabled = false;
            GameObject.Find("Player03").GetComponent<Player>().enabled = false;
        }
        if (CharacterCreation.selectedIndex == 1)
        {
            GameObject.Find("Player01").GetComponent<Player>().enabled = false;
            GameObject.Find("Player03").GetComponent<Player>().enabled = false;
        }
        if (CharacterCreation.selectedIndex == 2)
        {
            GameObject.Find("Player01").GetComponent<Player>().enabled = false;
            GameObject.Find("Player02").GetComponent<Player>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //角色按键移动代码
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().MovePosition(transform.position + new Vector3(h, v, 0) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animator>().SetBool("Down", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<Animator>().SetBool("Down", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Animator>().SetBool("Up", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<Animator>().SetBool("Up", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("Left", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("Left", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("Right", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("Right", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {  
            bomb = Instantiate(Resources.Load("Prefabs/bomb"),transform.position, transform.rotation) as GameObject;
        }
    }
}
