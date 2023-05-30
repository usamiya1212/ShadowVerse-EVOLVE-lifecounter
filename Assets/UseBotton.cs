using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UseBotton : MonoBehaviour
{
  private int use=0;
//変数を1増やす関数を作成
public Text USEPP;
public void PushUse(){
  use++;
  //増えた数字をテキストで表示
  USEPP.text="PP:"+use;
}
public void UseReset(){
  use = 0;
  USEPP.text = "PP:"+use;
}
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
