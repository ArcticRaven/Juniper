# Juniper

A private, self-hosted personal AI assistant and life management system. Voice-driven, always-on, and distributed across all devices. No cloud dependency, no external API costs, no data leaving your infrastructure.

---

## Core Principles

- **Local-first** — every node operates fully offline, sync is additive
- **Zero-knowledge** — encryption keys never leave the user's session, infrastructure cannot read profile data
- **Capability-based** — nodes declare what they can do, tasks route to whoever can handle them
- **Modular** — services and capabilities can be enabled/disabled per device
- **Self-hosted** — everything runs on owned infrastructure

---

## Services

**Calendar** — Event scheduling, reminders, daily briefing generation, Work/Play/Family context tagging, and routine pattern detection.

**Project Management** — Active, paused, and archived projects. Idea backlog, knowledge base, learning goals, travel planning, and studio management. Staleness detection surfaces neglected items proactively.

**Life Dashboard** — Financial awareness, health and habit tracking, and work/life/family balance monitoring. Pattern analysis with proactive insights across all three domains.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# / .NET |
| UI | .NET MAUI (Desktop, iOS, iPadOS) |
| Backend | ASP.NET Core |
| Database | SQLite via SQLCipher (encrypted per-profile) |
| Sync Bus | Redis (pub/sub, capability registry, task queue) |
| STT | Whisper small/base |
| LLM | Ollama — quantized 7B (Q4) |
| TTS | Style-TTS2 + RVC, streamed |
| Speaker ID | Pyannote |
| Networking | WireGuard mesh, Caddy reverse proxy |
| Auth | JWT (mobile), biometrics (MAUI), voice recognition (Pi) |

---

## Architecture

### Interaction Model

```
Wake Word → STT → Intent Classification
                        ├── Known command    → Execute → Cached TTS confirm
                        ├── Chained commands → Queue   → Execute sequentially
                        ├── Ambiguous        → LLM disambiguation → Confirm → Execute
                        └── Conversational   → LLM response → Streaming TTS
```

### Mesh — Capability Registry

Each node registers its capabilities with Redis on startup and sends a heartbeat. Dead nodes drop their capabilities automatically.

| Node | Capabilities |
|---|---|
| OVH Dedi | `llm` `tts_synthesis` `stt_heavy` `sync_hub` `api_gateway` `archive` `app_resign` |
| Raspberry Pi 5 | `wake_word` `stt_light` `tts_playback` `local_hub` `always_on` |
| Desktop | `ui_full` `stt_light` `tts_playback` |
| iPad | `ui_review` `quick_capture` |
| iPhone | `ui_minimal` `notifications` `quick_capture` |

### Infrastructure

| Node | Role |
|---|---|
| OVH Dedi (Xeon E-2136, 64GB) | Primary hub — LLM, TTS, sync, API gateway, AltServer |
| Raspberry Pi 5 16GB + 1TB NVMe | Local sensory node — wake word, always-on daemon, fallback hub |
| Desktop | Full management UI, WireGuard peer |
| iPad | Planning and review, daily briefing, quick capture |
| iPhone | Quick interaction, notifications, minimal state |

Mobile devices connect via public HTTPS API gateway — no VPN required. Dedi, Pi, and Desktop form a WireGuard mesh.

---

## Project Structure

```
Juniper/
  Juniper.Core/     # Shared models, schema, task system, capability interfaces,
                    # auth contracts, command chaining, context tagging
  Juniper.Auth/     # Profile management, key derivation, SQLCipher,
                    # voice key validation, JWT token management
  Juniper.Sync/     # Redis pub/sub, mesh event queue, delta sync,
                    # offline queue and flush logic
  Juniper.Server/   # ASP.NET Core API gateway, LLM orchestration,
                    # TTS pipeline, AltServer Linux, archive management
  Juniper.App/      # .NET MAUI — Desktop, iOS, iPadOS
                    # Shared UI codebase, platform-specific layouts
  Juniper.Daemon/   # Headless Pi service — wake word, STT, TTS playback,
                    # local hub fallback, always-on sync queue
```

---

## Milestones

### Phase 1 — Foundation
- [ ] `Juniper.Core` — models, DB schema, task system, capability interfaces, context tags
- [ ] `Juniper.Auth` — key derivation, SQLCipher integration, profile management

### Phase 2 — First Usable Build
- [ ] Local SQLite working copy
- [ ] Basic MAUI desktop app — Calendar and Projects only
- [ ] `Juniper.Sync` — Redis sync between desktop and dedi

### Phase 3 — Voice Layer
- [ ] `Juniper.Daemon` — Pi wake word detection and STT pipeline
- [ ] TTS pipeline on dedi — Style-TTS2 + RVC, chunked streaming

### Phase 4 — Intelligence
- [ ] LLM integration on dedi via Ollama
- [ ] Intent classification — known commands, chaining, disambiguation, conversational

### Phase 5 — Mobile
- [ ] MAUI iPad layout — planning and review
- [ ] MAUI iPhone layout — quick interaction and notifications

### Phase 6 — Life Dashboard
- [ ] Financial awareness — spending tracking, budget alerts, decision support
- [ ] Health and habit tracking — routines, streaks, rest awareness
- [ ] Work/life/family balance monitoring and pattern analysis

### Phase 7 — Auth and Multi-Profile
- [ ] Voice recognition auth via Pyannote — confidence threshold, fallback PIN
- [ ] Multi-profile support — per-profile encrypted SQLite, auto context switching

### Phase 8 — iOS Distribution
- [ ] AltServer Linux integration on dedi for iOS app resigning and sideloading

---

## Future Capabilities

Infrastructure is being built with these in mind, not yet scheduled:

- Computer vision via Pi camera, iPhone/iPad camera
- Hailo-8L hardware acceleration for vision tasks on Pi
- Speaker diarization expansion for additional profiles
- RTSP/WebRTC Pi camera remote access
- PWA fallback client

---

## License

This project is source-available under a custom license. You may view and self-host it for personal use. Redistribution, commercial use, modification, and incorporation into other projects are not permitted. See [LICENSE](./LICENSE) for full terms.