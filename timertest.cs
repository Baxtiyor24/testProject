using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timertest : MonoBehaviour
{
   public GameObject[] img;

   void Start(){
    for(int i = 0; i < img.Length; i++)
    {
    img[i].SetActive(false);

    }
  }
}

  //цикл foreach
 //public GameObject[] img;

   //void Start(){
   // foreach(GameObject obj in img){
        //obj.SetActive(false);
    //}
   //}

   //цикл While
 //int timer = 5;

    //void Start()
    //{
    //while(timer > 0){
    // timer--;
//Debug.Log(timer);
//}
//}