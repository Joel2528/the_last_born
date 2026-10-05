using UnityEngine;

namespace TheLastBorn.Combat
{
    public class CombatSystem : MonoBehaviour
    {
        [Header("Combat Stats")]
        public float health = 100f;
        public float stamina = 100f;
        public float lightAttackDamage = 15f;
        public float heavyAttackDamage = 35f;

        [Header("Attack Triggers")]
        public Transform attackPoint;
        public float attackRange = 1.5f;
        public LayerMask enemyLayers;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) // Light Attack
            {
                PerformAttack(lightAttackDamage);
            }
            else if (Input.GetMouseButtonDown(1)) // Heavy Attack
            {
                PerformAttack(heavyAttackDamage);
            }
        }

        private void PerformAttack(float damage)
        {
            if (attackPoint == null) return;
            Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider enemy in hitEnemies)
            {
                Debug.Log($"[CombatSystem] Hit enemy: {enemy.name} dealing {damage} damage");
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (attackPoint == null) return;
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
}
