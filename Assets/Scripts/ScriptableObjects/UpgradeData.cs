using UnityEngine;

namespace User.Scriptable.Upgrade
{
    using Manager.Upgrade;

    [CreateAssetMenu(fileName = "New Upgrade Data", menuName = "User Data/Upgrade Data")]
    public class UpgradeData : ScriptableObject
    {
        public UpgradeType upgradeType;
        public Color tintColor;
        public string upgradeName;
        public Sprite upgradeImage;
    }
}
