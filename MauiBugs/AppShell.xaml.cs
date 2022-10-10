namespace MauiBugs;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Shell.SetForegroundColor(this,Colors.Black);
		Shell.SetBackgroundColor(this,Colors.White);
		Shell.SetNavBarHasShadow(this,true);
		TitleControl titleControl= new TitleControl();	
		Shell.SetTitleView(this,titleControl);
	}
}
