# MCP 服务器

这个 README 是使用 C# MCP 服务器项目模板创建的。它演示了如何使用 C# 轻松创建 MCP 服务器并将其发布为 NuGet 包。

查看完整指南请访问 [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide)。

请注意，此模板目前处于早期预览阶段。如果您有反馈，请参与这个[简短调查](http://aka.ms/dotnet-mcp-template-survey)。

## 发布到 NuGet.org 之前的检查清单

- 使用以下步骤在本地测试 MCP 服务器。
- 更新 .csproj 文件中的包元数据，特别是 `<PackageId>`。
- 更新 `.mcp/server.json` 来声明您的 MCP 服务器的输入。
  - 更多详细信息请查看[配置输入](https://aka.ms/nuget/mcp/guide/configuring-inputs)。
- 使用 `dotnet pack` 打包项目。

`bin/Release` 目录将包含包文件 (.nupkg)，可以[发布到 NuGet.org](https://learn.microsoft.com/nuget/nuget-org/publish-a-package)。

## 本地开发

要从源代码（本地）测试此 MCP 服务器而不使用构建的 MCP 服务器包，您可以配置您的 IDE 使用 `dotnet run` 直接运行项目。

```json
{
  "servers": {
    "SampleMcpServer": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "<项目目录路径>"
      ]
    }
  }
}
```

## 测试 MCP 服务器

配置完成后，您可以向 Copilot Chat 请求一个随机数，例如，`给我 3 个随机数`。它应该会提示您在 `SampleMcpServer` MCP 服务器上使用 `get_random_number` 工具并显示结果。

## 发布到 NuGet.org

1. 运行 `dotnet pack -c Release` 创建 NuGet 包
2. 使用 `dotnet nuget push bin/Release/*.nupkg --api-key <your-api-key> --source https://api.nuget.org/v3/index.json` 发布到 NuGet.org

## 从 NuGet.org 使用 MCP 服务器

一旦 MCP 服务器包发布到 NuGet.org，您就可以在您首选的 IDE 中配置它。VS Code 和 Visual Studio 都使用 `dnx` 命令从 NuGet.org 下载和安装 MCP 服务器包。

- **VS Code**: 创建 `<工作空间目录>/.vscode/mcp.json` 文件
- **Visual Studio**: 创建 `<解决方案目录>\.mcp.json` 文件

对于 VS Code 和 Visual Studio，配置文件使用以下服务器定义：

```json
{
  "servers": {
    "SampleMcpServer": {
      "type": "stdio",
      "command": "dnx",
      "args": [
        "<您的包 ID>",
        "--version",
        "<您的包版本>",
        "--yes"
      ]
    }
  }
}
```

## 更多信息

.NET MCP 服务器使用 [ModelContextProtocol](https://www.nuget.org/packages/ModelContextProtocol) C# SDK。有关 MCP 的更多信息：

- [官方文档](https://modelcontextprotocol.io/)
- [协议规范](https://spec.modelcontextprotocol.io/)
- [GitHub 组织](https://github.com/modelcontextprotocol)

有关配置和使用 MCP 服务器的更多信息，请参考 VS Code 或 Visual Studio 文档：

- [在 VS Code 中使用 MCP 服务器（预览）](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)
- [在 Visual Studio 中使用 MCP 服务器（预览）](https://learn.microsoft.com/visualstudio/ide/mcp-servers)
