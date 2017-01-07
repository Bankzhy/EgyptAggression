using UnityEngine;
using System.Collections;

public class water_control : MonoBehaviour {
    private Animator animat;
    // Use this for initialization
    void Start () {
        animat=GetComponent<Animator>();
        GetComponent<Rigidbody2D>().AddForce(Vector2.right*80);
        Destroy(this.gameObject,3);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="enmey")
        {
            print("hit");
            animat.SetTrigger("touch");
            Destroy(this.gameObject,0.3f);
        }
    }
}
