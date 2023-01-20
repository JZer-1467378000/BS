using Character;
using UnityEngine;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {
        public PlayerCharacter Character;
        public Transform ExploreSpawnPoint;
        public Transform HomeSpawnPoint;

        public void BeginExplore()
        {
            Character.BeginExplore();
        }

        public void EndExplore()
        {
            Character.EndExplore();
        }

        // Start is called before the first frame update
        private void Awake()
        {
            GameBegin();
        }

        private void GameBegin()
        {
            InitEntities();
            InitCharacter();
        }

        private void InitCharacter()
        {
            var characterPrefab = Resources.Load<GameObject>("Prefab/Character/Body");
            Character = Instantiate(characterPrefab).GetComponent<PlayerCharacter>();
            Character.Init(ExploreSpawnPoint, HomeSpawnPoint);
            Character.BeginExplore();
        }

        private void InitEntities()
        {
        }

        private void SaveFile()
        {
        }
    }
}