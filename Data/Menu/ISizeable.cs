using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Menu {
	/// <summary>
	/// object is a sizeable object
	/// </summary>
	public interface ISizeable {
		/// <summary>
		/// size of the object
		/// </summary>
		Size Size { get; set; }
	}
}
