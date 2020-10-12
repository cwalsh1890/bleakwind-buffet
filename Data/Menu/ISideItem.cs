using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Menu {
	/// <summary>
	/// interface for side item
	/// </summary>
	public interface ISideItem : INotifyPropertyChanged{
		/// <summary>
		/// price of the side item
		/// </summary>
		double Price { get; }
		/// <summary>
		/// calories of the side item
		/// </summary>
		uint Calories { get; }
		/// <summary>
		/// special instructions to make the side item
		/// </summary>
		List<string> SpecialInstructions { get; }

		/// <summary>
		/// event to signal when properties are changed
		/// </summary>
		event PropertyChangedEventHandler PropertyChanged;
	}
}
