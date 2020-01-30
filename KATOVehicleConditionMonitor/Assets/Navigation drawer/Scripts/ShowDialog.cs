using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowDialog : MonoBehaviour
{
    GameObject dialogpanel;
    // Start is called before the first frame update
    void Start()
    {
        dialogpanel = GameObject.Find("DialogPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // ボタンが押されるとDialogを表示させる
    public void Showdialog()
    {
        dialogpanel.SetActive(true);
    }
}
