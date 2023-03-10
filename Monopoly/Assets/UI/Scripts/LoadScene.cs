using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string name;
    // Use this for initialization
    void Start () {}
    
    void Awake()
    {
        Button button = gameObject.GetComponent<Button>();//获取Button
        button.onClick.AddListener(btClick);//添加监听器用于监听按键事件，并回调函数
    }
    // Update is called once per frame
    void Update () {}
    
    void btClick()
    {
        print("Button Click");
        SceneManager.LoadScene(name);//跳转到指定的Level，也就是第一步中的右侧标号
    }
}

