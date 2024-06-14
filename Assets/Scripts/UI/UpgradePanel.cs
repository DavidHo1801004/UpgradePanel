using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace User.UI
{
    using Manager.General;
    using Manager.Upgrade;

    public class UpgradePanel : MonoBehaviour
    {
        [Header("REFERENCES")]
        [SerializeField] private List<UpgradeOption> upgradeOptions;



        private void OnEnable()
        {
            GameStateManager.OnLevelUp += OnLevelUp;
        }

        private void OnDisable()
        {
            GameStateManager.OnLevelUp -= OnLevelUp;
        }



        private void OnLevelUp()
        {
            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                upgrade.UpdateDisplay(UpgradeManager.GetRandomUpgrade());
            }
        }
    }
}
