
using RemoteControl;
using RemoteControl.Elements;
using RemoteControl.Elements.Commands;

ButtonPressed orden = new ButtonPressed();

ICommandCR pressNetflix = new NetflixCommand(orden);
ICommandCR pressYoutube= new YoutubeCommand(orden);
ICommandCR pressTv = new TVModeCommand(orden);
ICommandCR pressG = new SearchGoogleCommand(orden);

RemmoteControl controlRemoto = new RemmoteControl();
controlRemoto.TakeCommand(pressNetflix);
controlRemoto.TakeCommand(pressYoutube);
controlRemoto.TakeCommand(pressTv);
controlRemoto.TakeCommand(pressG);
controlRemoto.TakeCommand(pressYoutube);