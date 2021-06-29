/*
 * How to use: https://www.patreon.com/posts/how-to-smoothly-53074538
*/
using UnityEngine;

public class ActiveRootMotion : StateMachineBehaviour
{
	public bool resetOnExit = true;

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.applyRootMotion = true;
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.applyRootMotion = false;
		if (resetOnExit) {
			animator.transform.localPosition = Vector3.zero;
			animator.transform.localRotation = Quaternion.identity;
		}
	}
}
