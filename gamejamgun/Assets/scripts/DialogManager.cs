using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogManager : MonoBehaviour
{

    public Text namtext;
    public Text dialogtext;
    private Queue<string> senteces;
    void Start()
    {
        senteces = new Queue<string>();
    }
    public void StartDialog(dialog dialog)
    {
        Debug.Log(dialog.name);

        namtext.text = dialog.name;

        senteces.Clear();
        foreach (string sentence in dialog.sentences)
        {
            
            senteces.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
  public void DisplayNextSentence()
    {
        if(senteces.Count == 0)
        {
   
            EndDialog();
            return;

          
        }
        string sentence = senteces.Dequeue();
        dialogtext.text = sentence;

    }

    public void EndDialog()
    {
        Debug.Log("End");
    }
}
