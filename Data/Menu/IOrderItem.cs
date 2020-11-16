/*
 * Author: Coby Walsh
 * Class: IOrderItem.cs
 * Purpose: Interface for all menu items
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Menu {
	/// <summary>
	/// interface items to be ordered
	/// </summary>
	public interface IOrderItem : INotifyPropertyChanged {
		/// <summary>
		/// the price of the item
		/// </summary>
		double Price { get; }
		/// <summary>
		/// the calories of the tiem
		/// </summary>
		uint Calories { get; }
		/// <summary>
		/// description of the item
		/// </summary>
		string Description { get; }
		/// <summary>
		/// any special instructions for preparing the item
		/// </summary>
		List<string> SpecialInstructions { get; }
		/// <summary>
		/// notifies when property is changed
		/// </summary>
		event PropertyChangedEventHandler PropertyChanged;
	}
}
