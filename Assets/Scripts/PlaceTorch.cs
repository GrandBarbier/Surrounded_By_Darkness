using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTorch : MonoBehaviour
{
    public bool torchOnGround;
    public GameObject torch;
    public GameObject torchOnGroundPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.E)) && torchOnGround == false)
        {
            Debug.Log("place");
            //place la torche au sol
            torch.transform.position = torchOnGroundPos.transform.position;
            torch.transform.rotation = torchOnGroundPos.transform.rotation;
            //rend la torche indépendante en mettant à jour la variable l'indiquant
            torch.transform.parent = null;
            torchOnGround = true;
        }
    }
}
