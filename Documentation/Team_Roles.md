# Team Roles & Contribution Guidelines

## Team Astute - SIH 2026

To maintain a clean, conflict-free repository and ensure every member builds a verifiable GitHub contribution record, team responsibilities are defined below.

---

### Team Members & Module Ownership

| Member | Title | Primary Modules Owned | Branch Naming Prefix |
| :--- | :--- | :--- | :--- |
| **Joel** | Lead Developer & Integrator | `GameManager`, Core Engine Architecture, Build Pipeline, PR Reviews | `feature/integration` |
| **Elavarasan** | Gameplay Programmer | `PlayerController`, `CombatSystem`, Camera Controllers, Input | `feature/player`, `feature/combat` |
| **Nithish** | 3D Environment Developer | 3D Assets, Poompuhar City, Kumari Kandam, Shaders, Lighting | `environment/*`, `art/*` |
| **Sathish** | Systems & AI Programmer | `EnemyAI`, `Pathfinding`, `SaveManager`, `InventorySystem` | `feature/ai`, `feature/inventory` |
| **Vinothini** | Game Designer & Narrative | `DialogueSystem`, `QuestManager`, Story Docs, Lore, Scripting | `feature/dialogue`, `feature/quest` |
| **Priyanka** | UI/UX Artist & Docs Lead | Canvas UI, HUD, Icons, Documentation, SIH Presentation | `ui/*`, `docs/*` |

---

### Workflow Protocols

1. **Never Commit Directly to `main` or `develop`**
   - All development happens in designated `feature/`, `environment/`, `art/`, or `ui/` branches.
2. **Pull Requests Required**
   - Create a Pull Request (PR) from your feature branch to `develop`.
   - Require code/asset check before merging to `develop`.
3. **Commit Naming Standard**
   - `feat:` for new gameplay code or systems
   - `art:` for 3D assets, textures, animations
   - `fix:` for bug fixes and patches
   - `docs:` for markdown documentation updates
   - `research:` for historical research entries
4. **Git LFS (Large File Storage)**
   - All 3D `.fbx`, `.obj`, `.blend`, `.png` textures, and `.wav` audio files must be tracked via Git LFS to prevent repository bloat.
