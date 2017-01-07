using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    private Animator anima;
    public int HP=30;

	// Use this for initialization
	void Start () {
        anima=GetComponent<Animator>();
        move();

	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <= -5.2f)
        {
            print("sd");
            gamecontrol.isover =true;
        }
        {

        }
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "water")
        {
            this.HP--;
            if (HP <= 0)
            {
                Destroy(this.gameObject, 1);
                anima.SetTrigger("die");
            }
        }

        if(other.tag== "character")
        {
            stop();
            anima.SetTrigger("attack");
            move();
            
        }
    }
    public void move()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * -8);
    }
    void stop()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 8);
    }
}
