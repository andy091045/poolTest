using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFeeder : MonoBehaviour
{
    public MonoPool SourcePool;
    public string Message;

    public GameObject Destination;
    public float InvokeDelay = 1f;
    public float InvokePeriod = .5f;
    public float spawnTime = 1.0f;
    private float _timer;

    void Start()
    {
        InvokeRepeating("Feedobject", InvokeDelay, InvokePeriod);
    }
    void Feedobject()
    {
        Destination.SendMessage(Message, SourcePool.Pool.GetInstance());
    }
}
