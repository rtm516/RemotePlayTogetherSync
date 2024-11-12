# Steam Remote Play Together Achievements Sync

[![License: GPL-3.0](https://img.shields.io/github/license/rtm516/RemotePlayTogetherSync)](LICENSE)
[![Build Release](https://github.com/rtm516/RemotePlayTogetherSync/actions/workflows/release.yml/badge.svg)](https://github.com/rtm516/RemotePlayTogetherSync/releases)
[![HitCount](https://hits.dwyl.com/rtm516/RemotePlayTogetherSync.svg?style=flat)](http://hits.dwyl.com/rtm516/RemotePlayTogetherSync)

This project is designed to sync achievements for users joining a game via Steam's Remote Play Together. It allows the non-host player to earn and sync achievements to their Steam account, so their progress is tracked just like if they were playing on their own device.

![UI screenshot](https://github.com/user-attachments/assets/88d59642-6954-4892-9b40-54a65f492283)

## Requirements

- **.NET Core 8.0** or higher
- **Copy of the game**: The guest user account must have access to the game's achievements
- **Remote Play Together setup**: Ensure you’re joining a compatible game via Remote Play Together.

## Usage

1. Join a Remote Play Together session for a supported game on Steam.
2. Run Steam RemotePlay Together Achievements Sync.
3. Select the game from the list of running processes and the friend you’re playing with.
4. The application will automatically monitor and sync achievements during gameplay.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`feature/YourFeature`).
3. Commit your changes.
4. Push the branch.
5. Open a Pull Request.
