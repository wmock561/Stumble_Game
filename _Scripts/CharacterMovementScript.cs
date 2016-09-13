using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour
{
    private float lane;
    public float smooth = 2;

    void Start()
    {
        lane = 2.5f;
     
    }

    void Update()
    {

       
        Vector3 newPosition = transform.position;
        newPosition.x = lane;
        newPosition.y = 0;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (lane > -10f)
            {
                //animator.SetBool("laneChange", true);
				if (lane == 2.5f) {
					lane -= 5f;
				}
				if (lane == -2.5f){
					lane -= 7.5f;
				}

                //Invoke("stopJumping", 0.1f);
               
            }

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            if (lane < 10f)
            {
                //animator.SetBool("laneChange", true);

				if (lane == 2.5f) {
					lane += 7.5f;
				}
				if (lane == -2.5f){
					lane += 5f;
				}
                //Invoke("stopJumping", 0.1f);
            }

        }
    }



    /*void stopJumping()
    {
        animator.SetBool("laneChange", false);

    }*/

  
 
}
