
namespace Kursach
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.getAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getSquare = new System.Windows.Forms.TextBox();
            this.addShopSubButton = new System.Windows.Forms.Button();
            this.salesmenNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адреса";
            // 
            // getAddress
            // 
            this.getAddress.Location = new System.Drawing.Point(32, 41);
            this.getAddress.Name = "getAddress";
            this.getAddress.Size = new System.Drawing.Size(239, 26);
            this.getAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Площа, м^2";
            // 
            // getSquare
            // 
            this.getSquare.Location = new System.Drawing.Point(32, 105);
            this.getSquare.Name = "getSquare";
            this.getSquare.Size = new System.Drawing.Size(239, 26);
            this.getSquare.TabIndex = 3;
            // 
            // addShopSubButton
            // 
            this.addShopSubButton.Location = new System.Drawing.Point(133, 206);
            this.addShopSubButton.Name = "addShopSubButton";
            this.addShopSubButton.Size = new System.Drawing.Size(247, 30);
            this.addShopSubButton.TabIndex = 6;
            this.addShopSubButton.Text = "Додати";
            this.addShopSubButton.UseVisualStyleBackColor = true;
            this.addShopSubButton.Click += new System.EventHandler(this.addShopSubButton_Click);
            // 
            // salesmenNumberTB
            // 
            this.salesmenNumberTB.Location = new System.Drawing.Point(32, 163);
            this.salesmenNumberTB.Name = "salesmenNumberTB";
            this.salesmenNumberTB.Size = new System.Drawing.Size(239, 26);
            this.salesmenNumberTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Максимальна кількість продавців";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salesmenNumberTB);
            this.Controls.Add(this.addShopSubButton);
            this.Controls.Add(this.getSquare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getAddress);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Відкрити магазин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getSquare;
        private System.Windows.Forms.Button addShopSubButton;
        private System.Windows.Forms.TextBox salesmenNumberTB;
        private System.Windows.Forms.Label label3;
    }
}