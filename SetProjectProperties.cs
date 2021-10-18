public class RegisterScriptMenu
{
	[DeclareMenu]
	public void MenuFunction()
	{
		Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();
       	oMenu.AddMenuItem("Import Block Properties", "SetProjectPropertiesAction");
	}

    [DeclareAction("SetProjectPropertiesAction")]
    public void SetProjectPropertiesAction()
    {	
		var cli = new Eplan.EplApi.ApplicationFramework.CommandLineInterpreter();
		
		System.Collections.Generic.List<PropEntry> pe = new System.Collections.Generic.List<PropEntry>();
		
		pe.Add(new PropEntry{Id="10605", Index="50", Value=@"Rack:[SP][20064<20201<20410,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>][LF]Slot:[SP][20064<20201<20411,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>]@@Used to format the display of PLC Rack & Slotnumbers"});
		pe.Add(new PropEntry{Id="10610", Index="50", Value=@"[20205,2,2<20201<20045,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>]@@Va chercher la Remark sur le SL. Pour lesTeSys, on utilise la Remark pour l'ajustement des OL"});
		pe.Add(new PropEntry{Id="10610", Index="51", Value=@"[20067<20203,2,2<20201<20045,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>]@@Comme le BP 50, mais va sur le Main function of superior device au lieu du Main Function"});
		pe.Add(new PropEntry{Id="10606", Index="50", Value=@"NODE:[SP][20201<20311,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>]@@Used to 'pretty print' the Canbus node ID so thatwe only enter the node number without text"});
		pe.Add(new PropEntry{Id="10600", Index="50", Value=@"[20064<20203,2,1<20201<MACH.Equipment.Type,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>][20064<20203,2,1<20201<20014,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>][LF][20064<20203,2,1<20201<20031,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>]@@Va chercher le Type d'équipementMachinex, le DT Counter, puis le Function Text sur le SL (Utilisé pour les TeSys U entres autres)"});
		pe.Add(new PropEntry{Id="10600", Index="51", Value=@"[20203,2,1<20201<20027,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>]@@Va chercher le Technical characteristic sur le SL (TeSys U par exemple)"});
		pe.Add(new PropEntry{Id="10602", Index="50", Value=@"\[[20201<20034,0,0,0,0,0,0,1,1,en_US,1,0,0,0,0,0,0>]\]@@Used to display the formatted level on terminals"});
		pe.Add(new PropEntry{Id="10602", Index="51", Value=@"[20201<20030,0,0,0,0,1,0,0,1,en_US,0,0,0,0,0,0,0>][SP]\[[20201<20034,0,0,0,0,1,0,1,1,en_US,1,0,0,0,0,0,0>]\][SP][20201<20225,0,0,0,0,1,0,1,0,en_US,0,0,0,0,0,0,0>]@@Displays formatted terminal designation, levelbetween brackets, and connection description, making sure to hide empty properties and separators"});
		pe.Add(new PropEntry{Id="10602", Index="52", Value=@"([20212,1,1<20201<31011,0,0,0,0,1,0,1,1,en_US,0,0,0,0,0,0,0>>])@@Used to display the circuit number onterminals"});
		pe.Add(new PropEntry{Id="10607", Index="50", Value=@"[20205,1,2<20211,2,1<20201<1240,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>] to [20205,1,2<20211,1,1<20201<1240,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>]@@Used to display Source to Target on ML cables"});
		pe.Add(new PropEntry{Id="10607", Index="51", Value=@"[20205,2,2<20211,2,1<20201<20048,1,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>][LF] to [LF][20205,2,2<20211,1,1<20201<20048,1,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0,0>>>]@@Used to display Source to Target on patch cables in SL"});
		pe.Add(new PropEntry{Id="10608", Index="50", Value=@"[20201<31007,0,0,0,0,0,0,0,0,en_US,0,0,0,0,0,0>]/[20201<31004,0,0,0,0,1,0,1,0,en_US,1,0, ,0,0,0>]@@Used to display the AWG & color of wires"});
		pe.Add(new PropEntry{Id="10608", Index="51", Value=@"[20064<117,1<22001,0,0,0,0,1,0,0,0,en_US,0,0,0,0,0,0,0>>][117,1<22001,0,0,0,0,0,0,0,0,en_US,0,0,0,0,1,0,0>]@@On conductors, display either the parent cable part (if applicable), or the connection part (For Pull List Generator)"});
		pe.Add(new PropEntry{Id="10608", Index="52", Value=@"[20064<20201<2000,0,0,0,0,1,0,0,0,en_US,0,0,0,0,0,0,0>>][20201<2000,0,0,0,0,0,0,0,0,en_US,0,0,0,0,1,0,0>]@@On connections, get the parent cable DB ID (if applicable), or the connection DB ID (For Pull List Generator)"});
		pe.Add(new PropEntry{Id="10608", Index="53", Value=@"[20064<10001,1<20482,0,0,0,0,1,0,0,0,en_US,0,0,0,0,0,0,0>>][10001,1<20482,0,0,0,0,0,0,0,0,en_US,0,0,0,0,1,0,0>]@@On connections, get the parent cable part ref [1] (if applicable), or the connection part ref [1] (For Pull List Generator)"});
		pe.Add(new PropEntry{Id="10608", Index="54", Value=@"[20211,1,1<20134<1001,0,0,0,0,1,0,0,1,en_US,0,0,0,0,0,0,0>>]-[20211,2,1<20134<1001,0,0,0,0,1,0,1,0,en_US,0,0,0,0,0,0,0>>]@@On connections, get the Structure identifier of first target of both ends of connection. Used on 'Pull list' form to create the Automatic page description"});

		foreach(PropEntry e in pe)
		{
			cli.Execute(string.Format(@"XEsSetProjectPropertyAction /PropertyId:{0} /PropertyIndex:{1} /PropertyValue:""{2}""", e.Id, e.Index, e.Value));
		}

		System.Windows.Forms.MessageBox.Show("Block Properties imported");
		return;            
    }
	
	public class PropEntry
	{
		public string Id {get; set;}
		public string Index {get; set;}
		public string Value {get; set;}
	}
}