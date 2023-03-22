using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingII : MonoBehaviour
{
    [SerializeField] private Transform _targetIstochnic;
    [SerializeField] private Transform _targetSclad;
    [SerializeField] private float _speed;
    [SerializeField] private int _list;
    [SerializeField] private Resours _resoursList;

    private void Start()
    {
        _targetIstochnic = null;
    }
    private void Update()
    {
        if (_targetIstochnic == null)
        {
            transform.position = transform.position;
            Debug.Log("Источника нет");
        }
        else
        {
            Moving();
            Debug.Log("Источника есть");
        }
            
    }

    private void Moving()
    {
        if (_list == 0)
        {
            MoveTransform(_targetIstochnic);
            if (transform.position == _targetIstochnic.position)
            {
                _list = 1;
                Debug.Log("Забрал лист");
            }
        }
        else
        {
            MoveTransform(_targetSclad);
            if (transform.position == _targetSclad.position)
            {
                _resoursList.AddList(_list);
                _list = 0;
                Debug.Log("Принес лист");
            }
        }
    }

    private void MoveTransform(Transform target)
    {
        var direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 10);
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }
}
