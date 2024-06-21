using Godot;

public partial class DialogicDotnet : Node
{
    static Node gdScriptDialogic;

    public override void _EnterTree()
	{
        gdScriptDialogic = GetNode("/root/Dialogic");
    }

    static public void Start(string timelineName)
    {
        gdScriptDialogic.Call("start", timelineName);
    }

    static public void Connect(string signalName, Callable callable)
    {
        gdScriptDialogic.Connect(signalName, callable);
    }

    static public void Disconnect(string signalName, Callable callable)
    {
        gdScriptDialogic.Disconnect(signalName, callable);
    }
}
