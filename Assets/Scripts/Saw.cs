using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Saw : MonoBehaviour
{
    public Vector3 pos1, pos2;
    public float speed;
    private void Start()
    {
        move();
    }
    void move()
    {
        transform.DOMove(pos1, speed).OnComplete(
            () => transform.DOMove(pos2, speed)
            .OnComplete(() => move()));
    }

    

}
