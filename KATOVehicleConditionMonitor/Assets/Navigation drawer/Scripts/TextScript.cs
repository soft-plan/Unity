using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript: MonoBehaviour
{
    Text titlename;
    // Start is called before the first frame update
    void Start()
    {
        this.titlename = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Textchange1()
    {
        this.titlename.text = "ホーム";
    }
    public void Textchange2()
    {
        this.titlename.text = "メンテナンス情報";
    }
    public void Textchange3()
    {
        this.titlename.text = "車両の運行状況";
    }
    public void Textchange4()
    {
        this.titlename.text = "サービス工場一覧";
    }
    public void Textchange5()
    {
        this.titlename.text = "お知らせ";
    }
    public void Textchange6()
    {
        this.titlename.text = "お問い合わせ";
    }
}
