using System;

namespace M2E4Mono
{
	public class Resources {
		public Resources (){
		}
		public static string SB { get { return "{";} }
		public static string EB { get { return "}";} }
		public static string Tab { get { return "\t";} }
		public static string Nl { get { return "\n";} }
		public static string ComSp{ get { return "//"; } }
		public static string DirSp{ get { return "/"; } }
		public static string Header1 {
			get {
				return "//------------------------------------------------------------------------------------------------\n"
				+ ComSp + "    このコードはMySqlToEntityで生成されました。" + Nl
				+ ComSp + Nl
				+ ComSp + "    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。" + Nl
				+ ComSp + "    このファイルに対する手動の変更は、コードが再生成されると上書きされます。" + Nl
				+ ComSp + "------------------------------------------------------------------------------------------------" + Nl;
			}
		}
		public static string Config1 {
			get { 
				return "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n"
				+ "  <!--\n"
				+ "    This File Generated M2E4Mono.\n"
				+ "    Please refer when creating \"App.config\".\n"
				+ "  -->\n"
				+ "<configuration>\n"
				+"  <configSections>\n"
				+ "    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->\n    <section name=\"entityFramework\" type=\"System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\" requirePermission=\"false\"/>\n  </configSections>\n  <startup>\n    <supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.5\"/>\n  </startup>\n  <entityFramework>\n    <defaultConnectionFactory type=\"System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework\"/>\n"
				+ "    <section name=\"entityFramework\" type=\"System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\" requirePermission=\"false\"/>"
				+ "  </configSections>\n"
				+ "  <startup>\n"
				+ "    <supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.5\"/>\n"
				+ "  </startup>\n"
				+ "  <entityFramework>\n"
				+ "    <defaultConnectionFactory type=\"System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework\"/>\n"
				+ "    <providers>\n"
				+ "      <provider invariantName=\"System.Data.SqlClient\" type=\"System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer\"/>\n"
				+ "      <provider invariantName=\"MySql.Data.MySqlClient\" type=\"MySql.Data.MySqlClient.MySqlProviderServices, MySql.Data.Entity.EF6, Version=6.9.9.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d\"></provider>\n"
				+ "    </providers>\n"
				+ "  </entityFramework>\n"
				+ "  <system.data>\n"
				+ "    <DbProviderFactories>\n"
				+ "      <remove invariant=\"MySql.Data.MySqlClient\"/>"
				+ "      <add name=\"MySQL Data Provider\" invariant=\"MySql.Data.MySqlClient\" description=\".Net Framework Data Provider for MySQL\" type=\"MySql.Data.MySqlClient.MySqlClientFactory, MySql.Data, Version=6.9.9.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d\"/>\n"
				+ "    </DbProviderFactories>\n"
				+ "  </system.data>\n"
				+ "  <connectionStrings>\n"
				+ "    <add name=";
			}
		}
		public static string Config2 {
			get { return "connectionString="; }
		}
		public static string Config3 {
			get {
				return "\n      providerName=\"MySql.Data.MySqlClient\" />\n"
				+ "  </connectionStrings>\n"
				+ "</configuration>\n";
			}
		}
	}
}

