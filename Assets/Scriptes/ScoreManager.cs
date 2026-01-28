using UnityEngine;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    private  UIDocument uIDocument => GetComponent<UIDocument>();
    private int score = 0;
    
    void Update()
    {
        var root = uIDocument.rootVisualElement;

        var label = root.Q<Label>("Score");
        label.text = "Score:" + score; 
    }

    public void AddScore(int point)
    {
        score += point;
    }
}
