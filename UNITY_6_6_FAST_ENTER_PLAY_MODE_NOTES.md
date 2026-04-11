# Unity 6.6 Fast Enter Play Mode viability notes

This branch is not presented as a finished Unity 6.6 support release. It captures the Extenject changes we used in a consumer project to keep Zenject-based runtime wiring viable on Unity 6.6 alpha with Fast Enter Play Mode enabled and domain reload disabled.

## What this changes

- Converts existing enter-play-mode reset hooks from editor-only `EditorSettings.enterPlayModeOptionsEnabled` checks into runtime `RuntimeInitializeLoadType.SubsystemRegistration` resets.
- Resets `ProjectContext`, `SceneContext`, `RunnableContext`, `StaticContext`, `ZenjectSettings`, `TypeAnalyzer`, `ProfileBlock`, and `ConventionBindInfo` static state explicitly at subsystem registration.
- Adds explicit reset coverage for static memory pools and the static pool registry so pooled objects and pool event handlers do not carry over between play sessions.
- Adds file-local runtime reset hooks for `DictionaryPool`, `HashSetPool`, and `ListPool` to make the static pool reset path visible in the same locations that were flagged during audit.

## Why we needed this

In the consumer project, Unity 6.6 and Project Auditor still reported a cluster of domain-reload hazards inside Extenject even after first-party runtime code had been hardened. The remaining issues were concentrated in static contexts, static caches, and static pools that previously relied on domain reload to clear themselves between play sessions.

That was acceptable in older project setups, but it is not a safe assumption once Fast Enter Play Mode is the default and domain reload is disabled.

## Where this was exercised

These changes were taken from a Unity 6.6 alpha migration branch in a real game project that embeds Extenject source directly under `Assets/Plugins/Zenject`.

In that consumer project, this patch set was enough to:

- clear the Zenject-specific Project Auditor findings that were driving the follow-up pass,
- keep batchmode script compilation green on Unity `6000.6.0a2`,
- keep the current PlayMode suite green with domain reload disabled, and
- keep the player build green after the Zenject pass.

## Scope and limits

- This branch is intentionally narrow. It captures the concrete reset and static-state changes we needed for Unity 6.6 viability, not a full modernization of the repository's Unity project or package layout.
- Validation was done in the consumer project integration, not by upgrading and exhaustively validating this upstream repository's Unity sample project under 6.6.
- If these changes go upstream, the safest framing is: here are the explicit reset points we needed to make Extenject behave correctly in a Unity 6.6 consumer project with Fast Enter Play Mode enabled.
