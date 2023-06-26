using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{
    public GameObject Todolist;
    private ToDoListing ToDoListing;
    [SerializeField] private GameObject EndScreenText;
    bool GameIsDone= false;
    [SerializeField] private float Timer = 10f;

    // Start is called before the first frame update
    void Start()
    {
        EndScreenText.SetActive(false);
        ToDoListing = Todolist.GetComponent<ToDoListing>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(IfAllTodoListIsDone());
        if (IfAllTodoListIsDone())
        {
            Debug.Log("Set Text To Active");
            GameIsDone = true;
            EndScreenText.SetActive(true);
        }
        if(GameIsDone)
        {
            Timer = Timer -Time.deltaTime;
            if(Timer < 0) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private bool IfAllTodoListIsDone()
    {
        foreach(TodoItems todo in ToDoListing.list)
        {
            Debug.Log(todo.Description);
            if(!todo.Description.Contains("<s>"))
            {
                return false;
            }
        }
        return true;
    }
}
