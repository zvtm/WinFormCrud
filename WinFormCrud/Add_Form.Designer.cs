
namespace WinFormCrud
{
    partial class Add_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._textBox_fioF2 = new System.Windows.Forms.TextBox();
            this._textBox_birthDayF2 = new System.Windows.Forms.TextBox();
            this._textBox_sexF2 = new System.Windows.Forms.TextBox();
            this._comboBox_postJobF2 = new System.Windows.Forms.ComboBox();
            this._button_saveF2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._textBox_infoF2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание записи :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Должность :";
            // 
            // _textBox_fioF2
            // 
            this._textBox_fioF2.Location = new System.Drawing.Point(111, 45);
            this._textBox_fioF2.Name = "_textBox_fioF2";
            this._textBox_fioF2.Size = new System.Drawing.Size(250, 20);
            this._textBox_fioF2.TabIndex = 5;
            // 
            // _textBox_birthDayF2
            // 
            this._textBox_birthDayF2.Location = new System.Drawing.Point(111, 71);
            this._textBox_birthDayF2.Name = "_textBox_birthDayF2";
            this._textBox_birthDayF2.Size = new System.Drawing.Size(250, 20);
            this._textBox_birthDayF2.TabIndex = 6;
            // 
            // _textBox_sexF2
            // 
            this._textBox_sexF2.Location = new System.Drawing.Point(111, 97);
            this._textBox_sexF2.Name = "_textBox_sexF2";
            this._textBox_sexF2.Size = new System.Drawing.Size(250, 20);
            this._textBox_sexF2.TabIndex = 7;
            // 
            // _comboBox_postJobF2
            // 
            this._comboBox_postJobF2.FormattingEnabled = true;
            this._comboBox_postJobF2.Location = new System.Drawing.Point(111, 123);
            this._comboBox_postJobF2.Name = "_comboBox_postJobF2";
            this._comboBox_postJobF2.Size = new System.Drawing.Size(250, 21);
            this._comboBox_postJobF2.TabIndex = 8;
            // 
            // _button_saveF2
            // 
            this._button_saveF2.Location = new System.Drawing.Point(153, 178);
            this._button_saveF2.Name = "_button_saveF2";
            this._button_saveF2.Size = new System.Drawing.Size(75, 23);
            this._button_saveF2.TabIndex = 9;
            this._button_saveF2.Text = "Сохранить";
            this._button_saveF2.UseVisualStyleBackColor = true;
            this._button_saveF2.Click += new System.EventHandler(this._button_saveF2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Информация :";
            // 
            // _textBox_infoF2
            // 
            this._textBox_infoF2.Location = new System.Drawing.Point(111, 152);
            this._textBox_infoF2.Name = "_textBox_infoF2";
            this._textBox_infoF2.Size = new System.Drawing.Size(250, 20);
            this._textBox_infoF2.TabIndex = 11;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 219);
            this.Controls.Add(this._textBox_infoF2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._button_saveF2);
            this.Controls.Add(this._comboBox_postJobF2);
            this.Controls.Add(this._textBox_sexF2);
            this.Controls.Add(this._textBox_birthDayF2);
            this.Controls.Add(this._textBox_fioF2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBox_fioF2;
        private System.Windows.Forms.TextBox _textBox_birthDayF2;
        private System.Windows.Forms.TextBox _textBox_sexF2;
        private System.Windows.Forms.ComboBox _comboBox_postJobF2;
        private System.Windows.Forms.Button _button_saveF2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _textBox_infoF2;
    }
}