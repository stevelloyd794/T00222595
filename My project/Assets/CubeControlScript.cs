using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{

     public GameObject snowballCloneTemplate
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown) (KeyCode.W)
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, 90) * Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            GameObject newGO = Instatiate(snowballCloneTemplate);

            snowballControlScript mySnowball = newGO.GetComponent<snowballControlScript>();

            mySnowball.ImThrowingYou(CubeControl CubeControl)
        }
    
    }
    }
}
