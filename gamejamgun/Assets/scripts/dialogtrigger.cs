using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogtrigger : MonoBehaviour
{
    public dialog dialog;

    public void triggerdialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
