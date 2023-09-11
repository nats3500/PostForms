namespace Post
{
    partial class Client
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
            AddAdresses = new Button();
            ShowMail = new Button();
            sendMessage = new Button();
            SendMailSpace = new Panel();
            ExitButton = new Label();
            Send = new Button();
            labelText = new Label();
            textBoxContent = new TextBox();
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelRecipient = new Label();
            textBoxRecipient = new TextBox();
            labelSender = new Label();
            textBoxSender = new TextBox();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SendMailSpace.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ControlDarkDark;
            Menu.Controls.Add(pictureBox1);
            Menu.Controls.Add(AddAdresses);
            Menu.Controls.Add(ShowMail);
            Menu.Controls.Add(sendMessage);
            Menu.Location = new Point(0, 1);
            Menu.Margin = new Padding(4, 3, 4, 3);
            Menu.Name = "Menu";
            Menu.Size = new Size(201, 523);
            Menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = PostForms.Properties.Resources.red_vintage_weddings_wedding_mailbox;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 78);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AddAdresses
            // 
            AddAdresses.Location = new Point(0, 82);
            AddAdresses.Margin = new Padding(4, 3, 4, 3);
            AddAdresses.Name = "AddAdresses";
            AddAdresses.Size = new Size(201, 59);
            AddAdresses.TabIndex = 2;
            AddAdresses.Text = "Добавить почтовые адреса";
            AddAdresses.UseVisualStyleBackColor = true;
            AddAdresses.Click += AddAdresses_Click;
            // 
            // ShowMail
            // 
            ShowMail.Location = new Point(0, 213);
            ShowMail.Margin = new Padding(4, 3, 4, 3);
            ShowMail.Name = "ShowMail";
            ShowMail.Size = new Size(201, 59);
            ShowMail.TabIndex = 1;
            ShowMail.Text = "Посмотреть почту";
            ShowMail.UseVisualStyleBackColor = true;
            ShowMail.Click += ShowMail_Click;
            // 
            // sendMessage
            // 
            sendMessage.Location = new Point(0, 148);
            sendMessage.Margin = new Padding(4, 3, 4, 3);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(201, 59);
            sendMessage.TabIndex = 0;
            sendMessage.Text = "Отправить письмо";
            sendMessage.UseVisualStyleBackColor = true;
            // 
            // SendMailSpace
            // 
            SendMailSpace.Controls.Add(ExitButton);
            SendMailSpace.Controls.Add(Send);
            SendMailSpace.Controls.Add(labelText);
            SendMailSpace.Controls.Add(textBoxContent);
            SendMailSpace.Controls.Add(labelTitle);
            SendMailSpace.Controls.Add(textBoxTitle);
            SendMailSpace.Controls.Add(labelRecipient);
            SendMailSpace.Controls.Add(textBoxRecipient);
            SendMailSpace.Controls.Add(labelSender);
            SendMailSpace.Controls.Add(textBoxSender);
            SendMailSpace.Location = new Point(197, 1);
            SendMailSpace.Margin = new Padding(4, 3, 4, 3);
            SendMailSpace.Name = "SendMailSpace";
            SendMailSpace.Size = new Size(736, 519);
            SendMailSpace.TabIndex = 1;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.BackColor = Color.DarkRed;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(710, 8);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(14, 15);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Send
            // 
            Send.Location = new Point(127, 460);
            Send.Margin = new Padding(4, 3, 4, 3);
            Send.Name = "Send";
            Send.Size = new Size(439, 44);
            Send.TabIndex = 8;
            Send.Text = "Отправить";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(35, 156);
            labelText.Margin = new Padding(4, 0, 4, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(36, 15);
            labelText.TabIndex = 7;
            labelText.Text = "Текст";
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(127, 148);
            textBoxContent.Margin = new Padding(4, 3, 4, 3);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(438, 305);
            textBoxContent.TabIndex = 6;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(35, 126);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(59, 15);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Название";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(127, 118);
            textBoxTitle.Margin = new Padding(4, 3, 4, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(438, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // labelRecipient
            // 
            labelRecipient.AutoSize = true;
            labelRecipient.Location = new Point(35, 96);
            labelRecipient.Margin = new Padding(4, 0, 4, 0);
            labelRecipient.Name = "labelRecipient";
            labelRecipient.Size = new Size(73, 15);
            labelRecipient.TabIndex = 3;
            labelRecipient.Text = "Получатель";
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(127, 88);
            textBoxRecipient.Margin = new Padding(4, 3, 4, 3);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.Size = new Size(438, 23);
            textBoxRecipient.TabIndex = 2;
            // 
            // labelSender
            // 
            labelSender.AutoSize = true;
            labelSender.Location = new Point(35, 66);
            labelSender.Margin = new Padding(4, 0, 4, 0);
            labelSender.Name = "labelSender";
            labelSender.Size = new Size(78, 15);
            labelSender.TabIndex = 1;
            labelSender.Text = "Отправитель";
            // 
            // textBoxSender
            // 
            textBoxSender.Location = new Point(127, 58);
            textBoxSender.Margin = new Padding(4, 3, 4, 3);
            textBoxSender.Name = "textBoxSender";
            textBoxSender.Size = new Size(438, 23);
            textBoxSender.TabIndex = 0;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(933, 523);
            Controls.Add(SendMailSpace);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Client";
            Text = "Симуляция работы почты";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SendMailSpace.ResumeLayout(false);
            SendMailSpace.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Menu;
        private Button sendMessage;
        private Panel SendMailSpace;
        private Button ShowMail;
        private Label labelSender;
        private TextBox textBoxSender;
        private Label labelText;
        private TextBox textBoxContent;
        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelRecipient;
        private TextBox textBoxRecipient;
        private Button Send;
        private Button AddAdresses;
        private PictureBox pictureBox1;
        private Label ExitButton;
    }
}