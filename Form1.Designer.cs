namespace pr4._3_Korshikova
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
            this.btnSetArray = new System.Windows.Forms.Button();
            this.btnOutputArray = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.listBoxResultArray = new System.Windows.Forms.ListBox();
            this.dGVSourseArray = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSourseArray)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetArray
            // 
            this.btnSetArray.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSetArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetArray.Location = new System.Drawing.Point(43, 383);
            this.btnSetArray.Name = "btnSetArray";
            this.btnSetArray.Size = new System.Drawing.Size(195, 31);
            this.btnSetArray.TabIndex = 0;
            this.btnSetArray.Text = "Задать массив";
            this.btnSetArray.UseVisualStyleBackColor = false;
            this.btnSetArray.Click += new System.EventHandler(this.btnSetArray_Click);
            // 
            // btnOutputArray
            // 
            this.btnOutputArray.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOutputArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOutputArray.Location = new System.Drawing.Point(300, 382);
            this.btnOutputArray.Name = "btnOutputArray";
            this.btnOutputArray.Size = new System.Drawing.Size(194, 31);
            this.btnOutputArray.TabIndex = 1;
            this.btnOutputArray.Text = "Вывод массива";
            this.btnOutputArray.UseVisualStyleBackColor = false;
            this.btnOutputArray.Click += new System.EventHandler(this.btnOutputArray_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(559, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размерность массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(280, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество нечетных \r\nэлементов на четных \r\n\r\nместах";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(203, 23);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(71, 22);
            this.textBoxN.TabIndex = 6;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(300, 23);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(71, 22);
            this.textBoxM.TabIndex = 7;
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(615, 65);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(119, 22);
            this.textBoxK.TabIndex = 8;
            // 
            // listBoxResultArray
            // 
            this.listBoxResultArray.FormattingEnabled = true;
            this.listBoxResultArray.ItemHeight = 16;
            this.listBoxResultArray.Location = new System.Drawing.Point(559, 91);
            this.listBoxResultArray.Name = "listBoxResultArray";
            this.listBoxResultArray.Size = new System.Drawing.Size(175, 276);
            this.listBoxResultArray.TabIndex = 9;
            // 
            // dGVSourseArray
            // 
            this.dGVSourseArray.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dGVSourseArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSourseArray.Location = new System.Drawing.Point(12, 63);
            this.dGVSourseArray.Name = "dGVSourseArray";
            this.dGVSourseArray.RowHeadersWidth = 51;
            this.dGVSourseArray.RowTemplate.Height = 24;
            this.dGVSourseArray.Size = new System.Drawing.Size(525, 304);
            this.dGVSourseArray.TabIndex = 10;
            this.dGVSourseArray.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 425);
            this.Controls.Add(this.dGVSourseArray);
            this.Controls.Add(this.listBoxResultArray);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOutputArray);
            this.Controls.Add(this.btnSetArray);
            this.Name = "Form1";
            this.Text = "Двумерный массив";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSourseArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetArray;
        private System.Windows.Forms.Button btnOutputArray;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.ListBox listBoxResultArray;
        private System.Windows.Forms.DataGridView dGVSourseArray;
    }
}

