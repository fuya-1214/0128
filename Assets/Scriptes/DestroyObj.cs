using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    [SerializeField] private Target target;

    void Start()
    {
        Destroy(gameObject, target.DeleteTime);
    }

}
