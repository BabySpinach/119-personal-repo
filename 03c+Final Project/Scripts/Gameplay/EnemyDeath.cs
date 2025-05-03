using Platformer.Core;
using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the health component on an enemy has a hitpoint value of  0.
    /// </summary>
    /// <typeparam name="EnemyDeath"></typeparam>
    public class EnemyDeath : Simulation.Event<EnemyDeath>
    {
        public EnemyController enemy;

        public override void Execute()
        {
            enemy.GetComponent<Animator>().SetTrigger("death");
            enemy.GetComponent<Animator>().SetBool("dead", true);
            enemy._rigidbody.totalForce = Vector2.zero;
            enemy._rigidbody.velocity = Vector2.zero;
            enemy._collider.enabled = false;
            enemy.control.velocity = Vector2.zero;
            //enemy.control.enabled = false;
            if (enemy._audio && enemy.ouch)
                enemy._audio.PlayOneShot(enemy.ouch);

        }
    }
}