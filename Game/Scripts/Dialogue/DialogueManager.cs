using UnityEngine;
using System.Collections.Generic;

namespace TheLastBorn.Dialogue
{
    [System.Serializable]
    public class DialogueNode
    {
        public string speakerName;
        [TextArea(3, 5)]
        public string sentence;
        public string audioClipName;
    }

    public class DialogueManager : MonoBehaviour
    {
        public static DialogueManager Instance { get; private me; set; }

        private Queue<DialogueNode> dialogueQueue = new Queue<DialogueNode>();

        private void Awake()
        {
            if (Instance != null && Instance != this) Destroy(gameObject);
            else Instance = this;
        }

        public void StartDialogue(List<DialogueNode> dialogueNodes)
        {
            dialogueQueue.Clear();
            foreach (var node in dialogueNodes)
            {
                dialogueQueue.Enqueue(node);
            }
            DisplayNextSentence();
        }

        public void DisplayNextSentence()
        {
            if (dialogueQueue.Count == 0)
            {
                EndDialogue();
                return;
            }

            DialogueNode node = dialogueQueue.Dequeue();
            Debug.Log($"[Dialogue] {node.speakerName}: {node.sentence}");
        }

        public void EndDialogue()
        {
            Debug.Log("[Dialogue] Conversation Ended.");
        }
    }
}
