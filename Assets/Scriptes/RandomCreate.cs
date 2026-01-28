using UnityEngine;
using System.Collections.Generic;
using System.Timers;

public class RandomCreate : MonoBehaviour
{
    [SerializeField] private List<Target> target;
    [SerializeField] private float delay = 3;
    private float timer = 0f;

    void Update()
    {
        // 一定時間経過ごとに実行
        timer += Time.deltaTime;
        if(timer >= delay)
        {
            // プレハブの位置をランダムで設定
            float x = Random.Range(-8.0f, 8.0f);
            float y = Random.Range(-3.0f, 3.0f);
            Vector3 pos = new Vector3(x, y, 0);

            // プレハブをランダムで選ぶ
            Target randomObj = target[Random.Range(0, target.Count)];

            // プレハブを生成
            Instantiate(randomObj.Texture, pos, Quaternion.identity);

            timer = 0f;  // タイマーをリセット 
        }    
    }
}
