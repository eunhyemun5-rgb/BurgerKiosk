namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            groupBox2 = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnlnt = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(68, 51);
            label1.Name = "label1";
            label1.Size = new Size(595, 86);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rdoChickenBurger);
            groupBox1.Controls.Add(rdoBulgogiBurger);
            groupBox1.Controls.Add(rdoHamBurger);
            groupBox1.Font = new Font("맑은 고딕", 14F);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(51, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 627);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(243, 458);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(175, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(243, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12F);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(17, 458);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(190, 49);
            rdoChickenBurger.TabIndex = 6;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨 버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12F);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(17, 281);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(222, 49);
            rdoBulgogiBurger.TabIndex = 5;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기 버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 12F);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(17, 142);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(147, 49);
            rdoHamBurger.TabIndex = 4;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSauce);
            groupBox2.Controls.Add(chkCheese);
            groupBox2.Controls.Add(chkCola);
            groupBox2.Controls.Add(chkPotato);
            groupBox2.Font = new Font("맑은 고딕", 14F);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(533, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 452);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(22, 361);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(219, 55);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(22, 281);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(219, 55);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(22, 189);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(130, 55);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(22, 97);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(206, 55);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 14F);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(868, 195);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(518, 513);
            grpOrder.TabIndex = 0;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(58, 417);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(229, 51);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액: 0원";
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(31, 85);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(457, 304);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 16F);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(868, 745);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(268, 77);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnlnt
            // 
            btnlnt.BackColor = Color.Red;
            btnlnt.Font = new Font("맑은 고딕", 16F);
            btnlnt.ForeColor = SystemColors.ButtonHighlight;
            btnlnt.Location = new Point(1165, 745);
            btnlnt.Name = "btnlnt";
            btnlnt.Size = new Size(221, 77);
            btnlnt.TabIndex = 3;
            btnlnt.Text = "초기화";
            btnlnt.UseVisualStyleBackColor = false;
            btnlnt.Click += btnlnt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 877);
            Controls.Add(btnlnt);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buger Kiosk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnlnt;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private PictureBox pictureBox3;
        private CheckBox chkSauce;
    }
}
