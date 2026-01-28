using UnityEngine;
using UnityEngine.UIElements;

public class TimerManager : MonoBehaviour
{
    private  UIDocument uIDocument => GetComponent<UIDocument>();
    private float timer = 30f;
    
    void Update()
    {
        timer -= Time.deltaTime;
        var root = uIDocument.rootVisualElement;

        var label = root.Q<Label>("Timer");
        label.text = "00" + ":" + timer.ToString("00"); 

        if(timer < 0)
        {
            timer = 0;
            GameObject gManger = GameObject.Find("GameManager");
            Destroy(gManger);
        }
    }

}
