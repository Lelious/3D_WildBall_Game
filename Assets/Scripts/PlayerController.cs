using UnityEngine;
namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip playerDeathSound;
        [SerializeField] private ParticleSystem playerDeathParticle;
        [SerializeField] private float speed = 2.0f;

        private Rigidbody playerRigidbody;
        private Vector3 movement;

        private void Awake()
        {
             playerRigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS); //for PC build

            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            movement = new Vector3(vertical, 0, -horizontal).normalized;

            //Vector3 acceleration = Input.acceleration;                                             //for Android Build
            //movement = new Vector3(acceleration.y, 0, -acceleration.x).normalized;
        }
        private void FixedUpdate()
        {
            MoveCharacter();
        }
        private void MoveCharacter()
        {
             playerRigidbody.AddForce(movement * speed);
        }
        private void DeathSong()
        {
            audioSource.PlayOneShot(playerDeathSound);
        }
        private void DeathParticle()
        {
            playerDeathParticle.Play();
        }
    }
}
