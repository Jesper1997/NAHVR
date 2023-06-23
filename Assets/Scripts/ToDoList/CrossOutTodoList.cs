using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossOutTodoList : MonoBehaviour
{
    public bool TaskDone = false;
    public GameObject TodoList;
    public int IndexTodoItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TaskDone)
        {
            CrossoutWord();
        }
    }

    public void CrossoutWord()
    {
        var script = TodoList.GetComponent<ToDoListing>();
        script.CrossOutTodoItems(IndexTodoItem);
        Debug.Log("CrossOutWord");
    }
}
