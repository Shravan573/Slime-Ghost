using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Slime
{

    public class PlayerController : MonoBehaviour
    {

        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool groundedPlayer;
        [SerializeField]
        public  float playerSpeed = 2.0f;
        [SerializeField]
        public float jumpHeight = 1.0f;
        [SerializeField]
        private float gravityValue = -9.81f;
        [SerializeField]
        public float rotationspeed = 4f;
        [SerializeField]
        private Player playerinput;
        private Transform cameraMain;
        private Transform child;
        public int points = 0;
        public GameObject door;
        public GameObject exit;
        public int health = 100;
        public int damage = 20;
        



        private void Awake()
        {
            playerinput = new Player();
            controller = GetComponent<CharacterController>();
            door = GameObject.Find("door");
            exit = GameObject.Find("exit");
        }

        private void OnEnable()
        {
            playerinput.Enable();
        }

        private void OnDisable()
        {
            playerinput.Disable();
        }

        private void OnTriggerEnter(Collider other)
        {
           if(other.gameObject.tag=="enemy")
            {
                health -=damage;
                FindObjectOfType<AudioManager>().Play("hurt");
            }
           if(other.gameObject.tag=="rock")
            {
                health -= damage;
                FindObjectOfType<AudioManager>().Play("hurt");
                
            }
        }

        


        public void  Speed()
        {
            playerSpeed = playerSpeed + 5;

        }
        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
            GUI.Label(new Rect(10, 20, 100, 20), "Health : " + health);
        }


        private void Start()
        {
            
            cameraMain = Camera.main.transform;
            child = transform.GetChild(0).transform;
        }
      

        void Update()
        {
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }

            Vector2 movementinput = playerinput.PlayerMain.move.ReadValue<Vector2>();
            Vector3 move = (cameraMain.forward * movementinput.y + cameraMain.right * movementinput.x);
            controller.Move(move * Time.deltaTime * playerSpeed);



            // Changes the height position of the player..
            if (playerinput.PlayerMain.jump.triggered && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }

            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);

            if (movementinput != Vector2.zero)
            {
                Quaternion rotation = Quaternion.Euler(new Vector3(child.localEulerAngles.x, cameraMain.localEulerAngles.y, child.localEulerAngles.z));
                child.rotation = Quaternion.Lerp(child.rotation, rotation, Time.deltaTime * rotationspeed);
            }
            if(points>=10)
            {
                door.SetActive(false);
            }
            else
            {
                door.SetActive(true);
            }
            if(points>=15)
            {
                exit.SetActive(true);

            }else
            {
                exit.SetActive(false);
            }

            if(health<=0)
            {
                FindObjectOfType<AudioManager>().Play("death");
                FindObjectOfType<GameManger>().GameOver();
                FindObjectOfType<AudioManager>().Play("gameover");
                Destroy(gameObject);
            }
          

        }
          
    }
}
