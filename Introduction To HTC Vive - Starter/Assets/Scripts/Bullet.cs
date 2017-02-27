using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Vector3 target;
    public int bulletSpeed;
    public void setTarget(Vector3 target)
    {
        this.target = target;
        transform.LookAt(target);
        GameObject.Destroy(this.gameObject, 2);
    }
    public void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * bulletSpeed;
    }
}
