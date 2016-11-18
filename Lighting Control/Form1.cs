using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Groups;

namespace Lighting_Control {
	public partial class Form1 : Form {

		private ILocalHueClient client;
		private IEnumerable<Light> lights;

		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			var dialog = new BridgeConnect(this);
			dialog.ShowDialog();
			if (dialog.Client != null) {
				this.client = dialog.Client;
				client.Initialize(dialog.ApiKey);
				MessageBox.Show(dialog.ApiKey);
			} else {
				client = null;
				MessageBox.Show("No compatible bridge was found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			UpdateLightAssignments();
		}

		private void btnUpdateLights_Click(object sender, EventArgs e) {
			UpdateLightAssignments();
		}

		private void Form1_Load(object sender, EventArgs e) {
			try {
				var text = File.ReadAllLines(@"C:\Users\sabin\hueapi.txt");
				if (client == null) {
					client = new LocalHueClient(text[0]);
				}
				client.Initialize(text[1]);
			} catch {
				// ignored
			}
		}

		private async void UpdateLightAssignments() {
			var groups = await client.GetGroupsAsync();

			listboxRooms.Items.Clear();
			foreach (var room in groups) {
				listboxRooms.Items.Add(room.Name);
			}
		}

		private async void listboxRooms_SelectedIndexChanged(object sender, EventArgs e) {
			var me = (ListBox) sender;

			if (me.SelectedIndex == -1) {
				return;
			}

			var groups = await client.GetGroupsAsync();
			this.lights = await client.GetLightsAsync();

			listboxLights.Items.Clear();

			var roomList = groups.ToList();
			Group selectedRoom = null;

			foreach (var room in roomList) {
				if (me.SelectedItem.Equals(room.Name)) {
					selectedRoom = room;
					break;
				} else {
					return;
				}
			}

			Debug.Assert(selectedRoom != null, "selectedRoom != null");
			foreach (var lightId in selectedRoom.Lights) {
				foreach (var light in this.lights) {
					if (light.Id == lightId) {
						listboxLights.Items.Add(light.Name);
					}
				}
			}
		}

		private void btnChangeColor_Click(object sender, EventArgs e) {
			string selectedLight = null;

			if (listboxLights.SelectedIndex == -1) {
				return;
			} else {
				foreach (var light in this.lights) {
					if (listboxLights.SelectedItem.Equals(light.Name)) {
						selectedLight = light.Id;
					}
				}
			}

			var dialog = new ColorDialog();
			dialog.ShowDialog();
			var selectedColor = dialog.Color;

			var command = new LightCommand();
			command.On = true;
			command.TurnOn().SetColor(new RGBColor(selectedColor.R, selectedColor.G, selectedColor.B));

			client.SendCommandAsync(command, new List<string> {selectedLight});

		}
	}
}
