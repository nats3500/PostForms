namespace Post
{
    partial class AddAddress
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
            AddAdresses = new Button();
            ShowMail = new Button();
            sendMessage = new Button();
            Menu = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            buttonSendMail = new Button();
            buttonAddAddress = new Button();
            textBoxAddress = new TextBox();
            ExitButton = new Label();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddAdresses
            // 
            AddAdresses.Location = new Point(1, 162);
            AddAdresses.Margin = new Padding(4, 3, 4, 3);
            AddAdresses.Name = "AddAdresses";
            AddAdresses.Size = new Size(201, 66);
            AddAdresses.TabIndex = 5;
            AddAdresses.Text = "Добавить почтовые адреса";
            AddAdresses.UseVisualStyleBackColor = true;
            // 
            // sendMessage
            // 
            sendMessage.Location = new Point(1, 227);
            sendMessage.Margin = new Padding(4, 3, 4, 3);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(201, 66);
            sendMessage.TabIndex = 3;
            sendMessage.Text = "Отправить письмо";
            sendMessage.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ControlDarkDark;
            Menu.Controls.Add(pictureBox1);
            Menu.Controls.Add(button1);
            Menu.Controls.Add(button2);
            Menu.Controls.Add(buttonSendMail);
            Menu.Controls.Add(ExitButton);
            Menu.Location = new Point(1, -1);
            Menu.Margin = new Padding(4, 3, 4, 3);
            Menu.Name = "Menu";
            Menu.Size = new Size(201, 526);
            Menu.TabIndex = 6;
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
            // button1
            // 
            button1.Location = new Point(0, 82);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(201, 59);
            button1.TabIndex = 2;
            button1.Text = "Добавить почтовые адреса";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 213);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(201, 59);
            button2.TabIndex = 1;
            button2.Text = "Посмотреть почту";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ShowMail_Click;
            // 
            // buttonSendMail
            // 
            buttonSendMail.Location = new Point(0, 148);
            buttonSendMail.Margin = new Padding(4, 3, 4, 3);
            buttonSendMail.Name = "buttonSendMail";
            buttonSendMail.Size = new Size(201, 59);
            buttonSendMail.TabIndex = 0;
            buttonSendMail.Text = "Отправить письмо";
            buttonSendMail.UseVisualStyleBackColor = true;
            buttonSendMail.Click += buttonSendMail_Click;
            // 
            // buttonAddAddress
            // 
            buttonAddAddress.Location = new Point(281, 455);
            buttonAddAddress.Margin = new Padding(4, 3, 4, 3);
            buttonAddAddress.Name = "buttonAddAddress";
            buttonAddAddress.Size = new Size(566, 42);
            buttonAddAddress.TabIndex = 14;
            buttonAddAddress.Text = "Добавить адреса";
            buttonAddAddress.UseVisualStyleBackColor = true;
            buttonAddAddress.Click += buttonAddAddress_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(281, 46);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(565, 400);
            textBoxAddress.TabIndex = 13;
            //
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.BackColor = Color.DarkRed;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(910, 8);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(14, 15);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // AddAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonAddAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(Menu);
            Controls.Add(AddAdresses);
            Controls.Add(ShowMail);
            Controls.Add(sendMessage);
            Controls.Add(ExitButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddAddress";
            Text = "AddAddress";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddAdresses;
        private Button ShowMail;
        private Button sendMessage;
        private Panel Menu;
        private Button button1;
        private Button button2;
        private Button buttonSendMail;
        private Button buttonAddAddress;
        private TextBox textBoxAddress;
        private PictureBox pictureBox1;
        private Label ExitButton;
    }
}