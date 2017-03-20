using System;
using Gtk;
using M2E4Mono;
public partial class MainWindow: Gtk.Window
{
	private Pango.TabArray Tabs;
	private string _connectionstring;
	private FileFilter _filter1;
	private FileFilter _filter2;
	public MainWindow () : base (Gtk.WindowType.Toplevel){
		Tabs = new Pango.TabArray (0,true);
		_connectionstring = "";
		Build ();
		_filter1 = new FileFilter ();
		_filter1.Name = "All files";
		_filter1.AddPattern("*");
		_filename.AddFilter (_filter1);
		_filter2 = new FileFilter ();
		_filter2.Name =  "MySQL Workbench Models";
		_filter2.AddPattern("*.mwb");
		_filename.AddFilter (_filter2);

		//_filename.AddFilter(FileFilter(
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnOkClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
		Mwb fil = new Mwb();
		fil.Filename = _filename.Filename;
		fil.Server = _server.Text;
		fil.Name = _name.Text;
		fil.UserID = _user.Text;
		fil.Password = _pass.Text;
		fil.Database = _data.Text;
		fil.Load();
		//Pango.FontDescription font = Pango.FontDescription.FromString ("MigMix1P Normal 11");
		Pango.FontDescription font = Pango.FontDescription.FromString ("TakaoGothic Normal 10");
		_preview.ModifyFont (font);
		_preview.AcceptsTab = true;
		Tabs.SetTab (1, Pango.TabAlign.Left, 28);
		_preview.Tabs = this.Tabs;
		_preview.Buffer.Text = fil.GetSourceCode ();
	}

	protected void OnFilenameSelectionChanged (object sender, EventArgs e) {
		string wk = _filename.Filename;
		wk = wk.Substring(wk.LastIndexOf(Resources.DirSp)+1,wk.LastIndexOf(".")-wk.LastIndexOf(Resources.DirSp)-1);
		_name.Text = wk;
	}

	protected void OnTestClicked (object sender, EventArgs e) {
		MySql.Data.MySqlClient.MySqlConnectionStringBuilder bld
			= new MySql.Data.MySqlClient.MySqlConnectionStringBuilder ();
		bld.Server = _server.Text;
		bld.UserID = _user.Text;
		bld.Password = _pass.Text;
		_connectionstring = bld.ConnectionString;
		MySql.Data.MySqlClient.MySqlConnection con
			= new MySql.Data.MySqlClient.MySqlConnection ();
		con.ConnectionString = _connectionstring;
		MessageDialog dlg;
		try{
			con.Open ();
			if (con.State != System.Data.ConnectionState.Open){
				dlg = new MessageDialog(this,DialogFlags.Modal,MessageType.Error,ButtonsType.Ok,"オープンできません。" +　con.State.ToString());
				dlg.Show();
			} else {
				dlg = new MessageDialog(this,DialogFlags.Modal,MessageType.Info,ButtonsType.Ok,"Success. " +　con.State.ToString());
				dlg.Show();
				con.Close();
			}

		}
		catch (MySql.Data.MySqlClient.MySqlException ex){
			dlg = new MessageDialog(this,DialogFlags.Modal,MessageType.Error,ButtonsType.Ok,"Can not open MySQL."+ex.ErrorCode.ToString());
			dlg.Show();
		}
	}
}
