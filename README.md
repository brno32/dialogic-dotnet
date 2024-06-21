# DialogicDotnet

This is just a C# wrapper around https://github.com/dialogic-godot/dialogic

Slap it into your `addons` folder and use like so.

```C#
using Godot;

public partial class Example : Node
{
    public override void _EnterTree()
    {
        DialogicDotnet.Connect("signal_event", Callable.From<string>(HandleDialogicSignal));
    }

    public override void _Ready()
    {
        DialogicDotnet.Start("timelineName");
    }

    public void HandleDialogicSignal(string argument)
    {
        if (argument == "hi-from-dialogic")
        {
            GD.Print("time to run this scene");
        }
    }
}
```
