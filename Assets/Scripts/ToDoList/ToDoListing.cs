using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using System;

public class ToDoListing : MonoBehaviour
{
    public List<TodoItems> list { get; private set; }
    public List<GameObject> TodoListText { get; private set; }
    public GameObject ListPrefab;
    // Start is called before the first frame update
    void Start()
    {
        list = new List<TodoItems> { new TodoItems("HelloWorld"), new TodoItems("It May Work"), new TodoItems("It Works?"), new TodoItems("<s>It Works<s>") };
        CreateList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateList()
    {
        Vector3 vector = new Vector3(0.6f, 0.1f, 0);
        TodoListText = new List<GameObject>();
        foreach (TodoItems item in list) 
        {
            var newspawn = Instantiate(ListPrefab, vector, Quaternion.identity);
            TodoListText.Add(newspawn);
            newspawn.transform.parent = transform;
            var text = newspawn.GetComponent<TMP_Text>();
            text.text = item.Description;
            var pos = newspawn.GetComponent<RectTransform>();
            pos.localScale = new Vector3(1, 0.2f, 0.15f);
            pos.transform.eulerAngles = new Vector3(0,-90,0);
            pos.transform.localPosition = vector;
            vector.y -= 0.04f;
            Debug.Log(vector);
        }
    }
}

public class TodoItems
{
    public TodoItems(string description)
    {
        Description = description;
        Done = false;
    }

    public string Description { get; set; }
    public bool Done { get; set; }
}
