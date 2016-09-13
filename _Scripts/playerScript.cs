using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class playerScript : MonoBehaviour {

	public float speed;


	public AudioSource gameMusic;
	public AudioSource hitMusic;
	public AudioSource bottleMusic;

	private float score;

	public Text scoreText;

	private int endNum;

	public Text endText;

	public Canvas quitMenu;

	public GameObject particleSys;

	private Vector3 direction;

	private Vector3 newPosition;

	private Vector2 touchOrigin = -Vector2.one;

	private float lane;

	private float amountMove;

	public float smooth = 2;

	private int horizontal = 0;

	void Start(){
		direction = Vector3.forward;

		lane = 2.5f;

		score = 0;
		setScoreText ();
		endText.text = "";

		endNum = Random.Range (0, 2);

		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;
	}
		

	void FixedUpdate(){
	
		amountMove = (speed * Time.deltaTime);

		transform.Translate (direction * amountMove);
			
		if(speed != 0){

			score += (1 * Time.deltaTime);
			setScoreText ();
		}

		#if UNITY_STANDALONE || UNITY_STANDALONE_OSX

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{

			if (lane > -11f)
			{
				//animator.SetBool("laneChange", true);
				if (lane == 2.5f) {
					lane = -2.5f;
				}else if (lane == -2.5f){
					lane = -10f;
				}else if (lane == 10f) {
					lane = 2.5f;
				}

				//Invoke("stopJumping", 0.1f);

			}

		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{

			if (lane < 11f)
			{
				//animator.SetBool("laneChange", true);

				if (lane == 2.5f) {
					lane = 10f;
				}else if (lane == -2.5f){
					lane = 2.5f;
				}else if (lane == -10f) {
					lane = -2.5f;
				}
				//Invoke("stopJumping", 0.1f);
			}

		}

		#else

		if (Input.touchCount > 0)
		{
			Touch myTouch = Input.touches[0];

			if( myTouch.phase == TouchPhase.Began){

				touchOrigin = myTouch.position;
			}else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0){

				Vector2 touchEnd = myTouch.position;
				float x = touchEnd.x;

				Debug.Log(touchEnd.x);

				touchOrigin.x = -1;
				if(x > 350){

					horizontal = 1;

				}else if (x < 350){

					horizontal = -1;

				}

			}
		}
		
		#endif

		if(horizontal == -1)
		{
			if (lane > -11f)
			{
				//animator.SetBool("laneChange", true);
				if (lane == 2.5f) {
					lane = -2.5f;
				}else if (lane == -2.5f){
					lane = -10f;
				}else if (lane == 10f) {
					lane = 2.5f;
				}

			}

		}
		if (horizontal == 1)
		{

			if (lane < 11f)
			{
				//animator.SetBool("laneChange", true);

				if (lane == 2.5f) {
					lane = 10f;
				}else if (lane == -2.5f){
					lane = 2.5f;
				}else if (lane == -10f) {
					lane = -2.5f;
				}
			}

		}

		newPosition = transform.position;
		newPosition.x = lane;
		newPosition.y = 0;
		transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);
	
	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "Bottle") {
		
			other.gameObject.SetActive (false);
			Instantiate (particleSys, transform.position, Quaternion.identity);

			score += 100;

			bottleMusic.Play ();

		
		} else if (other.tag == "Obs") {

			speed = 0;

			setScoreText ();

			gameMusic.Stop();

			hitMusic.Play ();




		}


	}

	void setScoreText(){

		scoreText.text = "Score: " + score.ToString ();

		string[] endTextArray = {"Should’ve called STRIPES!", "Drinking isn’t cool, it makes you act like a fool!", "To stay out of the slammer, don’t get hammered!"};

		if (speed == 0) {
			endText.text = "Game Over!";

			quitMenu.enabled = true;

			endText.text = endTextArray [endNum];


		}
	}
		
}
