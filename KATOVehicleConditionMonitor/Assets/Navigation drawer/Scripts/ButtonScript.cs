using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ButtonScript : MonoBehaviour
{
    GameObject maintenance;
    GameObject home;
    GameObject status;
    GameObject factory;
    GameObject information;
    GameObject inquiry;
    GameObject dialog;



    // Start is called before the first frame update
    void Start()
    {
        maintenance = GameObject.Find("maintenance");
        home = GameObject.Find("home");
        status = GameObject.Find("status");
        factory = GameObject.Find("factory");
        information = GameObject.Find("information");
        inquiry = GameObject.Find("inquiry");
        dialog = GameObject.Find("dialog");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    // ボタンが押されるとhomeオブジェクトを表示させる
    public void OnClick1()
    {
      
        maintenance.SetActive(false);
        home.SetActive(true);
        status.SetActive(false);
        factory.SetActive(false);
        information.SetActive(false);
        inquiry.SetActive(false);
        dialog.SetActive(false);



    }
    // ボタンが押されるとmaintenanceオブジェクトを表示させる
    public void OnClick2()
    {
       
        home.SetActive(false);
        maintenance.SetActive(true);
        status.SetActive(false);
        factory.SetActive(false);
        information.SetActive(false);
        inquiry.SetActive(false);
        dialog.SetActive(false);

    }
    // ボタンが押されるとstatusオブジェクトを表示させる
    public void OnClick3()
    {
      
        home.SetActive(false);
        maintenance.SetActive(false);
        status.SetActive(true);
        factory.SetActive(false);
        information.SetActive(false);
        inquiry.SetActive(false);
        dialog.SetActive(false);

    }
    // ボタンが押されるとfactoryオブジェクトを表示させる
    public void OnClick4()
    {
        
        home.SetActive(false);
        maintenance.SetActive(false);
        status.SetActive(false);
        factory.SetActive(true);
        information.SetActive(false);
        inquiry.SetActive(false);
        dialog.SetActive(false);

    }
    // ボタンが押されるとinformationオブジェクトを表示させる
    public void OnClick5()
    {
        
        home.SetActive(false);
        maintenance.SetActive(false);
        status.SetActive(false);
        factory.SetActive(false);
        information.SetActive(true);
        inquiry.SetActive(false);
        dialog.SetActive(false);

    }
    // ボタンが押されるとinquiryオブジェクトを表示させる
    public void OnClick6()
    {
        
        home.SetActive(false);
        maintenance.SetActive(false);
        status.SetActive(false);
        factory.SetActive(false);
        information.SetActive(false);
        inquiry.SetActive(true);
        dialog.SetActive(false);

    }
    // ボタンが押されるとDialogを表示させる
    public void OnClick7()
    {
        home.SetActive(false);
        maintenance.SetActive(false);
        status.SetActive(false);
        factory.SetActive(false);
        information.SetActive(false);
        dialog.SetActive(true);
    }
    // ボタンが押されるとtoastを表示させる
    public void OnClick8()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
         // 短時間
         NPBinding.UI.ShowToast( "ピカチュウ", eToastMessageLength.SHORT );
#endif
    }

}
