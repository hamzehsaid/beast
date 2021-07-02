using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningKhara : MonoBehaviour
{

    public GameObject Khara;
    public Transform SarefSo7ii;

    public float KharaTime;


    public Vector3 minPos, MaxPos;
    public float maxAngle, minAngle;


    public float MoveSpeed;
    public float AngleSpeed;


    
    private Vector3 positionOrigin;
    private float _timePassed;

    // Start is called before the first frame update
    void Start()
    {

        float randomDistance = Random.Range(-50f, 50f);
       
        positionOrigin = transform.position;

        Instantiate(Khara,transform.position,transform.rotation, SarefSo7ii);
        StartCoroutine(InstantiateStar());

       
    }

    
    void Update()
    {

        //Vector3 moveInto = Vector3.Lerp(minPos, MaxPos, MoveSpeed * Time.deltaTime);
       
        //float angle = Mathf.LerpAngle(minAngle, maxAngle, AngleSpeed * Time.deltaTime);
       // transform.eulerAngles = new Vector3(0, 0, angle);

        _timePassed += Time.deltaTime;
        transform.position = Vector3.Lerp(positionOrigin, positionOrigin + MaxPos,Mathf.PingPong(_timePassed, 1));

    }


    IEnumerator InstantiateStar()
    {
        float time = 0;

        while(time < KharaTime)
        {
            time += Time.deltaTime * 5;
            yield return null;
        }

       // float simplePos = Random.Range(0, 10);

       // Vector2 InitPos =  new Vector2(0, transform.localPosition.y + simplePos);

        Instantiate(Khara, transform.position, transform.rotation, SarefSo7ii);
        yield return StartCoroutine(InstantiateStar());
      
    }

}
