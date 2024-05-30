
namespace WTelegramClientTestWF
{
    partial class Telegram_Share
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            buttonGetChats = new Button();
            listBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel = new LinkLabel();
            label3 = new Label();
            labelCode = new Label();
            textBoxCode = new TextBox();
            buttonSendCode = new Button();
            panelActions = new Panel();
            getContact = new Button();
            numberToSendTo = new TextBox();
            label4 = new Label();
            buttonSendFile = new Button();
            buttonSendMsg = new Button();
            textBoxPhone = new TextBox();
            textBoxApiHash = new TextBox();
            textBoxApiID = new TextBox();
            UserNameLabel = new Label();
            userName = new TextBox();
            SendToUser = new Button();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(355, 48);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 32);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Connect/Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonGetChats
            // 
            buttonGetChats.Location = new Point(3, 4);
            buttonGetChats.Margin = new Padding(3, 4, 3, 4);
            buttonGetChats.Name = "buttonGetChats";
            buttonGetChats.Size = new Size(105, 45);
            buttonGetChats.TabIndex = 0;
            buttonGetChats.Text = "Get chats";
            buttonGetChats.UseVisualStyleBackColor = true;
            buttonGetChats.Click += buttonGetChats_Click;
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(12, 148);
            listBox.Margin = new Padding(3, 4, 3, 4);
            listBox.Name = "listBox";
            listBox.Size = new Size(666, 384);
            listBox.TabIndex = 12;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 15);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(58, 26);
            label1.TabIndex = 0;
            label1.Text = "api_id:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 15);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(2);
            label2.Size = new Size(78, 26);
            label2.TabIndex = 2;
            label2.Text = "api_hash:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkArea = new LinkArea(13, 28);
            linkLabel.Location = new Point(559, 18);
            linkLabel.Name = "linkLabel";
            linkLabel.Padding = new Padding(2);
            linkLabel.Size = new Size(295, 29);
            linkLabel.TabIndex = 4;
            linkLabel.TabStop = true;
            linkLabel.Tag = "https://my.telegram.org/apps";
            linkLabel.Text = "get these at https://my.telegram.org/apps";
            linkLabel.UseCompatibleTextRendering = true;
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 50);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(2);
            label3.Size = new Size(147, 26);
            label3.TabIndex = 5;
            label3.Text = "user phone number:";
            // 
            // labelCode
            // 
            labelCode.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCode.Location = new Point(473, 50);
            labelCode.Margin = new Padding(0);
            labelCode.Name = "labelCode";
            labelCode.Padding = new Padding(2);
            labelCode.Size = new Size(143, 26);
            labelCode.TabIndex = 8;
            labelCode.Text = "verification_code:";
            labelCode.Visible = false;
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCode.Location = new Point(619, 50);
            textBoxCode.Margin = new Padding(3, 4, 3, 4);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(94, 22);
            textBoxCode.TabIndex = 9;
            textBoxCode.Visible = false;
            // 
            // buttonSendCode
            // 
            buttonSendCode.Location = new Point(719, 48);
            buttonSendCode.Margin = new Padding(3, 4, 3, 4);
            buttonSendCode.Name = "buttonSendCode";
            buttonSendCode.Size = new Size(81, 32);
            buttonSendCode.TabIndex = 10;
            buttonSendCode.Text = "Verify";
            buttonSendCode.UseVisualStyleBackColor = true;
            buttonSendCode.Visible = false;
            buttonSendCode.Click += buttonSendCode_Click;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelActions.Controls.Add(getContact);
            panelActions.Controls.Add(numberToSendTo);
            panelActions.Controls.Add(label4);
            panelActions.Controls.Add(buttonSendFile);
            panelActions.Controls.Add(buttonSendMsg);
            panelActions.Controls.Add(buttonGetChats);
            panelActions.Location = new Point(12, 88);
            panelActions.Margin = new Padding(3, 4, 3, 4);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(831, 52);
            panelActions.TabIndex = 11;
            panelActions.Visible = false;
            // 
            // getContact
            // 
            getContact.Location = new Point(115, 4);
            getContact.Margin = new Padding(3, 4, 3, 4);
            getContact.Name = "getContact";
            getContact.Size = new Size(105, 45);
            getContact.TabIndex = 8;
            getContact.Text = "Get contact";
            getContact.UseVisualStyleBackColor = true;
            getContact.Click += getContact_ClickAsync;
            // 
            // numberToSendTo
            // 
            numberToSendTo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberToSendTo.Location = new Point(639, 16);
            numberToSendTo.Margin = new Padding(3, 4, 3, 4);
            numberToSendTo.Name = "numberToSendTo";
            numberToSendTo.Size = new Size(179, 22);
            numberToSendTo.TabIndex = 7;
            numberToSendTo.TextChanged += numberToSendTo_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 14);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(217, 27);
            label4.TabIndex = 6;
            label4.Text = "phone number to send to:";
            // 
            // buttonSendFile
            // 
            buttonSendFile.Location = new Point(224, 4);
            buttonSendFile.Margin = new Padding(3, 4, 3, 4);
            buttonSendFile.Name = "buttonSendFile";
            buttonSendFile.Size = new Size(105, 45);
            buttonSendFile.TabIndex = 4;
            buttonSendFile.Text = "Send";
            buttonSendFile.UseVisualStyleBackColor = true;
            buttonSendFile.Click += buttonSendFile_Click;
            // 
            // buttonSendMsg
            // 
            buttonSendMsg.Location = new Point(335, 4);
            buttonSendMsg.Margin = new Padding(3, 4, 3, 4);
            buttonSendMsg.Name = "buttonSendMsg";
            buttonSendMsg.Size = new Size(105, 45);
            buttonSendMsg.TabIndex = 3;
            buttonSendMsg.Text = "Send to self...";
            buttonSendMsg.UseVisualStyleBackColor = true;
            buttonSendMsg.Click += buttonSendMsg_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPhone.Location = new Point(170, 50);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(179, 22);
            textBoxPhone.TabIndex = 6;
            // 
            // textBoxApiHash
            // 
            textBoxApiHash.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxApiHash.Location = new Point(273, 15);
            textBoxApiHash.Margin = new Padding(3, 4, 3, 4);
            textBoxApiHash.Name = "textBoxApiHash";
            textBoxApiHash.Size = new Size(280, 22);
            textBoxApiHash.TabIndex = 3;
            // 
            // textBoxApiID
            // 
            textBoxApiID.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxApiID.Location = new Point(71, 15);
            textBoxApiID.Margin = new Padding(3, 4, 3, 4);
            textBoxApiID.Name = "textBoxApiID";
            textBoxApiID.Size = new Size(100, 22);
            textBoxApiID.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            UserNameLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(690, 159);
            UserNameLabel.Margin = new Padding(0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Padding = new Padding(2);
            UserNameLabel.Size = new Size(110, 27);
            UserNameLabel.TabIndex = 9;
            UserNameLabel.Text = "User Name";
            UserNameLabel.Visible = false;
            // 
            // userName
            // 
            userName.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.Location = new Point(688, 190);
            userName.Margin = new Padding(3, 4, 3, 4);
            userName.Name = "userName";
            userName.Size = new Size(155, 22);
            userName.TabIndex = 9;
            userName.Visible = false;
            userName.TextChanged += userName_TextChanged;
            // 
            // SendToUser
            // 
            SendToUser.Location = new Point(709, 236);
            SendToUser.Margin = new Padding(3, 4, 3, 4);
            SendToUser.Name = "SendToUser";
            SendToUser.Size = new Size(105, 45);
            SendToUser.TabIndex = 13;
            SendToUser.Text = "Send To User";
            SendToUser.UseVisualStyleBackColor = true;
            SendToUser.Visible = false;
            SendToUser.Click += SendToUser_ClickAsync;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 548);
            Controls.Add(SendToUser);
            Controls.Add(userName);
            Controls.Add(UserNameLabel);
            Controls.Add(panelActions);
            Controls.Add(buttonSendCode);
            Controls.Add(labelCode);
            Controls.Add(textBoxCode);
            Controls.Add(label3);
            Controls.Add(textBoxPhone);
            Controls.Add(linkLabel);
            Controls.Add(label2);
            Controls.Add(textBoxApiHash);
            Controls.Add(label1);
            Controls.Add(textBoxApiID);
            Controls.Add(listBox);
            Controls.Add(buttonLogin);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(830, 363);
            Name = "MainForm";
            Text = "WTelegramClient - WinForms example";
            FormClosing += MainForm_FormClosing;
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGetChats;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxApiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApiHash;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonSendMsg;
        private Button buttonSendFile;
        private TextBox numberToSendTo;
        private Label label4;
        private Button getContact;
        private TextBox userName;
        private Label UserNameLabel;
        private Button SendToUser;
    }
}

