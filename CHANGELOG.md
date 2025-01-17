# Changelog

All notable changes to this project will be documented in this file.
The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).



## [2.5.12] - 2024-07-02

### Fixed

- Fixed compilation errors in Unity 2019.4.



## [2.5.4] - 2023-12-12

### Fixed

- Fixed invalid property name or type cause metadata generation incorrect.



## [2.5.0] - 2023-11-24

### Added

- **Metadata Persistent Store Path** supports package path, e.g. **Packages/com.xxx.xxx**.
- **Entity Scripts Store Path** supports package path, e.g. **Packages/com.xxx.xxx**.



## [2.3.0] - 2022-12-26

### Added

- Surport UnityEngine type array parsing: **Vector2[]**/**Vector2Int[]**/**Vector3[]**/**Vector3Int[]**/**Vector4[]**/**RangeInt[]**/**Quaternion[]**/**Rect[]**/**RectInt[]**/**Color[]**/**Color32[]**.



## [2.2.0] - 2022-12-10

### Added

- Surport UnityEngine types parsing: **Vector2**/**Vector2Int**/**Vector3**/**Vector3Int**/**Vector4**/**RangeInt**/**Quaternion**/**Rect**/**RectInt**/**Color**/**Color32**.



## [2.1.0] - 2022-11-08

### Added

- Cache MD5 of excel files to determine whether update metadata database file in Project or not.
- Adds **Delete Redundant Metadata?** option to determine whether delete redundant metadata database files and entity scripts or not.



### Changed

- Refactor GUI layout of importer window.



## [2.0.0] - 2021-06-29

### Changed

- Change code to adjust iBoxDB version 3.5.



## [1.1.0] - 2020-04-24

### Added

- Add setting data encryption/decryption to protect database file.

  

## [1.0.0] - 2020-04-24

### Added

- Initial unity project.
