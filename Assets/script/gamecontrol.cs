using UnityEngine;
using System.Collections;

public class gamecontrol : MonoBehaviour {
    public GameObject enmey;
    public Transform ep1;
    public Transform ep2;
    public Transform ep3;
    private Vector2 spawn;
    public int ecount = 2;
    public GameObject wingrah;
    public GameObject losegrah;

    public static bool isover = false;

    // Use this for initialization
    void Start () {
        InvokeRepeating("egenerate", 1, 3);
	}
	
	// Update is called once per frame
	void Update () {
        if (isover == true)
        {
            print("over");
            losegrah.GetComponent<SpriteRenderer>().enabled =true;
            losegrah.GetComponent<Animator>().enabled = true;
        }
        else
        {
            print("notover");
        }
	
	}

    void egenerate()
    {
        ecount--;
        if (ecount>0)
        {
            print(ecount);
            selectep();
            GameObject en;
            en = Instantiate(enmey, spawn, Quaternion.identity) as GameObject;
        }
        else
        {
            enmeydect();
        }
    }

    void enmeydect()
    {
        GameObject enm;
        enm = GameObject.FindWithTag("enmey");
        if (enm == null)
        {
            wingrah.GetComponent<SpriteRenderer>().enabled = true;
        }

    }
     void selectep()
    {
        float a = Random.value*33;
        int b = Mathf.RoundToInt(a)%3;
        switch (b)
        {
            case 0:
                spawn = ep1.transform.position;
                break;
            case 1:
                spawn = ep2.transform.position;
                break;
            case 2:
                spawn = ep3.transform.position;
                break;

        }

    }
}
