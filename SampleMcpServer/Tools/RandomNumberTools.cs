using System.ComponentModel;
using ModelContextProtocol.Server;

/// <summary>
/// ������ʾĿ�ĵ�ʾ�� MCP ���ߡ�
/// ��Щ���߿��Ա� MCP �ͻ��˵�����ִ�и��ֲ�����
/// </summary>
internal class RandomNumberTools
{
    [McpServerTool]
    [Description("����ָ����Сֵ�����ֵ֮����������")]
    public int GetRandomNumber(
        [Description("��Сֵ��������")] int min = 0,
        [Description("���ֵ����������")] int max = 100)
    {
        return Random.Shared.Next(min, max);
    }
}
