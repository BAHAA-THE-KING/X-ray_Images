using Emgu.CV;
using Emgu.CV.Features2D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TL;
using WTelegram;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WTelegramClientTestWF
{
    public partial class MainForm : Form
    {
        private Client _client;
        //private WTelegram.Client _client;

        private List<long> _chats;
        private Dictionary<string, long> chatIdMap = new Dictionary<string, long>();
        private long selectedChatId;
        private long selectedChatIdContact;
        public string FilePath { get; set; }
        public MainForm()
        {
            InitializeComponent();
            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(s);
            buttonSendFile.Enabled = false;
            SendToUser.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client?.Dispose();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(((LinkLabel)sender).Tag as string);
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            listBox.Items.Add($"Connecting & login into Telegram servers...");
            _client = new WTelegram.Client(int.Parse(textBoxApiID.Text), textBoxApiHash.Text);
            await DoLogin(textBoxPhone.Text);
        }

        private async Task DoLogin(string loginInfo)
        {
            string what = await _client.Login(loginInfo);
            if (what != null)
            {
                listBox.Items.Add($"A {what} is required...");
                labelCode.Text = what + ':';
                textBoxCode.Text = "";
                labelCode.Visible = textBoxCode.Visible = buttonSendCode.Visible = true;
                textBoxCode.Focus();
                return;
            }
            panelActions.Visible = true;
            UserNameLabel.Visible = true;
            userName.Visible = true;
            SendToUser.Visible = true;
            listBox.Items.Add($"We are now connected as {_client.User}");
        }

        private async void buttonSendCode_Click(object sender, EventArgs e)
        {
            labelCode.Visible = textBoxCode.Visible = buttonSendCode.Visible = false;
            await DoLogin(textBoxCode.Text);
        }

        private async void buttonGetChats_Click(object sender, EventArgs e)
        {
            var result = await _client.Messages_GetAllChats();
            listBox.Items.Clear();
            foreach (var user in result.chats)
            {
                listBox.Items.Add(user.Value);

                if (!chatIdMap.ContainsKey(user.Value.ToString()))
                {
                    chatIdMap.Add(user.Value.ToString(), user.Key);
                }
                else
                {

                }

            }

        }

        private async void buttonGetMembers_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is not ChatBase chat)
            {
                MessageBox.Show("You must select a chat in the list first");
                return;
            }

            var users = chat is Channel channel
                ? (await _client.Channels_GetAllParticipants(channel)).users
                : (await _client.Messages_GetFullChat(chat.ID)).users;

            listBox.Items.Clear();
            foreach (var user in users.Values)
                listBox.Items.Add(user);


            buttonSendFile.Enabled = true;
        }
        private async void buttonSendFile_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null && string.IsNullOrEmpty(numberToSendTo.Text))
            {
                MessageBox.Show("Please select a chat or enter a phone number.");
                return;
            }


            //var file = await _client.UploadFileAsync(filePath);

            if (!string.IsNullOrEmpty(numberToSendTo.Text))
            {
                var contacts = await _client.Contacts_ImportContacts(new[] { new InputPhoneContact { phone = numberToSendTo.Text } });
                if (contacts.imported.Length > 0)
                {
                    var inputFile = await _client.UploadFileAsync(FilePath);
                    await _client.SendMediaAsync(contacts.users[contacts.imported[0].user_id], "", inputFile);
                }

            }
            else
            {

                try
                {
                    var chats = await _client.Messages_GetAllChats();
                    InputPeer peer = chats.chats[selectedChatId];
                    var inputFile = await _client.UploadFileAsync(FilePath);
                    await _client.SendMediaAsync(peer, "Here is the photo", inputFile);
                    // Your existing code here
                }
                catch (KeyNotFoundException ex)
                {
                    Console.WriteLine($"Key not found: {ex.Message}");

                }
            }
        }
        private async void buttonGetDialogs_Click(object sender, EventArgs e)
        {
            if (_client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }
            var dialogs = await _client.Messages_GetAllDialogs(null);
            listBox.Items.Clear();
            foreach (Dialog dialog in dialogs.dialogs)
            {
                var peer = dialogs.UserOrChat(dialog);
                if (peer.IsActive)
                    listBox.Items.Add(peer);
            }
        }

        private async void buttonSendMsg_Click(object sender, EventArgs e)
        {
            var msg = "_Here is your *saved message*:_\n";
            var entities = _client.MarkdownToEntities(ref msg);
            var inputFile = await _client.UploadFileAsync(FilePath);
            await _client.SendMediaAsync(InputPeer.Self, msg, inputFile);

        }

        private void numberToSendTo_TextChanged(object sender, EventArgs e)
        {
            buttonSendFile.Enabled = true;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            buttonSendFile.Enabled = true;
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.GetItemText(listBox.SelectedItem);
                if (chatIdMap.ContainsKey(selectedItem))
                {
                    chatIdMap.TryGetValue(selectedItem, out long chatId);
                    selectedChatId = chatId;

                }
                else
                {


                }
            }
        }

        private async void getContact_ClickAsync(object sender, EventArgs e)
        {
            var result = await _client.Contacts_GetContacts();
            listBox.Items.Clear();
            foreach (var user in result.users)
            {
                listBox.Items.Add(user.Key + "            " + user.Value);
            }


        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            buttonSendFile.Enabled = false;
            SendToUser.Enabled = true;
        }

        private async void SendToUser_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var resolved = await _client.Contacts_ResolveUsername(userName.Text); // without the @
                await _client.SendMessageAsync(resolved, "Hello!");
                var inputFile = await _client.UploadFileAsync(FilePath);
                await _client.SendMediaAsync(resolved, "Here is the photo", inputFile);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}

