
namespace Kursach
{
    partial class ChangeSalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSalaryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.currentSalaryTB = new System.Windows.Forms.TextBox();
            this.recSalaryTB = new System.Windows.Forms.TextBox();
            this.setSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "По батькові";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(80, 64);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.ReadOnly = true;
            this.lastNameTB.Size = new System.Drawing.Size(130, 26);
            this.lastNameTB.TabIndex = 3;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(320, 64);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.ReadOnly = true;
            this.firstNameTB.Size = new System.Drawing.Size(130, 26);
            this.firstNameTB.TabIndex = 4;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(589, 64);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.ReadOnly = true;
            this.middleNameTB.Size = new System.Drawing.Size(130, 26);
            this.middleNameTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рейтинг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Поточна зарплата, грн";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Рекомендована зарплата, грн";
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(80, 128);
            this.rateTB.Name = "rateTB";
            this.rateTB.ReadOnly = true;
            this.rateTB.Size = new System.Drawing.Size(130, 26);
            this.rateTB.TabIndex = 9;
            // 
            // currentSalaryTB
            // 
            this.currentSalaryTB.Location = new System.Drawing.Point(320, 128);
            this.currentSalaryTB.Name = "currentSalaryTB";
            this.currentSalaryTB.ReadOnly = true;
            this.currentSalaryTB.Size = new System.Drawing.Size(130, 26);
            this.currentSalaryTB.TabIndex = 10;
            // 
            // recSalaryTB
            // 
            this.recSalaryTB.Location = new System.Drawing.Point(589, 128);
            this.recSalaryTB.Name = "recSalaryTB";
            this.recSalaryTB.Size = new System.Drawing.Size(130, 26);
            this.recSalaryTB.TabIndex = 11;
            // 
            // setSalaryButton
            // 
            this.setSalaryButton.Location = new System.Drawing.Point(201, 200);
            this.setSalaryButton.Name = "setSalaryButton";
            this.setSalaryButton.Size = new System.Drawing.Size(400, 39);
            this.setSalaryButton.TabIndex = 12;
            this.setSalaryButton.Text = "Призначити зарплатню";
            this.setSalaryButton.UseVisualStyleBackColor = true;
            this.setSalaryButton.Click += new System.EventHandler(this.setSalaryButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.setSalaryButton);
            this.Controls.Add(this.recSalaryTB);
            this.Controls.Add(this.currentSalaryTB);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Змінити зарплатню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.TextBox currentSalaryTB;
        private System.Windows.Forms.TextBox recSalaryTB;
        private System.Windows.Forms.Button setSalaryButton;
    }
}