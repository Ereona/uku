1. LTS releases are more stable than latest versions. They are frequently updated during their support cycle to improve performance and address any minor fixes which are needed.
2. Assets - folder where all project content is located. Editor - folders for editor scripts (available in editor but not in builds). StreamingAssets - files from this folder are copied unchanged to build. Resources - you can load assets from this folder by path.
3. I divide assets by types, it means I create folders Scenes, Scripts, Prefabs, Models, Materials and so on. Inside each folder I create subfolders to structure further.
4. Zenject or other DI plugin (useful for game init ang dependencies building); DoTween (if your project will have animations it is a convenient plugin for them); some plugin for pooling (to store instances is usually better than recreate)