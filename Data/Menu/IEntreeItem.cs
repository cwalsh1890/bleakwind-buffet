using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Menu {
	/// <summary>
	/// interface to represent an entree item
	/// </summary>
	public interface IEntreeItem : INotifyPropertyChanged {
		/// <summary>
		/// price of the entree item
		/// </summary>
		double Price { get; }
		/// <summary>
		/// calories of the entree item
		/// </summary>
		uint Calories { get; }
		/// <summary>
		/// special instructions to make the entree item
		/// </summary>
		List<string> SpecialInstructions { get; }

		/// <summary>
		/// event to signal when properties are changed
		/// </summary>
		event PropertyChangedEventHandler PropertyChanged;
	}
}
