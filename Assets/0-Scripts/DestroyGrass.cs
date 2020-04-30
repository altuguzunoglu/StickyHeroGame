//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DestroyGrass : MonoBehaviour
//{
//    public GameObject other;
//    public GameObject other1;
//    public GameObject other2;
//    public GameObject other3;
//    public GameObject other4;
//    void Start()
//    {

//    }
//    void Update()
//    {

//    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag == "Coin")
//        {
//            Destroy(GameObject.Find(other.name + "(Clone)"));
//            Destroy(GameObject.Find(other1.name + "(Clone)"));
//            Destroy(GameObject.Find(other2.name + "(Clone)"));
//            Destroy(GameObject.Find(other3.name + "(Clone)"));
//            Destroy(GameObject.Find(other4.name + "(Clone)"));
//        }
//    }
//}
