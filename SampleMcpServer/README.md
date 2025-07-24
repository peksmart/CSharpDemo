# MCP ������

��� README ��ʹ�� C# MCP ��������Ŀģ�崴���ġ�����ʾ�����ʹ�� C# ���ɴ��� MCP �����������䷢��Ϊ NuGet ����

�鿴����ָ������� [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide)��

��ע�⣬��ģ��Ŀǰ��������Ԥ���׶Ρ�������з�������������[��̵���](http://aka.ms/dotnet-mcp-template-survey)��

## ������ NuGet.org ֮ǰ�ļ���嵥

- ʹ�����²����ڱ��ز��� MCP ��������
- ���� .csproj �ļ��еİ�Ԫ���ݣ��ر��� `<PackageId>`��
- ���� `.mcp/server.json` ���������� MCP �����������롣
  - ������ϸ��Ϣ��鿴[��������](https://aka.ms/nuget/mcp/guide/configuring-inputs)��
- ʹ�� `dotnet pack` �����Ŀ��

`bin/Release` Ŀ¼���������ļ� (.nupkg)������[������ NuGet.org](https://learn.microsoft.com/nuget/nuget-org/publish-a-package)��

## ���ؿ���

Ҫ��Դ���루���أ����Դ� MCP ����������ʹ�ù����� MCP ������������������������ IDE ʹ�� `dotnet run` ֱ��������Ŀ��

```json
{
  "servers": {
    "SampleMcpServer": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "<��ĿĿ¼·��>"
      ]
    }
  }
}
```

## ���� MCP ������

������ɺ��������� Copilot Chat ����һ������������磬`���� 3 �������`����Ӧ�û���ʾ���� `SampleMcpServer` MCP ��������ʹ�� `get_random_number` ���߲���ʾ�����

## ������ NuGet.org

1. ���� `dotnet pack -c Release` ���� NuGet ��
2. ʹ�� `dotnet nuget push bin/Release/*.nupkg --api-key <your-api-key> --source https://api.nuget.org/v3/index.json` ������ NuGet.org

## �� NuGet.org ʹ�� MCP ������

һ�� MCP �������������� NuGet.org�����Ϳ���������ѡ�� IDE ����������VS Code �� Visual Studio ��ʹ�� `dnx` ����� NuGet.org ���غͰ�װ MCP ����������

- **VS Code**: ���� `<�����ռ�Ŀ¼>/.vscode/mcp.json` �ļ�
- **Visual Studio**: ���� `<�������Ŀ¼>\.mcp.json` �ļ�

���� VS Code �� Visual Studio�������ļ�ʹ�����·��������壺

```json
{
  "servers": {
    "SampleMcpServer": {
      "type": "stdio",
      "command": "dnx",
      "args": [
        "<���İ� ID>",
        "--version",
        "<���İ��汾>",
        "--yes"
      ]
    }
  }
}
```

## ������Ϣ

.NET MCP ������ʹ�� [ModelContextProtocol](https://www.nuget.org/packages/ModelContextProtocol) C# SDK���й� MCP �ĸ�����Ϣ��

- [�ٷ��ĵ�](https://modelcontextprotocol.io/)
- [Э��淶](https://spec.modelcontextprotocol.io/)
- [GitHub ��֯](https://github.com/modelcontextprotocol)

�й����ú�ʹ�� MCP �������ĸ�����Ϣ����ο� VS Code �� Visual Studio �ĵ���

- [�� VS Code ��ʹ�� MCP ��������Ԥ����](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)
- [�� Visual Studio ��ʹ�� MCP ��������Ԥ����](https://learn.microsoft.com/visualstudio/ide/mcp-servers)
