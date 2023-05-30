using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{//カウント用の変数を用意
  public int count=0;
  public int use=0;
  public int tmp=0;
  //変数を1増やす関数を作成
  public Text countText;
  public Text UseText;
  public void PushButton(){
    count++;
    //増えた数字をテキストで表示
    if(count > 10){
      count=10;
    }
    countText.text="MAX PP :"+ count;
  }
  public void MaxReset(){
    count++;
    if(count >10){
      count = 10;
    }
    UseText.text = "PP :"+count;
    countText.text = "MAX PP :"+ count;
    use =0;
    tmp = count;
  }
  //テキストを表示

public void USEPPBotton(){

  if(use == 0){
  tmp = count;
  use++;
}
  tmp = tmp - 1;
  if(tmp < 0){
    tmp=0;
  }
  UseText.text="PP :"+tmp;
}
 public void curePPBotton(){
   tmp++;
   if(tmp >count){
     tmp=count;
   }
   UseText.text="PP :"+tmp;
 }
 public void AllReset(){
   count = 0;
   use = 0;
   tmp=0;
   countText.text="MAX PP :"+count;
   UseText.text="PP :"+count;
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
