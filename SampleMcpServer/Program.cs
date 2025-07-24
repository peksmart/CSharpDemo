using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

// ����������־����� stderr��stdout ���� MCP Э����Ϣ����
builder.Logging.AddConsole(o => o.LogToStandardErrorThreshold = LogLevel.Trace);

// ��� MCP ����Ҫʹ�õĴ��䷽ʽ��stdio����Ҫע��Ĺ��ߡ�
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools<RandomNumberTools>();

await builder.Build().RunAsync();
