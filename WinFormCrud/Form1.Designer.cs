
namespace WinFormCrud
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._comboBox__postJob = new System.Windows.Forms.ComboBox();
            this._textBox_sex = new System.Windows.Forms.TextBox();
            this._textBox_brthDay = new System.Windows.Forms.TextBox();
            this._textBox_fio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this._button_save = new System.Windows.Forms.Button();
            this._button_edit = new System.Windows.Forms.Button();
            this._button_delete = new System.Windows.Forms.Button();
            this._button_newRecord = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this._button_refresh = new System.Windows.Forms.Button();
            this._button_clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this._textBox_info = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._textBox_info);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this._comboBox__postJob);
            this.panel1.Controls.Add(this._textBox_sex);
            this.panel1.Controls.Add(this._textBox_brthDay);
            this.panel1.Controls.Add(this._textBox_fio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 173);
            this.panel1.TabIndex = 0;
            // 
            // _comboBox__postJob
            // 
            this._comboBox__postJob.FormattingEnabled = true;
            this._comboBox__postJob.Location = new System.Drawing.Point(135, 108);
            this._comboBox__postJob.Name = "_comboBox__postJob";
            this._comboBox__postJob.Size = new System.Drawing.Size(345, 21);
            this._comboBox__postJob.TabIndex = 8;
            // 
            // _textBox_sex
            // 
            this._textBox_sex.Location = new System.Drawing.Point(135, 81);
            this._textBox_sex.Name = "_textBox_sex";
            this._textBox_sex.Size = new System.Drawing.Size(345, 20);
            this._textBox_sex.TabIndex = 7;
            // 
            // _textBox_brthDay
            // 
            this._textBox_brthDay.Location = new System.Drawing.Point(135, 56);
            this._textBox_brthDay.Name = "_textBox_brthDay";
            this._textBox_brthDay.Size = new System.Drawing.Size(345, 20);
            this._textBox_brthDay.TabIndex = 6;
            // 
            // _textBox_fio
            // 
            this._textBox_fio.Location = new System.Drawing.Point(135, 30);
            this._textBox_fio.Name = "_textBox_fio";
            this._textBox_fio.Size = new System.Drawing.Size(345, 20);
            this._textBox_fio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Должность :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата Рождения :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запись :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this._button_save);
            this.panel2.Controls.Add(this._button_edit);
            this.panel2.Controls.Add(this._button_delete);
            this.panel2.Controls.Add(this._button_newRecord);
            this.panel2.Location = new System.Drawing.Point(627, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 173);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Управление записями :";
            // 
            // _button_save
            // 
            this._button_save.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button_save.Location = new System.Drawing.Point(23, 112);
            this._button_save.Name = "_button_save";
            this._button_save.Size = new System.Drawing.Size(88, 23);
            this._button_save.TabIndex = 3;
            this._button_save.Text = "Сохранить";
            this._button_save.UseVisualStyleBackColor = true;
            this._button_save.Click += new System.EventHandler(this._button_save_Click);
            // 
            // _button_edit
            // 
            this._button_edit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button_edit.Location = new System.Drawing.Point(23, 82);
            this._button_edit.Name = "_button_edit";
            this._button_edit.Size = new System.Drawing.Size(88, 23);
            this._button_edit.TabIndex = 2;
            this._button_edit.Text = "Изменить";
            this._button_edit.UseVisualStyleBackColor = true;
            this._button_edit.Click += new System.EventHandler(this._button_edit_Click);
            // 
            // _button_delete
            // 
            this._button_delete.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button_delete.Location = new System.Drawing.Point(23, 53);
            this._button_delete.Name = "_button_delete";
            this._button_delete.Size = new System.Drawing.Size(88, 23);
            this._button_delete.TabIndex = 1;
            this._button_delete.Text = "Удалить";
            this._button_delete.UseVisualStyleBackColor = true;
            this._button_delete.Click += new System.EventHandler(this._button_delete_Click);
            // 
            // _button_newRecord
            // 
            this._button_newRecord.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button_newRecord.Location = new System.Drawing.Point(23, 23);
            this._button_newRecord.Name = "_button_newRecord";
            this._button_newRecord.Size = new System.Drawing.Size(88, 23);
            this._button_newRecord.TabIndex = 0;
            this._button_newRecord.Text = "Новая Запись";
            this._button_newRecord.UseVisualStyleBackColor = true;
            this._button_newRecord.Click += new System.EventHandler(this._button_newRecord_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._button_refresh);
            this.panel3.Controls.Add(this._button_clear);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this._textBox_search);
            this.panel3.Location = new System.Drawing.Point(13, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 60);
            this.panel3.TabIndex = 2;
            // 
            // _button_refresh
            // 
            this._button_refresh.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button_refresh.Location = new System.Drawing.Point(676, 32);
            this._button_refresh.Name = "_button_refresh";
            this._button_refresh.Size = new System.Drawing.Size(83, 23);
            this._button_refresh.TabIndex = 3;
            this._button_refresh.Text = "Обновить";
            this._button_refresh.UseVisualStyleBackColor = true;
            this._button_refresh.Click += new System.EventHandler(this._button_refresh_Click);
            // 
            // _button_clear
            // 
            this._button_clear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._button_clear.Location = new System.Drawing.Point(676, 3);
            this._button_clear.Name = "_button_clear";
            this._button_clear.Size = new System.Drawing.Size(83, 23);
            this._button_clear.TabIndex = 2;
            this._button_clear.Text = "Очистить";
            this._button_clear.UseVisualStyleBackColor = true;
            this._button_clear.Click += new System.EventHandler(this._button_clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Поиск :";
            this.label7.Visible = false;
            // 
            // _textBox_search
            // 
            this._textBox_search.Location = new System.Drawing.Point(64, 20);
            this._textBox_search.Name = "_textBox_search";
            this._textBox_search.Size = new System.Drawing.Size(416, 20);
            this._textBox_search.TabIndex = 0;
            this._textBox_search.Visible = false;
            this._textBox_search.TextChanged += new System.EventHandler(this._textBox_search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(762, 280);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Информация :";
            // 
            // _textBox_info
            // 
            this._textBox_info.Location = new System.Drawing.Point(135, 138);
            this._textBox_info.Name = "_textBox_info";
            this._textBox_info.Size = new System.Drawing.Size(345, 20);
            this._textBox_info.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Учет персонала";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _comboBox__postJob;
        private System.Windows.Forms.TextBox _textBox_sex;
        private System.Windows.Forms.TextBox _textBox_brthDay;
        private System.Windows.Forms.TextBox _textBox_fio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _button_save;
        private System.Windows.Forms.Button _button_edit;
        private System.Windows.Forms.Button _button_delete;
        private System.Windows.Forms.Button _button_newRecord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _button_refresh;
        private System.Windows.Forms.Button _button_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _textBox_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox _textBox_info;
        private System.Windows.Forms.Label label8;
    }
}

