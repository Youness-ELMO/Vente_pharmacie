﻿namespace Vente_pharmacie
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chequeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vente_pharmacieDataSet1 = new Vente_pharmacie.Vente_pharmacieDataSet1();
            this.Genre = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chequeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vente_pharmacieDataSet2 = new Vente_pharmacie.Vente_pharmacieDataSet2();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.chequeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vente_pharmacieDataSet3 = new Vente_pharmacie.Vente_pharmacieDataSet3();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.chequeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vente_pharmacieDataSet4 = new Vente_pharmacie.Vente_pharmacieDataSet4();
            this.chequeTableAdapter = new Vente_pharmacie.Vente_pharmacieDataSet1TableAdapters.ChequeTableAdapter();
            this.chequeTableAdapter1 = new Vente_pharmacie.Vente_pharmacieDataSet2TableAdapters.ChequeTableAdapter();
            this.chequeTableAdapter2 = new Vente_pharmacie.Vente_pharmacieDataSet3TableAdapters.ChequeTableAdapter();
            this.chequeTableAdapter3 = new Vente_pharmacie.Vente_pharmacieDataSet4TableAdapters.ChequeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chequeBindingSource;
            this.comboBox1.DisplayMember = "code_motif";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "code_motif";
            // 
            // chequeBindingSource
            // 
            this.chequeBindingSource.DataMember = "Cheque";
            this.chequeBindingSource.DataSource = this.vente_pharmacieDataSet1;
            // 
            // vente_pharmacieDataSet1
            // 
            this.vente_pharmacieDataSet1.DataSetName = "Vente_pharmacieDataSet1";
            this.vente_pharmacieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(17, 38);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 4;
            this.Genre.Text = "Genre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Date_emission";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Genre);
            this.groupBox1.Location = new System.Drawing.Point(341, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "- - -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "NB chèques";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(250, 100);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(69, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "numéroMA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(250, 65);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(69, 20);
            this.textBox7.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ville";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(250, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(69, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adresse";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tel";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prénom";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Montant";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 100);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Motif";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 127);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "CIN Client";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.chequeBindingSource1;
            this.comboBox2.DisplayMember = "CIN";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "CIN";
            // 
            // chequeBindingSource1
            // 
            this.chequeBindingSource1.DataMember = "Cheque";
            this.chequeBindingSource1.DataSource = this.vente_pharmacieDataSet2;
            // 
            // vente_pharmacieDataSet2
            // 
            this.vente_pharmacieDataSet2.DataSetName = "Vente_pharmacieDataSet2";
            this.vente_pharmacieDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 154);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "banque";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.chequeBindingSource2;
            this.comboBox3.DisplayMember = "code_Banque";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 150);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.ValueMember = "code_Banque";
            // 
            // chequeBindingSource2
            // 
            this.chequeBindingSource2.DataMember = "Cheque";
            this.chequeBindingSource2.DataSource = this.vente_pharmacieDataSet3;
            // 
            // vente_pharmacieDataSet3
            // 
            this.vente_pharmacieDataSet3.DataSetName = "Vente_pharmacieDataSet3";
            this.vente_pharmacieDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(12, 181);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 17);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.Text = "Magasin";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.chequeBindingSource3;
            this.comboBox4.DisplayMember = "numero_magasin";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(121, 177);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.ValueMember = "numero_magasin";
            // 
            // chequeBindingSource3
            // 
            this.chequeBindingSource3.DataMember = "Cheque";
            this.chequeBindingSource3.DataSource = this.vente_pharmacieDataSet4;
            // 
            // vente_pharmacieDataSet4
            // 
            this.vente_pharmacieDataSet4.DataSetName = "Vente_pharmacieDataSet4";
            this.vente_pharmacieDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chequeTableAdapter
            // 
            this.chequeTableAdapter.ClearBeforeFill = true;
            // 
            // chequeTableAdapter1
            // 
            this.chequeTableAdapter1.ClearBeforeFill = true;
            // 
            // chequeTableAdapter2
            // 
            this.chequeTableAdapter2.ClearBeforeFill = true;
            // 
            // chequeTableAdapter3
            // 
            this.chequeTableAdapter3.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vente_pharmacieDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox comboBox4;
        private Vente_pharmacieDataSet1 vente_pharmacieDataSet1;
        private System.Windows.Forms.BindingSource chequeBindingSource;
        private Vente_pharmacieDataSet1TableAdapters.ChequeTableAdapter chequeTableAdapter;
        private Vente_pharmacieDataSet2 vente_pharmacieDataSet2;
        private System.Windows.Forms.BindingSource chequeBindingSource1;
        private Vente_pharmacieDataSet2TableAdapters.ChequeTableAdapter chequeTableAdapter1;
        private Vente_pharmacieDataSet3 vente_pharmacieDataSet3;
        private System.Windows.Forms.BindingSource chequeBindingSource2;
        private Vente_pharmacieDataSet3TableAdapters.ChequeTableAdapter chequeTableAdapter2;
        private Vente_pharmacieDataSet4 vente_pharmacieDataSet4;
        private System.Windows.Forms.BindingSource chequeBindingSource3;
        private Vente_pharmacieDataSet4TableAdapters.ChequeTableAdapter chequeTableAdapter3;
    }
}