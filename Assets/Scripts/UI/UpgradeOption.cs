using UnityEngine;
using UnityEngine.UI;

using TMPro;

namespace User.UI
{
    using Scriptable.Upgrade;
    using Manager.Upgrade;

    public class UpgradeOption : MonoBehaviour
    {
        [Header("REFERENCES")]
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI text;

        private UpgradeType upgradeType;



        private void Awake()
        {
            if (!image) image = GetComponent<Image>();
            if (!text) text = GetComponent<TextMeshProUGUI>();
        }



        public void ApplyUpgrade()
        {
            UpgradeManager.GetUpgradeFromType(upgradeType);
        }

        public void UpdateDisplay(UpgradeData _data)
        {
            image.color = _data.tintColor;
            text.text = _data.upgradeName;
            upgradeType = _data.upgradeType;
        }
    }
}
