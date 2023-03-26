using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resours : MonoBehaviour
{
    [SerializeField] private int _list; // Лист
    
    public void AddList(int list)
    {
        _list += list;
    }
}
