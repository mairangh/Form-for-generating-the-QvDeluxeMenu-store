namespace GenerateShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            countTextBox = new ComboBox();
            button2 = new Button();
            materalTextBox = new TextBox();
            slotTextBox = new TextBox();
            countSellStackTextBox = new TextBox();
            countBuyStackTextBox = new TextBox();
            countSellOneTextBox = new TextBox();
            countBuyOneTextBox = new TextBox();
            priceSellStackTextBox = new TextBox();
            priceSellOneTextBox = new TextBox();
            priceBuyStackTextBox = new TextBox();
            priceBuyOneTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            name_itemTextBox = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            name_headTextBox = new TextBox();
            button3 = new Button();
            priceBuyHeadTextBox = new TextBox();
            slotTextBox_Head = new TextBox();
            valueHeadTextBox = new TextBox();
            textBox10 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 166);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(countTextBox);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(materalTextBox);
            tabPage1.Controls.Add(slotTextBox);
            tabPage1.Controls.Add(countSellStackTextBox);
            tabPage1.Controls.Add(countBuyStackTextBox);
            tabPage1.Controls.Add(countSellOneTextBox);
            tabPage1.Controls.Add(countBuyOneTextBox);
            tabPage1.Controls.Add(priceSellStackTextBox);
            tabPage1.Controls.Add(priceSellOneTextBox);
            tabPage1.Controls.Add(priceBuyStackTextBox);
            tabPage1.Controls.Add(priceBuyOneTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(name_itemTextBox);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 138);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // countTextBox
            // 
            countTextBox.FormattingEnabled = true;
            countTextBox.Items.AddRange(new object[] { "1", "64" });
            countTextBox.Location = new Point(205, 34);
            countTextBox.Margin = new Padding(2);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(42, 23);
            countTextBox.TabIndex = 21;
            countTextBox.Text = "1";
            // 
            // button2
            // 
            button2.Location = new Point(240, 63);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(33, 50);
            button2.TabIndex = 26;
            button2.Text = "->\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // materalTextBox
            // 
            materalTextBox.AccessibleDescription = "";
            materalTextBox.AccessibleName = "";
            materalTextBox.Location = new Point(21, 8);
            materalTextBox.Margin = new Padding(2);
            materalTextBox.Name = "materalTextBox";
            materalTextBox.Size = new Size(104, 23);
            materalTextBox.TabIndex = 16;
            materalTextBox.Tag = "";
            // 
            // slotTextBox
            // 
            slotTextBox.Location = new Point(158, 35);
            slotTextBox.Margin = new Padding(2);
            slotTextBox.Name = "slotTextBox";
            slotTextBox.Size = new Size(32, 23);
            slotTextBox.TabIndex = 19;
            // 
            // countSellStackTextBox
            // 
            countSellStackTextBox.Location = new Point(398, 95);
            countSellStackTextBox.Margin = new Padding(2);
            countSellStackTextBox.Name = "countSellStackTextBox";
            countSellStackTextBox.Size = new Size(50, 23);
            countSellStackTextBox.TabIndex = 30;
            countSellStackTextBox.Text = "64";
            // 
            // countBuyStackTextBox
            // 
            countBuyStackTextBox.Location = new Point(398, 63);
            countBuyStackTextBox.Margin = new Padding(2);
            countBuyStackTextBox.Name = "countBuyStackTextBox";
            countBuyStackTextBox.Size = new Size(50, 23);
            countBuyStackTextBox.TabIndex = 28;
            countBuyStackTextBox.Text = "64";
            // 
            // countSellOneTextBox
            // 
            countSellOneTextBox.Location = new Point(188, 95);
            countSellOneTextBox.Margin = new Padding(2);
            countSellOneTextBox.Name = "countSellOneTextBox";
            countSellOneTextBox.Size = new Size(50, 23);
            countSellOneTextBox.TabIndex = 25;
            countSellOneTextBox.Text = "1";
            // 
            // countBuyOneTextBox
            // 
            countBuyOneTextBox.Location = new Point(188, 63);
            countBuyOneTextBox.Margin = new Padding(2);
            countBuyOneTextBox.Name = "countBuyOneTextBox";
            countBuyOneTextBox.Size = new Size(50, 23);
            countBuyOneTextBox.TabIndex = 23;
            countBuyOneTextBox.Text = "1";
            // 
            // priceSellStackTextBox
            // 
            priceSellStackTextBox.Location = new Point(277, 95);
            priceSellStackTextBox.Margin = new Padding(2);
            priceSellStackTextBox.Name = "priceSellStackTextBox";
            priceSellStackTextBox.Size = new Size(104, 23);
            priceSellStackTextBox.TabIndex = 29;
            // 
            // priceSellOneTextBox
            // 
            priceSellOneTextBox.Location = new Point(67, 95);
            priceSellOneTextBox.Margin = new Padding(2);
            priceSellOneTextBox.Name = "priceSellOneTextBox";
            priceSellOneTextBox.Size = new Size(104, 23);
            priceSellOneTextBox.TabIndex = 24;
            // 
            // priceBuyStackTextBox
            // 
            priceBuyStackTextBox.Location = new Point(277, 63);
            priceBuyStackTextBox.Margin = new Padding(2);
            priceBuyStackTextBox.Name = "priceBuyStackTextBox";
            priceBuyStackTextBox.Size = new Size(104, 23);
            priceBuyStackTextBox.TabIndex = 27;
            // 
            // priceBuyOneTextBox
            // 
            priceBuyOneTextBox.Location = new Point(67, 63);
            priceBuyOneTextBox.Margin = new Padding(2);
            priceBuyOneTextBox.Name = "priceBuyOneTextBox";
            priceBuyOneTextBox.Size = new Size(104, 23);
            priceBuyOneTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 20;
            label3.Text = "Продать";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 18;
            label2.Text = "Купить";
            // 
            // name_itemTextBox
            // 
            name_itemTextBox.Location = new Point(21, 35);
            name_itemTextBox.Margin = new Padding(2);
            name_itemTextBox.Name = "name_itemTextBox";
            name_itemTextBox.Size = new Size(104, 23);
            name_itemTextBox.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(595, 60);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(76, 20);
            button1.TabIndex = 31;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(name_headTextBox);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(priceBuyHeadTextBox);
            tabPage2.Controls.Add(slotTextBox_Head);
            tabPage2.Controls.Add(valueHeadTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 138);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // name_headTextBox
            // 
            name_headTextBox.Location = new Point(5, 61);
            name_headTextBox.Margin = new Padding(2);
            name_headTextBox.Name = "name_headTextBox";
            name_headTextBox.PlaceholderText = "Name";
            name_headTextBox.Size = new Size(104, 23);
            name_headTextBox.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(113, 88);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(139, 23);
            button3.TabIndex = 21;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // priceBuyHeadTextBox
            // 
            priceBuyHeadTextBox.Location = new Point(5, 88);
            priceBuyHeadTextBox.Margin = new Padding(2);
            priceBuyHeadTextBox.Name = "priceBuyHeadTextBox";
            priceBuyHeadTextBox.PlaceholderText = "Цена";
            priceBuyHeadTextBox.Size = new Size(104, 23);
            priceBuyHeadTextBox.TabIndex = 20;
            // 
            // slotTextBox_Head
            // 
            slotTextBox_Head.Location = new Point(113, 61);
            slotTextBox_Head.Margin = new Padding(2);
            slotTextBox_Head.Name = "slotTextBox_Head";
            slotTextBox_Head.PlaceholderText = "Slot";
            slotTextBox_Head.Size = new Size(32, 23);
            slotTextBox_Head.TabIndex = 19;
            // 
            // valueHeadTextBox
            // 
            valueHeadTextBox.AccessibleDescription = "";
            valueHeadTextBox.AccessibleName = "";
            valueHeadTextBox.Location = new Point(5, 5);
            valueHeadTextBox.Margin = new Padding(2);
            valueHeadTextBox.Multiline = true;
            valueHeadTextBox.Name = "valueHeadTextBox";
            valueHeadTextBox.PlaceholderText = "Value";
            valueHeadTextBox.Size = new Size(247, 52);
            valueHeadTextBox.TabIndex = 17;
            valueHeadTextBox.Tag = "";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(12, 183);
            textBox10.Margin = new Padding(2);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ScrollBars = ScrollBars.Vertical;
            textBox10.Size = new Size(739, 429);
            textBox10.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 629);
            Controls.Add(textBox10);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox countTextBox;
        private Button button2;
        private TextBox materalTextBox;
        private TextBox slotTextBox;
        private TextBox countSellStackTextBox;
        private TextBox countBuyStackTextBox;
        private TextBox countSellOneTextBox;
        private TextBox countBuyOneTextBox;
        private TextBox priceSellStackTextBox;
        private TextBox priceSellOneTextBox;
        private TextBox priceBuyStackTextBox;
        private TextBox priceBuyOneTextBox;
        private Label label3;
        private Label label2;
        private TextBox name_itemTextBox;
        private Button button1;
        private TabPage tabPage2;
        private TextBox textBox10;
        private TextBox valueHeadTextBox;
        private TextBox slotTextBox_Head;
        private TextBox priceBuyHeadTextBox;
        private Button button3;
        private TextBox name_headTextBox;
    }
}