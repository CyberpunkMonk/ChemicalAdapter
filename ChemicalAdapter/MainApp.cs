using System;

namespace ChemicalAdapter {
	/// <summary>
	/// MainApp startup class
	/// </summary>
	class MainApp {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		static void Main() {
			//Non-adapted chemical compound
			Compound unknown = new Compound("Unknown");
			unknown.Display();
			//Adapted chemical compounds
			Compound water = new RichCompound("Water");
			Compound benzene = new RichCompound("Benzene");
			Compound ethanol = new RichCompound("Ethanol");
			water.Display();
			benzene.Display();
			ethanol.Display();
			//Wait for user.
			Console.ReadKey();
		}
	}
}