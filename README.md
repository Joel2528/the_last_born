# THE LAST BORN

### A 3D Historical-Fantasy Adventure Game

The Last Born is a 3D adventure game inspired by South Indian history, ancient literature, culture, and the legend of submerged ancient civilizations.

---

## SIH

**Smart India Hackathon 2026**

- **Problem Statement ID**: SIH2026-GAME-001
- **Theme**: Toys & Games / Cultural Heritage Preservation
- **Category**: Software
- **Team**: Team Astute

---

## Game Concept

The player explores an ancient world, discovers lost civilizations, interacts with historical characters, solves environmental challenges, and uncovers the mystery behind a forgotten submerged civilization.

Driven by rich research from Tamil Sangam literature (*Silappathikaram*, *Manimekalai*) and geographical studies of ancient coastal port cities (*Poompuhar* and *Kumari Kandam*), the game bridges authentic cultural heritage with modern interactive 3D gameplay.

---

## Core Features

- **3D Exploration**: Explore meticulously reconstructed historical ports, temples, and submerged ruins.
- **Historical World Building**: Architecture, attire, props, and environments derived from Sangam literature.
- **Story-driven Gameplay**: Deep narrative quests based on ancient epic texts.
- **Environmental Puzzles**: Ancient water mechanics, astrological aligners, and puzzle mechanisms.
- **Dynamic Combat & Mechanics**: Fluid melee combat and traditional weapon arts.
- **NPC Interaction & Dialogue System**: Interactive branching dialogues with historical figures and citizens.
- **Quest System**: Main historical campaign and cultural discovery side quests.
- **Cultural Reconstruction**: Interactive codex featuring historical facts, literary excerpts, and 3D artifacts.

---

## Technology Stack

- **Game Engine**: Unity 2022 LTS / Unreal Engine 5
- **Programming Language**: C# / C++
- **3D Modeling & Animation**: Blender / ZBrush
- **Version Control**: Git / GitHub

---

## Research-to-Implementation Pipeline

What sets *The Last Born* apart in SIH 2026 is our rigorous research-driven design pipeline:

```
Historical Research  ──►  Literary Reference  ──►  Game Design Doc  ──►  3D Asset Creation  ──►  Unity Implementation
 (Poompuhar/Sangam)       (Silappathikaram)          (Level/Mechanics)      (Blender/Textures)          (C# Gameplay)
```

Every environment, building, character, and quest item links directly to entries in the `Research/` directory.

---

## Project Structure

```
THE-LAST-BORN/
├── Game/                # Core Unity/Engine project files
│   ├── Assets/          # 3D models, textures, animations, audio, UI
│   ├── Scenes/          # Main menu, Poompuhar, Kumari Kandam, Temples
│   ├── Scripts/         # C# player, combat, AI, quest, dialogue systems
│   └── Audio/           # Music, SFX, voice overs
├── Art/                 # Blender source files, concept art, reference images
├── Design/              # Game Design Documents (GDD), story, lore, level designs
├── Research/            # Historical literature, Poompuhar layouts, Sangam epics
├── Documentation/       # System architecture, setup guide, team roles, controls
├── SIH/                 # Problem statement, solution overview, presentation slides
└── Builds/              # Release notes and build artifacts
```

---

## Team Astute

| Member | Role | GitHub Responsibilities |
| :--- | :--- | :--- |
| **Joel** | Lead Game Developer | Game Integration, Engine Architecture, Build Pipeline |
| **Elavarasan** | Gameplay Programmer | Player Controller, Movement, Combat System |
| **Nithish** | 3D & Environment Designer | 3D Modeling (Poompuhar/Kumari Kandam), Lighting, Level Art |
| **Sathish** | Systems & AI Programmer | Enemy AI, Pathfinding, Save System, Game State |
| **Vinothini** | Game Designer & Writer | Narrative, Quest Design, Lore, Dialogue Writing |
| **Priyanka** | UI/UX & Documentation | UI Design, Art Pipeline, Documentation, SIH Deliverables |

---

## Git & Branching Strategy

```
main  (Stable Production Builds)
 │
 └── develop  (Active Integration Branch)
      │
      ├── feature/player          (Elavarasan)
      ├── feature/combat          (Elavarasan)
      ├── feature/interaction     (Sathish)
      ├── feature/ai              (Sathish)
      ├── feature/dialogue        (Vinothini)
      ├── feature/quest           (Vinothini)
      │
      ├── environment/poompuhar   (Nithish)
      ├── environment/kumari-kandam (Nithish)
      │
      ├── art/characters          (Priyanka / Nithish)
      ├── art/props               (Priyanka / Nithish)
      │
      └── ui/main-menu            (Priyanka)
```

### Commit Message Guidelines

- `feat: add player movement and dash`
- `feat: implement dialogue tree parser`
- `feat: add enemy patrol AI`
- `feat: create Poompuhar marketplace layout`
- `art: add ancient Chola architecture models`
- `art: add player character rigged mesh`
- `fix: resolve trigger collision bug in quest zone`
- `docs: update Game Design Document for Level 1`
- `research: add Poompuhar harbor trade references`
