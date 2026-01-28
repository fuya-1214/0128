using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;

public class CountDown : MonoBehaviour
{
    private  UIDocument uIDocument => GetComponent<UIDocument>();
    private float count = 3f;
    private GameObject gMana;
    private GameObject u;

    void Start()
    {
        gMana = GameObject.Find("GameManager");
        u = GameObject.Find("UI");
    }
    
    void Update()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        var root = uIDocument.rootVisualElement;

        var label = root.Q<Label>("TimeText");

        var gameManager = gMana.GetComponent<RandomCreate>();
        var ui = u.GetComponent<TimerManager>();

        if(count > 1)
        {
            count -= Time.deltaTime;  // カウント下げる
            label.text = count.ToString("F0");
        }
        else if(count == 0)
        {
            label.text = "State"; // 0になる代わりにStateを表示
        }
        else
        {
            yield return new WaitForSeconds(1); //start後1フレームおいてゲームスタート
            label.text = "";   // 何も表示しなくする
            gameManager.enabled = true; 
            ui.enabled = true;
            Destroy(this.gameObject); // 役目を終えたので消す
        }
    }

}
