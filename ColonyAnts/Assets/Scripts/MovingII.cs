using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingII : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _list;
    [SerializeField] private Resours _resoursList;
    public Transform TargetSclad;
    public Transform TargetIstochnic;
    [SerializeField] private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _resoursList = GameObject.Find("GameManager").GetComponent<Resours>();
    }
    private void Update()
    {
        TargetIstochnic = _gameManager.SheetSource;
        TargetSclad = _gameManager.TargetSclad;

        if (TargetIstochnic == null)
        {
            transform.position = transform.position;
            Debug.Log("Источника нет");
        }
        else
        {
            Moving();
            Debug.Log("Источник есть");
        }
            
    }

    private void Moving()
    {
        if (_list == 0)
        {
            MoveTransform(TargetIstochnic);
            if (transform.position == TargetIstochnic.position)
            {
                _list = 1;
                Debug.Log("Забрал лист");
            }
        }
        else
        {
            MoveTransform(TargetSclad);
            if (transform.position == TargetSclad.position)
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
