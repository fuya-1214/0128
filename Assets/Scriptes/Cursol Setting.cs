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
        //Cursor.SetCursor(loupeCursor, Vector2.zero, CursorMode.Auto);
        sr.color = Color.black;   // 赤色に変更する処理
    }
    void OnMouseDown() 
    {
        Destroy(this.gameObject);
        scoreManager.AddScore(target.Score);
    }

    void OnMouseExit()
    {
        // nullにするとデフォルトのテクスチャに戻る
        //Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
        sr.color = Color.white;
    }
    
}