using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resours : MonoBehaviour
{
    [SerializeField] private int _list;
    
    public void AddList(int list)
    {
        _list += list;
    }
}
