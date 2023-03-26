using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _ants; // Лист с муравьями
    [SerializeField] private GameObject _templateAnt; // Шаблон муравьев
    [SerializeField] private Transform _targetAnt; // Место создания новых муравьев
    public Transform TargetSclad; // Склад (Муравейник)
    public Transform SheetSource; // Источник листа

    private void Update()
    {
        
    }

    public void AddAnt()
    {
        GameObject templateAnt = Instantiate(_templateAnt, _targetAnt.position, Quaternion.identity);
        _ants.Add(templateAnt);

        for (int i = 0; i < _ants.Count; i++)
        {
             
        }


    }
}
