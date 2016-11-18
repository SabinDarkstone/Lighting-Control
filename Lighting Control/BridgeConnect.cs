using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.Interfaces;

namespace Lighting_Control {
	public partial class BridgeConnect : Form {

		public ILocalHueClient Client {
			get {
				if (listboxBridgesFound.SelectedIndex != -1) {
					return new LocalHueClient(listboxBridgesFound.SelectedItem.ToString());
				} else {
					return null;
				}
			}
		}

		public string ApiKey { get; private set; }

		private Form mainForm;

		public BridgeConnect() {
			InitializeComponent();
		}

		public BridgeConnect(Form parentForm) {
			InitializeComponent();
			mainForm = parentForm;
		}

		private void BridgeConnect_Load(object sender, EventArgs e) {

		}

		private async void btnSearchAgain_Click(object sender, EventArgs e) {
			var locator = new HttpBridgeLocator();
			List<string> list = null;

			try {
				IEnumerable<string> bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
				list = bridgeIPs.ToList();
			} catch (Exception ex) {
				MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (list != null && list.Count > 0) {
				foreach (var ip in list) {
					AddItemToList(ip, false);
				}
			}
		}

		private async void btnRegisterApp_Click(object sender, EventArgs e) {
			try {
				var tempClient = new LocalHueClient(listboxBridgesFound.SelectedItem.ToString());
				ApiKey = await tempClient.RegisterAsync("Lighting-Control", "Matther-Laptop");

				using (var file = new StreamWriter(@"C:\Users\sabin\hueapi.txt")) {
					file.Write(ApiKey);
				}

				MessageBox.Show("Successfully registered app", "Success!");
			} catch (Exception ex) {
				MessageBox.Show("Please press the connect button on the hub.", "Error connecting");
			}

		}

		private void btnSelectBridge_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}

		private void listboxBridgesFound_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void AddItemToList(string item, bool overwrite) {
			if (overwrite) {
				listboxBridgesFound.Items.Clear();
			}

			if (!listboxBridgesFound.Items.Contains(item)) {
				listboxBridgesFound.Items.Add(item);
			}
		}
	}
}
