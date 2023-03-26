using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheetUIButton : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private GameManager _targetSource;
    [SerializeField] private Button _button;

    public void AddSourceSheet()
    {
        _targetSource.SheetSource = _target;
    }
    


}
