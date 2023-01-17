namespace Sql
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.comboQuery = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPar1 = new System.Windows.Forms.TextBox();
            this.boxPar2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxPar3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxPar4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxPar5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxPar6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pathDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPathQuery = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnPathDB = new System.Windows.Forms.Button();
            this.btnPathQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Query:";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 529);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1188, 373);
            this.dgv.TabIndex = 10;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEsegui.Location = new System.Drawing.Point(468, 451);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(260, 59);
            this.btnEsegui.TabIndex = 12;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // comboQuery
            // 
            this.comboQuery.BackColor = System.Drawing.Color.White;
            this.comboQuery.FormattingEnabled = true;
            this.comboQuery.Location = new System.Drawing.Point(217, 188);
            this.comboQuery.Name = "comboQuery";
            this.comboQuery.Size = new System.Drawing.Size(948, 28);
            this.comboQuery.TabIndex = 14;
            this.comboQuery.SelectedIndexChanged += new System.EventHandler(this.comboQuery_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Par1";
            // 
            // boxPar1
            // 
            this.boxPar1.BackColor = System.Drawing.Color.White;
            this.boxPar1.Location = new System.Drawing.Point(217, 286);
            this.boxPar1.Name = "boxPar1";
            this.boxPar1.Size = new System.Drawing.Size(278, 27);
            this.boxPar1.TabIndex = 16;
            // 
            // boxPar2
            // 
            this.boxPar2.BackColor = System.Drawing.Color.White;
            this.boxPar2.Location = new System.Drawing.Point(217, 344);
            this.boxPar2.Name = "boxPar2";
            this.boxPar2.Size = new System.Drawing.Size(278, 27);
            this.boxPar2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Par2";
            // 
            // boxPar3
            // 
            this.boxPar3.BackColor = System.Drawing.Color.White;
            this.boxPar3.Location = new System.Drawing.Point(217, 401);
            this.boxPar3.Name = "boxPar3";
            this.boxPar3.Size = new System.Drawing.Size(278, 27);
            this.boxPar3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 38);
            this.label6.TabIndex = 19;
            this.label6.Text = "Par3";
            // 
            // boxPar4
            // 
            this.boxPar4.BackColor = System.Drawing.Color.White;
            this.boxPar4.Location = new System.Drawing.Point(887, 286);
            this.boxPar4.Name = "boxPar4";
            this.boxPar4.Size = new System.Drawing.Size(278, 27);
            this.boxPar4.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(692, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "Par4";
            // 
            // boxPar5
            // 
            this.boxPar5.BackColor = System.Drawing.Color.White;
            this.boxPar5.Location = new System.Drawing.Point(887, 344);
            this.boxPar5.Name = "boxPar5";
            this.boxPar5.Size = new System.Drawing.Size(278, 27);
            this.boxPar5.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(692, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 38);
            this.label8.TabIndex = 23;
            this.label8.Text = "Par5";
            // 
            // boxPar6
            // 
            this.boxPar6.BackColor = System.Drawing.Color.White;
            this.boxPar6.Location = new System.Drawing.Point(887, 401);
            this.boxPar6.Name = "boxPar6";
            this.boxPar6.Size = new System.Drawing.Size(278, 27);
            this.boxPar6.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(692, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 38);
            this.label9.TabIndex = 25;
            this.label9.Text = "Par6";
            // 
            // pathDB
            // 
            this.pathDB.BackColor = System.Drawing.Color.White;
            this.pathDB.Location = new System.Drawing.Point(217, 81);
            this.pathDB.Name = "pathDB";
            this.pathDB.Size = new System.Drawing.Size(948, 27);
            this.pathDB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "DB";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(22, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 38);
            this.label10.TabIndex = 28;
            this.label10.Text = "SQL";
            // 
            // txtPathQuery
            // 
            this.txtPathQuery.BackColor = System.Drawing.Color.White;
            this.txtPathQuery.Location = new System.Drawing.Point(217, 134);
            this.txtPathQuery.Name = "txtPathQuery";
            this.txtPathQuery.Size = new System.Drawing.Size(948, 27);
            this.txtPathQuery.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(22, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 38);
            this.label11.TabIndex = 30;
            this.label11.Text = "Testo query";
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.White;
            this.txtQuery.Location = new System.Drawing.Point(217, 236);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(948, 27);
            this.txtQuery.TabIndex = 31;
            // 
            // btnPathDB
            // 
            this.btnPathDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPathDB.Location = new System.Drawing.Point(1171, 81);
            this.btnPathDB.Name = "btnPathDB";
            this.btnPathDB.Size = new System.Drawing.Size(27, 27);
            this.btnPathDB.TabIndex = 32;
            this.btnPathDB.Text = "...";
            this.btnPathDB.UseVisualStyleBackColor = true;
            this.btnPathDB.Click += new System.EventHandler(this.btnPathDB_Click);
            // 
            // btnPathQuery
            // 
            this.btnPathQuery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPathQuery.Location = new System.Drawing.Point(1171, 134);
            this.btnPathQuery.Name = "btnPathQuery";
            this.btnPathQuery.Size = new System.Drawing.Size(27, 27);
            this.btnPathQuery.TabIndex = 33;
            this.btnPathQuery.Text = "...";
            this.btnPathQuery.UseVisualStyleBackColor = true;
            this.btnPathQuery.Click += new System.EventHandler(this.btnPathQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1212, 914);
            this.Controls.Add(this.btnPathQuery);
            this.Controls.Add(this.btnPathDB);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPathQuery);
            this.Controls.Add(this.boxPar6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxPar5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxPar4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxPar3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxPar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxPar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboQuery);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathDB);
            this.Name = "Form1";
            this.Text = "SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private DataGridView dgv;
        private Button btnEsegui;
        private ComboBox comboQuery;
        private Label label4;
        private TextBox boxPar1;
        private TextBox boxPar2;
        private Label label5;
        private TextBox boxPar3;
        private Label label6;
        private TextBox boxPar4;
        private Label label7;
        private TextBox boxPar5;
        private Label label8;
        private TextBox boxPar6;
        private Label label9;
        private TextBox pathDB;
        private Label label2;
        private Label label10;
        private TextBox txtPathQuery;
        private Label label11;
        private TextBox txtQuery;
        private Button btnPathDB;
        private Button btnPathQuery;
    }
}