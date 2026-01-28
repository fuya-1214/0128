using UnityEngine;

[CreateAssetMenu(fileName = "Target", menuName = "Scriptable Objects/Target")]
public class Target : ScriptableObject
{
    [SerializeField] private int score = 0;
    [SerializeField] private GameObject texture;
    [SerializeField] private float deleteTime = 3;

    public int Score => score;
    public GameObject Texture => texture;
    public float DeleteTime => deleteTime;
}
