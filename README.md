# MyFirstTShockPlugin

这是我的第一个 **TShock** 插件项目！🎮

## 功能

- 注册 `/hello` 命令，玩家可以输入后收到欢迎消息
- 服务器启动时显示插件加载信息

## 环境要求

- .NET 9.0 SDK
- JetBrains Rider 或 Visual Studio Code
- TShock 6.1.0 服务器

## 如何编译

```bash
dotnet build
```

## 如何安装到TShock服务器

1. 编译项目后，将生成的 `MyFirstTShockPlugin.dll` 复制到 TShock 服务器的 `ServerPlugins` 文件夹
2. 启动服务器，插件会自动加载

## 插件信息

| 属性 | 值 |
|------|-----|
| 名称 | MyFirstTShockPlugin |
| 作者 | 星梦 |
| 版本 | 1.0.0 |
| 描述 | 我的第一个TShock插件！ |

## 命令列表

| 命令 | 权限 | 描述 |
|------|------|------|
| `/hello` | `myfirst.hello` | 向玩家发送欢迎消息 |

## 开发参考

- [TShock插件开发教程](https://docs.terraria.ink/zh/plugin-dev/get-start.html)
