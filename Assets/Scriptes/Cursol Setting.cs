using UnityEngine;

public class CursorChange : MonoBehaviour
{
    [SerializeField] private Target target;
    private GameObject obj;
    private ScoreManager scoreManager;

    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();    // SpriteRendererコンポーネントを取得する
        obj = GameObject.Find("UI");
        scoreManager = obj.GetComponent<ScoreManager>();
    }

    void OnMouseOver()
    {
        sr.color = Color.black;   // 的を黒色に変更する処理
    }
    void OnMouseDown() 
    {
        Destroy(this.gameObject);  // 的を消す
        scoreManager.AddScore(target.Score);  // スコアの加算
    }

    void OnMouseExit()
    {
        sr.color = Color.white;  // 的を元に戻す処理
    }
    
}