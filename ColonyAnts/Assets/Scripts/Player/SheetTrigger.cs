using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetTrigger : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sheet"))
        {
            SheetSource button = collision.gameObject.GetComponent<SheetSource>();
            button.AddButton(true);
            Debug.Log("Игрок в листе");
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sheet"))
        {
            SheetSource button = collision.gameObject.GetComponent<SheetSource>();
            button.AddButton(false);
            Debug.Log("Игрок не листе");

        }
    }

}
