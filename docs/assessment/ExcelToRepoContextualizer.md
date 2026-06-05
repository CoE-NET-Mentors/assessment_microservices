# Excel To Repo Contextualizer

The CoE roadmap workbook is the source of truth for expected capabilities. This repository should not copy the roadmap into a parallel checklist.

Use this file as a prompt starter when the roadmap workbook needs to inform repository updates.

## Suggested Prompt

```text
Read the current CoE roadmap workbook and compare it with this assessment repository.

Do not copy the roadmap into the repository.

Identify practical repository updates that would improve coverage of the roadmap while keeping the repo small, working, and useful for live technical assessments.

Focus on:
- missing practical task scenarios
- missing code scaffolding that would let a DP demonstrate a roadmap capability
- docs that are stale or misleading
- frontend task variants that should exist for both React and Angular
- areas where Docker/local emulation would be useful without introducing cloud setup noise

Preserve these constraints:
- DP-facing docs must not include hidden grading guidance
- the official assessment evidence format lives outside the repo
- the repo should support Junior through Principal
- the baseline should build and run
- tasks should read like assigned customer work, not exam questions

Return:
1. recommended README changes
2. recommended task catalog changes
3. recommended code or scaffold changes
4. any build/test risks found
```

## Maintenance Notes

- Keep roadmap references capability-oriented, not row-by-row.
- Prefer adding or improving task scenarios over adding long explanatory docs.
- Treat cloud topics as discussion/local-simulation opportunities unless a real sandbox exists.
- Keep mentor-only calibration outside committed DP-readable docs.
