
namespace Kursach
{
    partial class VerifyBuyingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyBuyingForm));
            this.basketDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.verifyBuying = new System.Windows.Forms.Button();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salesmenCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.servingTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.shopAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basketDV)).BeginInit();
            this.SuspendLayout();
            // 
            // basketDV
            // 
            this.basketDV.AllowUserToAddRows = false;
            this.basketDV.AllowUserToDeleteRows = false;
            this.basketDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDV.Location = new System.Drawing.Point(22, 29);
            this.basketDV.Name = "basketDV";
            this.basketDV.ReadOnly = true;
            this.basketDV.RowHeadersWidth = 62;
            this.basketDV.RowTemplate.Height = 28;
            this.basketDV.Size = new System.Drawing.Size(366, 499);
            this.basketDV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кошик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ціна покупки, грн";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(487, 416);
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(134, 26);
            this.priceTB.TabIndex = 3;
            // 
            // verifyBuying
            // 
            this.verifyBuying.Location = new System.Drawing.Point(487, 491);
            this.verifyBuying.Name = "verifyBuying";
            this.verifyBuying.Size = new System.Drawing.Size(408, 37);
            this.verifyBuying.TabIndex = 4;
            this.verifyBuying.Text = "Оформити покупку";
            this.verifyBuying.UseVisualStyleBackColor = true;
            this.verifyBuying.Click += new System.EventHandler(this.verifyBuying_Click);
            // 
            // balanceTB
            // 
            this.balanceTB.Location = new System.Drawing.Point(682, 416);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(134, 26);
            this.balanceTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ваш баланс, грн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ваші дані:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Прізвище";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(487, 62);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(184, 26);
            this.lastNameTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ім\'я";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(487, 114);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(184, 26);
            this.firstNameTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "По батькові";
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(487, 166);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(184, 26);
            this.middleNameTB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Оберіть продавця:";
            // 
            // salesmenCB
            // 
            this.salesmenCB.FormattingEnabled = true;
            this.salesmenCB.Location = new System.Drawing.Point(487, 228);
            this.salesmenCB.Name = "salesmenCB";
            this.salesmenCB.Size = new System.Drawing.Size(371, 28);
            this.salesmenCB.TabIndex = 15;
            this.salesmenCB.SelectedIndexChanged += new System.EventHandler(this.salesmenCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Слова продавця після покупки:";
            // 
            // servingTB
            // 
            this.servingTB.Location = new System.Drawing.Point(487, 291);
            this.servingTB.Name = "servingTB";
            this.servingTB.ReadOnly = true;
            this.servingTB.Size = new System.Drawing.Size(371, 26);
            this.servingTB.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Оцініть обслуговування(від 1 до 5)";
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(487, 354);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(100, 26);
            this.rateTB.TabIndex = 19;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(487, 448);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(408, 37);
            this.deleteProductButton.TabIndex = 20;
            this.deleteProductButton.Text = "Видалити товар з кошика";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(585, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Адреса магазину:";
            // 
            // shopAddress
            // 
            this.shopAddress.AutoSize = true;
            this.shopAddress.Location = new System.Drawing.Point(724, 9);
            this.shopAddress.Name = "shopAddress";
            this.shopAddress.Size = new System.Drawing.Size(60, 20);
            this.shopAddress.TabIndex = 22;
            this.shopAddress.Text = "label12";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 566);
            this.Controls.Add(this.shopAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.servingTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salesmenCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balanceTB);
            this.Controls.Add(this.verifyBuying);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basketDV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Оформлення покупки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.basketDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView basketDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Button verifyBuying;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox salesmenCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox servingTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label shopAddress;
    }
}