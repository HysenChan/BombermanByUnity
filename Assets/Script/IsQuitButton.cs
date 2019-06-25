using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsQuitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    public void OnShow()
    {
        gameObject.SetActive(true);
    }

    public void OnYes()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void OnNo()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
