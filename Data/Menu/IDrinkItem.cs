using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Menu {
	/// <summary>
	/// interface for a drink item
	/// </summary>
	public interface IDrinkItem : INotifyPropertyChanged , ISizeable {
		/// <summary>
		/// price of the drink item
		/// </summary>
		double Price { get; }
		/// <summary>
		/// calories of the drink item
		/// </summary>
		uint Calories { get; }
		/// <summary>
		/// size of the object
		/// </summary>
		Size Size { get; set; }
		/// <summary>
		/// special instructions to make the drink item
		/// </summary>
		List<string> SpecialInstructions { get; }

		/// <summary>
		/// event to signal when properties are changed
		/// </summary>
		event PropertyChangedEventHandler PropertyChanged;
	}
}
