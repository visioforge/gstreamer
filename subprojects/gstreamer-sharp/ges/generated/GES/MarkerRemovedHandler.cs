// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void MarkerRemovedHandler(object o, MarkerRemovedArgs args);

	public class MarkerRemovedArgs : GLib.SignalArgs {
		public GES.Marker Marker{
			get {
				return (GES.Marker) Args [0];
			}
		}

	}
}