
namespace kursovaya
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pois = new System.Windows.Forms.TextBox();
            this.den = new System.Windows.Forms.TextBox();
            this.nomerk = new System.Windows.Forms.TextBox();
            this.nazvkl = new System.Windows.Forms.TextBox();
            this.nazvur = new System.Windows.Forms.TextBox();
            this.uchitel = new System.Windows.Forms.TextBox();
            this.nomerur = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newzap = new System.Windows.Forms.Button();
            this.udalenie = new System.Windows.Forms.Button();
            this.izmenit = new System.Windows.Forms.Button();
            this.soxranit = new System.Windows.Forms.Button();
            this.poisk = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pois
            // 
            this.pois.Location = new System.Drawing.Point(618, 13);
            this.pois.Name = "pois";
            this.pois.Size = new System.Drawing.Size(170, 20);
            this.pois.TabIndex = 1;
            this.pois.TextChanged += new System.EventHandler(this.pois_TextChanged);
            // 
            // den
            // 
            this.den.Location = new System.Drawing.Point(200, 312);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(109, 20);
            this.den.TabIndex = 3;
            // 
            // nomerk
            // 
            this.nomerk.Location = new System.Drawing.Point(200, 338);
            this.nomerk.Name = "nomerk";
            this.nomerk.Size = new System.Drawing.Size(109, 20);
            this.nomerk.TabIndex = 4;
            // 
            // nazvkl
            // 
            this.nazvkl.Location = new System.Drawing.Point(200, 364);
            this.nazvkl.Name = "nazvkl";
            this.nazvkl.Size = new System.Drawing.Size(109, 20);
            this.nazvkl.TabIndex = 5;
            // 
            // nazvur
            // 
            this.nazvur.Location = new System.Drawing.Point(200, 390);
            this.nazvur.Name = "nazvur";
            this.nazvur.Size = new System.Drawing.Size(109, 20);
            this.nazvur.TabIndex = 6;
            // 
            // uchitel
            // 
            this.uchitel.Location = new System.Drawing.Point(200, 416);
            this.uchitel.Name = "uchitel";
            this.uchitel.Size = new System.Drawing.Size(109, 20);
            this.uchitel.TabIndex = 7;
            // 
            // nomerur
            // 
            this.nomerur.Location = new System.Drawing.Point(200, 442);
            this.nomerur.Name = "nomerur";
            this.nomerur.Size = new System.Drawing.Size(109, 20);
            this.nomerur.TabIndex = 8;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(200, 286);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(109, 20);
            this.id.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "День недели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер кабинета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Название класса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Название урока";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Учитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер урока";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ЗАПИСЬ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "УПРАВЛЕНИЕ ЗАПИСЯМИ";
            // 
            // newzap
            // 
            this.newzap.Location = new System.Drawing.Point(468, 289);
            this.newzap.Name = "newzap";
            this.newzap.Size = new System.Drawing.Size(144, 39);
            this.newzap.TabIndex = 19;
            this.newzap.Text = "Новая запись";
            this.newzap.UseVisualStyleBackColor = true;
            this.newzap.Click += new System.EventHandler(this.newzap_Click);
            // 
            // udalenie
            // 
            this.udalenie.Location = new System.Drawing.Point(468, 338);
            this.udalenie.Name = "udalenie";
            this.udalenie.Size = new System.Drawing.Size(144, 38);
            this.udalenie.TabIndex = 20;
            this.udalenie.Text = "Удалить";
            this.udalenie.UseVisualStyleBackColor = true;
            this.udalenie.Click += new System.EventHandler(this.udalenie_Click);
            // 
            // izmenit
            // 
            this.izmenit.Location = new System.Drawing.Point(468, 382);
            this.izmenit.Name = "izmenit";
            this.izmenit.Size = new System.Drawing.Size(144, 37);
            this.izmenit.TabIndex = 21;
            this.izmenit.Text = "Изменить";
            this.izmenit.UseVisualStyleBackColor = true;
            this.izmenit.Click += new System.EventHandler(this.izmenit_Click);
            // 
            // soxranit
            // 
            this.soxranit.Location = new System.Drawing.Point(468, 425);
            this.soxranit.Name = "soxranit";
            this.soxranit.Size = new System.Drawing.Size(144, 33);
            this.soxranit.TabIndex = 22;
            this.soxranit.Text = "Сохранить";
            this.soxranit.UseVisualStyleBackColor = true;
            this.soxranit.Click += new System.EventHandler(this.soxranit_Click);
            // 
            // poisk
            // 
            this.poisk.Location = new System.Drawing.Point(558, 12);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(54, 23);
            this.poisk.TabIndex = 23;
            this.poisk.Text = "Поиск";
            this.poisk.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(38, 10);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 24;
            this.refresh.Text = "Обновить";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.poisk);
            this.Controls.Add(this.soxranit);
            this.Controls.Add(this.izmenit);
            this.Controls.Add(this.udalenie);
            this.Controls.Add(this.newzap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nomerur);
            this.Controls.Add(this.uchitel);
            this.Controls.Add(this.nazvur);
            this.Controls.Add(this.nazvkl);
            this.Controls.Add(this.nomerk);
            this.Controls.Add(this.den);
            this.Controls.Add(this.pois);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pois;
        private System.Windows.Forms.TextBox den;
        private System.Windows.Forms.TextBox nomerk;
        private System.Windows.Forms.TextBox nazvkl;
        private System.Windows.Forms.TextBox nazvur;
        private System.Windows.Forms.TextBox uchitel;
        private System.Windows.Forms.TextBox nomerur;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button newzap;
        private System.Windows.Forms.Button udalenie;
        private System.Windows.Forms.Button izmenit;
        private System.Windows.Forms.Button soxranit;
        private System.Windows.Forms.Button poisk;
        private System.Windows.Forms.Button refresh;
    }
}

