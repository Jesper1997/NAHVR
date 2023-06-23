using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatInPan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Meat")
        {
            GetComponent<CrossOutTodoList>().CrossoutWord();
            other.GetComponent<ChangeColor>().enabled = true;
            GetComponent<PlaayCookingSounds>().PlaySound = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Meat")
        {
            other.GetComponent<ChangeColor>().enabled = false;
            other.GetComponent<PlaayCookingSounds>().PlaySound = false;
        }
    }
}
