using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Init(Vector3 direction, float speed)
    {
        this._direction = new Vector3(direction.x, direction.y, direction.z);
        _speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }
}
