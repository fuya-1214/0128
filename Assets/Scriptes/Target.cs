using UnityEngine;

[CreateAssetMenu(fileName = "Target", menuName = "Scriptable Objects/Target")]
public class Target : ScriptableObject
{
    // 的のステータス
    [SerializeField] private int score = 0;  // スコア
    [SerializeField] private GameObject texture;  // 的の見た目
    [SerializeField] private float deleteTime = 3;  // 消えるまでの時間

    public int Score => score;
    public GameObject Texture => texture;
    public float DeleteTime => deleteTime;
}
