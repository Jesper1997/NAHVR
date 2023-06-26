using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTextScript : MonoBehaviour
{
    public GameObject Todolist;
    private ToDoListing ToDoListing;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        ToDoListing = Todolist.GetComponent<ToDoListing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ToDoListing.list[index].Description.Contains("<s>"))
        {
            //Execution methode
            Debug.Log(ToDoListing.list[index].Description);
        }

    }


}
