using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GraduallyChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GraduallyChangeColor()
    {
        var mat = gameObject.GetComponent<Renderer>().material;
        float tick = 0f;
        while(mat.color != Color.grey)
        {
            tick+= Time.deltaTime * speed;
            mat.color = Color.Lerp(mat.color, Color.grey,tick);
            Debug.Log(mat.color);
            yield return null;
        }
    }
}
