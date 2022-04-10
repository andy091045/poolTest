using UnityEngine;
using Beck.Pooling;

public class MonoPool : MonoBehaviour
{
    public int capacity;
    public IPool<GameObject> Pool { get; private set; }
    public GameObject Prototype;
    public enum PoolType { Queue, List };
    public PoolType Pooltype = PoolType.Queue;
    public bool Expandable = true;

    void Awake()
    {
        switch (Pooltype)
        {
            case PoolType.Queue:
                Pool = new QueuePool<GameObject>(() => Instantiate(Prototype), capacity);
                break;
            case PoolType.List:
                Pool = new ListPool<GameObject>(() => Instantiate(Prototype), capacity, g => g.activeInHierarchy, Expandable);
                break;
            default:
                break;
        }
    }
}
