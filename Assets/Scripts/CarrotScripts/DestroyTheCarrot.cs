using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyTheCarrot : MonoBehaviour
{
    public List<GameObject> carrotList = new List<GameObject>();
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
        if(other.gameObject.name == "knife")
        {
            Debug.Log("HelloWorld");
            foreach(GameObject carrotpart in carrotList) 
            {
                carrotpart.GetComponent<AddRigidbody>().enabled = true;
            }
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            Destroy(GetComponent<XRGrabInteractable>());
            Destroy(GetComponent<Rigidbody>());
            
            gameObject.GetComponent<CrossOutTodoList>().CrossoutWord();
        }
    }
}
