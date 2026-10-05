using UnityEngine;
using System.Collections.Generic;

namespace TheLastBorn.Quest
{
    [System.Serializable]
    public class QuestItem
    {
        public string questID;
        public string questTitle;
        [TextArea]
        public string description;
        public bool isCompleted;
    }

    public class QuestManager : MonoBehaviour
    {
        public static QuestManager Instance { get; private set; }

        public List<QuestItem> activeQuests = new List<QuestItem>();

        private void Awake()
        {
            if (Instance != null && Instance != this) Destroy(gameObject);
            else Instance = this;
        }

        public void AddQuest(QuestItem newQuest)
        {
            activeQuests.Add(newQuest);
            Debug.Log($"[Quest] Accepted quest: {newQuest.questTitle}");
        }

        public void CompleteQuest(string questID)
        {
            QuestItem quest = activeQuests.Find(q => q.questID == questID);
            if (quest != null)
            {
                quest.isCompleted = true;
                Debug.Log($"[Quest] Completed quest: {quest.questTitle}");
            }
        }
    }
}
