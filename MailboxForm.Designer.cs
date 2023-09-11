namespace Post
{
    partial class MailboxForm
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
            Menu = new Panel();
            pictureBox1 = new PictureBox();
            AddAdress = new Button();
            MailboxButtonMenu = new Button();
            SendMessageButtonMenu = new Button();
            AddAdresses = new Button();
            ShowMail = new Button();
            sendMessage = new Button();
            listMailbox = new ListBox();
            menuAddresses = new ComboBox();
            ExitButton = new Label();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ControlDarkDark;
            Menu.Controls.Add(pictureBox1);
            Menu.Controls.Add(AddAdress);
            Menu.Controls.Add(MailboxButtonMenu);
            Menu.Controls.Add(SendMessageButtonMenu);
            Menu.Location = new Point(2, -2);
            Menu.Margin = new Padding(4, 3, 4, 3);
            Menu.Name = "Menu";
            Menu.Size = new Size(201, 528);
            Menu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = PostForms.Properties.Resources.red_vintage_weddings_wedding_mailbox;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 78);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AddAdress
            // 
            AddAdress.Location = new Point(0, 82);
            AddAdress.Margin = new Padding(4, 3, 4, 3);
            AddAdress.Name = "AddAdress";
            AddAdress.Size = new Size(201, 59);
            AddAdress.TabIndex = 2;
            AddAdress.Text = "Добавить почтовые адреса";
            AddAdress.UseVisualStyleBackColor = true;
            AddAdress.Click += AddAdress_Click;
            // 
            // MailboxButtonMenu
            // 
            MailboxButtonMenu.Location = new Point(0, 213);
            MailboxButtonMenu.Margin = new Padding(4, 3, 4, 3);
            MailboxButtonMenu.Name = "MailboxButtonMenu";
            MailboxButtonMenu.Size = new Size(201, 59);
            MailboxButtonMenu.TabIndex = 1;
            MailboxButtonMenu.Text = "Посмотреть почту";
            MailboxButtonMenu.UseVisualStyleBackColor = true;
            // 
            // SendMessageButtonMenu
            // 
            SendMessageButtonMenu.Location = new Point(0, 148);
            SendMessageButtonMenu.Margin = new Padding(4, 3, 4, 3);
            SendMessageButtonMenu.Name = "SendMessageButtonMenu";
            SendMessageButtonMenu.Size = new Size(201, 59);
            SendMessageButtonMenu.TabIndex = 0;
            SendMessageButtonMenu.Text = "Отправить письмо";
            SendMessageButtonMenu.UseVisualStyleBackColor = true;
            SendMessageButtonMenu.Click += SendMessageButtonMenu_Click;
            // 
            // AddAdresses
            // 
            AddAdresses.Location = new Point(2, 168);
            AddAdresses.Margin = new Padding(4, 3, 4, 3);
            AddAdresses.Name = "AddAdresses";
            AddAdresses.Size = new Size(201, 59);
            AddAdresses.TabIndex = 9;
            AddAdresses.Text = "Добавить почтовые адреса";
            AddAdresses.UseVisualStyleBackColor = true;
            // 
            // ShowMail
            // 
            ShowMail.Location = new Point(2, 300);
            ShowMail.Margin = new Padding(4, 3, 4, 3);
            ShowMail.Name = "ShowMail";
            ShowMail.Size = new Size(201, 59);
            ShowMail.TabIndex = 8;
            ShowMail.Text = "Посмотреть почту";
            ShowMail.UseVisualStyleBackColor = true;
            // 
            // sendMessage
            // 
            sendMessage.Location = new Point(2, 234);
            sendMessage.Margin = new Padding(4, 3, 4, 3);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(201, 59);
            sendMessage.TabIndex = 7;
            sendMessage.Text = "Отправить письмо";
            sendMessage.UseVisualStyleBackColor = true;
            // 
            // listMailbox
            // 
            listMailbox.FormattingEnabled = true;
            listMailbox.ItemHeight = 15;
            listMailbox.Location = new Point(230, 54);
            listMailbox.Margin = new Padding(4, 3, 4, 3);
            listMailbox.Name = "listMailbox";
            listMailbox.Size = new Size(672, 439);
            listMailbox.TabIndex = 11;
            // 
            // menuAddresses
            // 
            menuAddresses.FormattingEnabled = true;
            menuAddresses.Location = new Point(231, 16);
            menuAddresses.Name = "menuAddresses";
            menuAddresses.Size = new Size(121, 23);
            menuAddresses.TabIndex = 12;
            menuAddresses.SelectedIndexChanged += menuAddresses_SelectedIndexChanged;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.BackColor = Color.DarkRed;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(907, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(14, 15);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // MailboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(933, 519);
            Controls.Add(ExitButton);
            Controls.Add(menuAddresses);
            Controls.Add(listMailbox);
            Controls.Add(Menu);
            Controls.Add(AddAdresses);
            Controls.Add(ShowMail);
            Controls.Add(sendMessage);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MailboxForm";
            Text = "MailboxForm";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Menu;
        private Button AddAdress;
        private Button MailboxButtonMenu;
        private Button SendMessageButtonMenu;
        private Button AddAdresses;
        private Button ShowMail;
        private Button sendMessage;
        private ListBox listMailbox;
        private ComboBox menuAddresses;
        private PictureBox pictureBox1;
        private Label ExitButton;
    }
}