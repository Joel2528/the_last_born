# Architecture Overview

## THE LAST BORN - Engine Architecture

This document describes the software architecture and module interaction for *The Last Born*.

```
                              ┌───────────────────────────┐
                              │       GameManager         │
                              │  (Singleton / State Machine)
                              └─────────────┬─────────────┘
                                            │
         ┌───────────────────┬──────────────┼──────────────┬───────────────────┐
         │                   │              │              │                   │
┌────────▼─────────┐ ┌───────▼──────┐ ┌─────▼──────┐ ┌─────▼──────┐ ┌──────────▼─────────┐
│ PlayerController │ │ CombatSystem │ │ DialogueMgr │ │ QuestSystem│ │ Inventory System │
└────────┬─────────┘ └───────┬──────┘ └─────┬──────┘ └─────┬──────┘ └──────────┬──────────┘
         │                   │              │              │                   │
         └───────────────────┴──────────────┼──────────────┴───────────────────┘
                                            │
                                  ┌─────────▼────────┐
                                  │   SaveManager    │
                                  └──────────────────┘
```

---

## Core Systems & Responsibilities

### 1. GameManager (`GameManager.cs`)
- Central singleton manager handling state transitions (`MainMenu`, `Exploration`, `Dialogue`, `Combat`, `Pause`, `GameOver`).
- Controls scene loading asynchronously and coordinates cross-system events.

### 2. Player Controller (`PlayerController.cs`)
- Handles 3D character movement, jumping, sprinting, slope physics, and camera alignment.
- Interfaces with the Input System and Animation Controller.

### 3. Combat System (`CombatSystem.cs`)
- Manages melee attack combos, stamina consumption, light/heavy attacks, parrying, and hit detection.

### 4. Dialogue System (`DialogueManager.cs`)
- Parses JSON dialogue files.
- Triggers UI dialogue boxes, portraits, audio voice lines, and quest state updates.

### 5. Quest System (`QuestManager.cs`)
- Tracks active, completed, and failed quests.
- Updates objectives upon triggering world events or talking to key NPCs.

### 6. Save System (`SaveManager.cs`)
- Serializes player position, inventory, quest progress, and unlocked codex entries into encrypted JSON.
