using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    //The PauseMenuButton
    public GameObject ingameMenu;

    public void OnPause()//点击“暂停”时执行此方法
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }

    public void OnResume()//点击“回到游戏”时执行此方法
    {
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
    }

    public void ToMainMenu()//点击“回主菜单”时执行此方法
    {
        //Loading Scene0
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnQuit()//点击“退出游戏”时执行此方法
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
