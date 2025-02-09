using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    //prefab for instantiating apples
    public GameObject applePrefab;
     public GameObject PapplePrefab;

    public float speed = 3f;

    public float leftAndRightEdge = 50f;

    public float changeDirChance = 0.2f;

    public float appleDropDelay = 1f;
     public float pappleMinDropDelay = 3f; 
    public float pappleMaxDropDelay = 6f;

    void Start()
    {
        Invoke( "DropApple", 2f);
        DropPapple();
    }

    void DropApple(){
        GameObject apple = Instantiate<GameObject>(applePrefab);
        applePrefab.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    void DropPapple()
    {
        GameObject papple = Instantiate(PapplePrefab);
        papple.transform.position = transform.position;
        float randomDelay = Random.Range(pappleMinDropDelay, pappleMaxDropDelay);
        Invoke("DropPapple", randomDelay);  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

       if (pos.x < -leftAndRightEdge){
        speed = Mathf.Abs(speed);
       }
       else if (pos.x > leftAndRightEdge){
        speed = -Mathf.Abs(speed);
       }
      // else if(Random.value < changeDirChance)
       //{
       // speed*= -1;
       //}
    }

    void FixedUpdate() {
        if (Random.value < changeDirChance){
            speed *= -1;
        }
    }
}
