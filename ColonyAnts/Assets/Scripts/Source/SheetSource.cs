using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetSource : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private int _sheetResours;

    public void AddButton(bool isBoll)
    {
        _button.SetActive(isBoll);
    }
}
