using System.Collections.Generic;
using UnityEngine;

namespace User.Manager.Upgrade
{
    using Scriptable.Upgrade;

    public enum UpgradeType
    {
        None,
        Health,
        Damage,
        Speed
    }

    public class UpgradeManager : MonoBehaviour
    {
        public static UpgradeManager Instance { get; private set; }

        [SerializeField] private List<UpgradeData> availableUpgrades = new();

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        public static UpgradeData GetRandomUpgrade()
        {
            return Instance.availableUpgrades[Random.Range(0, Instance.availableUpgrades.Count)];
        }

        public static void GetUpgradeFromType(UpgradeType _type)
        {
            switch (_type)
            {
                case UpgradeType.Health:
                    UpgradeHealth();
                    break;
                case UpgradeType.Damage:
                    UpgradeDamage();
                    break;
                case UpgradeType.Speed:
                    UpgradeSpeed(); 
                    break;
            }
        }

        public static void UpgradeHealth()
        {
            Debug.Log("Upgrade Health");
        }

        public static void UpgradeDamage()
        {
            Debug.Log("Upgrade Damage");
        }

        public static void UpgradeSpeed()
        {
            Debug.Log("Upgrade Speed");
        }
    }
}
