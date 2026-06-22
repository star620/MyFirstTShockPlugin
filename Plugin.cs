using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace MyFirstTShockPlugin;

[ApiVersion(2, 1)]
public class Plugin : TerrariaPlugin
{
    // 插件名称
    public override string Name => "MyFirstTShockPlugin";

    // 作者
    public override string Author => "星梦";

    // 描述
    public override string Description => "我的第一个TShock插件！";

    // 版本号
    public override Version Version => new Version(1, 0, 0);

    public Plugin(Main game) : base(game)
    {
    }

    // 插件初始化时执行
    public override void Initialize()
    {
        // 注册一个聊天命令: /hello
        TShockAPI.Commands.ChatCommands.Add(new Command(
            permissions: "myfirst.hello", // 需要的权限
            cmd: HelloCommand,            // 执行的方法
            names: "hello"                 // 命令名称
        ));

        // 注册服务器启动消息
        ServerApi.Hooks.GameInitialize.Register(this, OnGameInit);
    }

    // 插件卸载时执行
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            // 注销命令
            TShockAPI.Commands.ChatCommands.RemoveAll(
                c => c.CommandDelegate == HelloCommand
            );
            // 注销钩子
            ServerApi.Hooks.GameInitialize.Deregister(this, OnGameInit);
        }
        base.Dispose(disposing);
    }

    // 服务器初始化时发送欢迎消息
    private void OnGameInit(EventArgs args)
    {
        TShock.Log.ConsoleInfo($"[{Name}] 插件已加载！版本: {Version}");
    }

    // /hello 命令的实现
    private void HelloCommand(CommandArgs args)
    {
        var player = args.Player;
        if (player == null) return;

        player.SendSuccessMessage($"你好, {player.Name}! 欢迎使用我的第一个TShock插件!");
        player.SendInfoMessage("输入 /hello 可以随时看到这条消息。");
    }
}
