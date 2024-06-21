#if TOOLS
using Godot;

[Tool]
public partial class DialogicDotnetPlugin : EditorPlugin
{
    private const string AutoloadName = "DialogicDotnet";

    public override void _EnterTree()
	{
        AddAutoloadSingleton(AutoloadName, "res://addons/dialogic_dotnet/DialogicDotnet.cs");
    }

	public override void _ExitTree()
	{
        RemoveAutoloadSingleton(AutoloadName);
    }
}
#endif
