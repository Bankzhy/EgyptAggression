using UnityEngine;
using System.Collections;

public class playeraset : MonoBehaviour {
    public GameObject setplayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider!=null&&hit.collider.tag == "aspoint"&&hit.collider.tag!="character")
        {
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                GameObject player;
                player = Instantiate(setplayer, hit.collider.transform.position, Quaternion.identity) as GameObject;

            }
        }
	}
}
