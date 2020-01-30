using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadFrag : MonoBehaviour
{
    GameObject[] Read_Frag; //代入用のゲームオブジェクト配列を用意

    void Start()
    {
        Read_Frag = GameObject.FindGameObjectsWithTag("Read_Frag");


        for (int i = 0; i < Read_Frag.Length; i++)
        {

           
            if (i == 1)
            {
                Read_Frag[i].SetActive(false);
            }
            else
            {
                Read_Frag[i].SetActive(true);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
