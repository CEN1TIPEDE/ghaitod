using System.IO.Pipes;
using UnityEditor.Search;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          //Debug.Log("Hello world"); //unity: mostly used for debug check in game
          //print("Hello world");     //standard C#: work as same as Debug.log

        //String + String name
        Debug.Log("This game obj is : " + gameObject.name);
        Debug.Log("This game position is :" + transform.position);
        Debug.Log("This game rotation is : " + transform.eulerAngles); //dont use rotation because in game there is no limit in angle ,like 260 degree or so
        Debug.Log("This game scale is: " + transform.localScale);
          //string MyFreind = "seal";
          //Debug.Log(MyFreind);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
