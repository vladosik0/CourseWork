
namespace Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.savingButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.adminPage = new System.Windows.Forms.TabPage();
            this.closeShopButton = new System.Windows.Forms.Button();
            this.changeSalary = new System.Windows.Forms.Button();
            this.salesmenDV = new System.Windows.Forms.DataGridView();
            this.clientsDV = new System.Windows.Forms.DataGridView();
            this.showProductList = new System.Windows.Forms.Button();
            this.openShopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shopsCB = new System.Windows.Forms.ComboBox();
            this.hireButton = new System.Windows.Forms.Button();
            this.firingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.clientShopCB = new System.Windows.Forms.ComboBox();
            this.buyingButton = new System.Windows.Forms.Button();
            this.priceOfBuyingTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.basketDV = new System.Windows.Forms.DataGridView();
            this.numberOfProductsDV = new System.Windows.Forms.DataGridView();
            this.adminPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesmenDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.clientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfProductsDV)).BeginInit();
            this.SuspendLayout();
            // 
            // savingButton
            // 
            this.savingButton.Location = new System.Drawing.Point(392, 590);
            this.savingButton.Name = "savingButton";
            this.savingButton.Size = new System.Drawing.Size(230, 31);
            this.savingButton.TabIndex = 1;
            this.savingButton.Text = "Зберегти всі зміни";
            this.savingButton.UseVisualStyleBackColor = true;
            this.savingButton.Click += new System.EventHandler(this.savingButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(850, 590);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(230, 31);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Завершити роботу";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // adminPage
            // 
            this.adminPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPage.Controls.Add(this.closeShopButton);
            this.adminPage.Controls.Add(this.changeSalary);
            this.adminPage.Controls.Add(this.salesmenDV);
            this.adminPage.Controls.Add(this.clientsDV);
            this.adminPage.Controls.Add(this.showProductList);
            this.adminPage.Controls.Add(this.openShopButton);
            this.adminPage.Controls.Add(this.label3);
            this.adminPage.Controls.Add(this.shopsCB);
            this.adminPage.Controls.Add(this.hireButton);
            this.adminPage.Controls.Add(this.firingButton);
            this.adminPage.Controls.Add(this.label2);
            this.adminPage.Controls.Add(this.label1);
            this.adminPage.Location = new System.Drawing.Point(4, 29);
            this.adminPage.Name = "adminPage";
            this.adminPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminPage.Size = new System.Drawing.Size(1415, 531);
            this.adminPage.TabIndex = 0;
            this.adminPage.Text = "Центр управління магазинами";
            this.adminPage.UseVisualStyleBackColor = true;
            // 
            // closeShopButton
            // 
            this.closeShopButton.Location = new System.Drawing.Point(249, 470);
            this.closeShopButton.Name = "closeShopButton";
            this.closeShopButton.Size = new System.Drawing.Size(185, 32);
            this.closeShopButton.TabIndex = 18;
            this.closeShopButton.Text = "Закрити магазин";
            this.closeShopButton.UseVisualStyleBackColor = true;
            this.closeShopButton.Click += new System.EventHandler(this.closeShopButton_Click);
            // 
            // changeSalary
            // 
            this.changeSalary.Location = new System.Drawing.Point(492, 420);
            this.changeSalary.Name = "changeSalary";
            this.changeSalary.Size = new System.Drawing.Size(185, 32);
            this.changeSalary.TabIndex = 17;
            this.changeSalary.Text = "Змінити зарплатню";
            this.changeSalary.UseVisualStyleBackColor = true;
            this.changeSalary.Click += new System.EventHandler(this.changeSalary_Click);
            // 
            // salesmenDV
            // 
            this.salesmenDV.AllowUserToAddRows = false;
            this.salesmenDV.AllowUserToDeleteRows = false;
            this.salesmenDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesmenDV.Location = new System.Drawing.Point(10, 59);
            this.salesmenDV.Name = "salesmenDV";
            this.salesmenDV.ReadOnly = true;
            this.salesmenDV.RowHeadersWidth = 62;
            this.salesmenDV.RowTemplate.Height = 28;
            this.salesmenDV.Size = new System.Drawing.Size(667, 355);
            this.salesmenDV.TabIndex = 16;
            this.salesmenDV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesmenDV_CellDoubleClick);
            // 
            // clientsDV
            // 
            this.clientsDV.AllowUserToAddRows = false;
            this.clientsDV.AllowUserToDeleteRows = false;
            this.clientsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDV.Location = new System.Drawing.Point(746, 59);
            this.clientsDV.Name = "clientsDV";
            this.clientsDV.ReadOnly = true;
            this.clientsDV.RowHeadersWidth = 62;
            this.clientsDV.RowTemplate.Height = 28;
            this.clientsDV.Size = new System.Drawing.Size(659, 355);
            this.clientsDV.TabIndex = 15;
            // 
            // showProductList
            // 
            this.showProductList.Location = new System.Drawing.Point(440, 470);
            this.showProductList.Name = "showProductList";
            this.showProductList.Size = new System.Drawing.Size(237, 32);
            this.showProductList.TabIndex = 13;
            this.showProductList.Text = "Переглянути список товарів";
            this.showProductList.UseVisualStyleBackColor = true;
            this.showProductList.Click += new System.EventHandler(this.showProductList_Click);
            // 
            // openShopButton
            // 
            this.openShopButton.Location = new System.Drawing.Point(2, 470);
            this.openShopButton.Name = "openShopButton";
            this.openShopButton.Size = new System.Drawing.Size(242, 32);
            this.openShopButton.TabIndex = 12;
            this.openShopButton.Text = "Відкрити новий магазин";
            this.openShopButton.UseVisualStyleBackColor = true;
            this.openShopButton.Click += new System.EventHandler(this.openShopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Оберіть магазин:";
            // 
            // shopsCB
            // 
            this.shopsCB.FormattingEnabled = true;
            this.shopsCB.Location = new System.Drawing.Point(185, 6);
            this.shopsCB.Name = "shopsCB";
            this.shopsCB.Size = new System.Drawing.Size(432, 28);
            this.shopsCB.TabIndex = 10;
            this.shopsCB.SelectedIndexChanged += new System.EventHandler(this.shopsCB_SelectedIndexChanged);
            // 
            // hireButton
            // 
            this.hireButton.Location = new System.Drawing.Point(249, 420);
            this.hireButton.Name = "hireButton";
            this.hireButton.Size = new System.Drawing.Size(185, 32);
            this.hireButton.TabIndex = 5;
            this.hireButton.Text = "Найняти продавця";
            this.hireButton.UseVisualStyleBackColor = true;
            this.hireButton.Click += new System.EventHandler(this.hireButton_Click);
            // 
            // firingButton
            // 
            this.firingButton.Location = new System.Drawing.Point(10, 420);
            this.firingButton.Name = "firingButton";
            this.firingButton.Size = new System.Drawing.Size(185, 32);
            this.firingButton.TabIndex = 4;
            this.firingButton.Text = "Звільнити продавця";
            this.firingButton.UseVisualStyleBackColor = true;
            this.firingButton.Click += new System.EventHandler(this.firingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список обслуговуваних покупців";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продавці";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.adminPage);
            this.tabControl1.Controls.Add(this.clientPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1423, 564);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // clientPage
            // 
            this.clientPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientPage.Controls.Add(this.label7);
            this.clientPage.Controls.Add(this.clientShopCB);
            this.clientPage.Controls.Add(this.buyingButton);
            this.clientPage.Controls.Add(this.priceOfBuyingTB);
            this.clientPage.Controls.Add(this.label6);
            this.clientPage.Controls.Add(this.label5);
            this.clientPage.Controls.Add(this.label4);
            this.clientPage.Controls.Add(this.basketDV);
            this.clientPage.Controls.Add(this.numberOfProductsDV);
            this.clientPage.Location = new System.Drawing.Point(4, 29);
            this.clientPage.Name = "clientPage";
            this.clientPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientPage.Size = new System.Drawing.Size(1415, 531);
            this.clientPage.TabIndex = 2;
            this.clientPage.Text = "Для клієнта";
            this.clientPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(966, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Оберіть магазин";
            // 
            // clientShopCB
            // 
            this.clientShopCB.FormattingEnabled = true;
            this.clientShopCB.Location = new System.Drawing.Point(970, 26);
            this.clientShopCB.Name = "clientShopCB";
            this.clientShopCB.Size = new System.Drawing.Size(235, 28);
            this.clientShopCB.TabIndex = 7;
            // 
            // buyingButton
            // 
            this.buyingButton.Location = new System.Drawing.Point(749, 461);
            this.buyingButton.Name = "buyingButton";
            this.buyingButton.Size = new System.Drawing.Size(180, 29);
            this.buyingButton.TabIndex = 6;
            this.buyingButton.Text = "Оформити покупку";
            this.buyingButton.UseVisualStyleBackColor = true;
            this.buyingButton.Click += new System.EventHandler(this.buyingButton_Click);
            // 
            // priceOfBuyingTB
            // 
            this.priceOfBuyingTB.Location = new System.Drawing.Point(633, 462);
            this.priceOfBuyingTB.Name = "priceOfBuyingTB";
            this.priceOfBuyingTB.ReadOnly = true;
            this.priceOfBuyingTB.Size = new System.Drawing.Size(100, 26);
            this.priceOfBuyingTB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Фінальна сума, грн:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Кошик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Асортимент товарів";
            // 
            // basketDV
            // 
            this.basketDV.AllowUserToAddRows = false;
            this.basketDV.AllowUserToDeleteRows = false;
            this.basketDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDV.Location = new System.Drawing.Point(516, 26);
            this.basketDV.Name = "basketDV";
            this.basketDV.ReadOnly = true;
            this.basketDV.RowHeadersWidth = 62;
            this.basketDV.RowTemplate.Height = 28;
            this.basketDV.Size = new System.Drawing.Size(364, 419);
            this.basketDV.TabIndex = 1;
            // 
            // numberOfProductsDV
            // 
            this.numberOfProductsDV.AllowUserToAddRows = false;
            this.numberOfProductsDV.AllowUserToDeleteRows = false;
            this.numberOfProductsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numberOfProductsDV.Location = new System.Drawing.Point(29, 26);
            this.numberOfProductsDV.Name = "numberOfProductsDV";
            this.numberOfProductsDV.ReadOnly = true;
            this.numberOfProductsDV.RowHeadersWidth = 62;
            this.numberOfProductsDV.RowTemplate.Height = 28;
            this.numberOfProductsDV.Size = new System.Drawing.Size(366, 419);
            this.numberOfProductsDV.TabIndex = 0;
            this.numberOfProductsDV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.numberOfProductsDV_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 634);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.savingButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Мережа магазинів \"БТА\"";
            this.adminPage.ResumeLayout(false);
            this.adminPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesmenDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.clientPage.ResumeLayout(false);
            this.clientPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfProductsDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button savingButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TabPage adminPage;
        private System.Windows.Forms.Button showProductList;
        private System.Windows.Forms.Button openShopButton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox shopsCB;
        private System.Windows.Forms.Button hireButton;
        private System.Windows.Forms.Button firingButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView basketDV;
        private System.Windows.Forms.DataGridView numberOfProductsDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buyingButton;
        public System.Windows.Forms.TextBox priceOfBuyingTB;
        public System.Windows.Forms.DataGridView clientsDV;
        public System.Windows.Forms.DataGridView salesmenDV;
        private System.Windows.Forms.Button changeSalary;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox clientShopCB;
        private System.Windows.Forms.Button closeShopButton;
    }
}

