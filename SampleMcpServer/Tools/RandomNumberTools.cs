using System.ComponentModel;
using ModelContextProtocol.Server;

/// <summary>
/// 用于演示目的的示例 MCP 工具。
/// 这些工具可以被 MCP 客户端调用来执行各种操作。
/// </summary>
internal class RandomNumberTools
{
    [McpServerTool]
    [Description("生成指定最小值和最大值之间的随机数。")]
    public int GetRandomNumber(
        [Description("最小值（包含）")] int min = 0,
        [Description("最大值（不包含）")] int max = 100)
    {
        return Random.Shared.Next(min, max);
    }
}
