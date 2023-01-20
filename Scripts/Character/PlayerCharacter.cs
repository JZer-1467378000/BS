using Entity;
using PlayerInputs;
using UnityEngine;

namespace Character
{
    public class PlayerCharacter : MonoBehaviour
    {
        public CharacterAttributes Attrs;
        public Transform ExploreSpawnPoint;
        public Transform HomeSpawnPoint;
        public Collider2D m_NowCollider;
        public Rigidbody2D RigidBody;

        public void BeginExplore()
        {
            transform.position = ExploreSpawnPoint.position;
        }

        public void EndExplore()
        {
            transform.position = HomeSpawnPoint.position;
        }

        public void Interact()
        {
            if (m_NowCollider && m_NowCollider.gameObject.TryGetComponent(out EntityBase entity))
            {
                entity.Interact();
            }
        }

        public void Move(Vector2 vec)
        {
            RigidBody.velocity = vec;
        }

        internal void Init(Transform exploreSpawnPoint, Transform homeSpawnPoint)
        {
            ExploreSpawnPoint = exploreSpawnPoint;
            HomeSpawnPoint = homeSpawnPoint;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            m_NowCollider = collision;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            m_NowCollider = null;
        }

        // Start is called before the first frame update
        private void Start()
        {
            if (GameObject.Find("PlayerInput").TryGetComponent(out PlayerInput input))
            {
                input.SetCharacter(this);
            }
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}