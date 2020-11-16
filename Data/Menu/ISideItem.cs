using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Menu {
	/// <summary>
	/// interface for side item
	/// </summary>
	public interface ISideItem : INotifyPropertyChanged , ISizeable {
		/// <summary>
		/// price of the side item
		/// </summary>
		double Price { get; }
		/// <summary>
		/// calories of the side item
		/// </summary>
		uint Calories { get; }
		Size Size { get; set; }
		/// <summary>
		/// size of the object
		/// </summary>
		List<string> SpecialInstructions { get; }

		/// <summary>
		/// event to signal when properties are changed
		/// </summary>
		event PropertyChangedEventHandler PropertyChanged;
	}
}
