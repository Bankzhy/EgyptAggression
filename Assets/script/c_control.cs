using UnityEngine;
using System.Collections;

public class c_control : MonoBehaviour {
    private Animator anima;
    public GameObject bullet;
    public Transform raycastpoint;
    public float mytime = 0;
	// Use this for initialization
	void Start () {
        anima = GetComponent<Animator>();

        enemyraycast();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        mytime += 1.0f * Time.deltaTime;
        if (mytime>=3)
        {
            enemyraycast();
            mytime = 0;
        }
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        //{
        //    anima.SetTrigger("attack");
        //    Invoke("Shoot",1.6f);
        //}
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            anima.SetTrigger("die");
        }
	
	}
    void Shoot()
    {
        float cx = 0.5f;
        GameObject newbullet;
        Vector3 pos = this.transform.position;
        Vector3 newpos = new Vector3(pos.x+cx,pos.y,pos.z);
        newbullet = Instantiate(bullet,newpos,Quaternion.identity)as GameObject;
    }
    void enemyraycast()
    {
  
        RaycastHit2D hit = Physics2D.Raycast(raycastpoint.transform.position, Vector2.right, 10.0f, 1);
        if (hit.collider!= null && hit.collider.tag == "enmey")
        {
            print("test");
            anima.SetTrigger("attack");
            Invoke("Shoot", 1.6f);
        }
        else
        {
            print("No");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="enmey")
        {
            print("hit");
            Destroy(this.gameObject, 2.5f);
            
        }
    }
}
